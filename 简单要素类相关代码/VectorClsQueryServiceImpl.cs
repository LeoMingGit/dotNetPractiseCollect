using MapGIS.GeoDataBase;
using MapGIS.GeoObjects;
using MapGIS.GeoObjects.Geometry;
using MapGIS.GM.Apworks;
using MapGIS.GM.DataWorks.Core.Attributes;
using MapGIS.GM.DataWorks.Core.Models;
using MapGIS.GM.DataWorks.Core.Service;
using MapGIS.GM.GISHelper;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MapGIS.GM.DataWorks.Core.Helpers;
using MapGIS.GeoMap;
using MapGIS.GM.Apworks.Contrib.Utils;
using NPOI.XSSF.UserModel;
using MapGIS.GM.Apworks.Application;
//using MapGIS.GM.BaseService;
using MapGIS.GM.Entity.AttachInfo;
using System.Security.Cryptography;
using MapGIS.GM.DataWorks.Core.FileProcReporter;

namespace MapGIS.GM.DataWorks.Core.ServiceImpl
{
    [AutoIocService(typeof(IVectorClsQueryService))]
    public class VectorClsQueryServiceImpl : IVectorClsQueryService
    {
        public ActionResult<List<AttFieldStruct>> GetFields(IVectorCls vecCls, bool toLower = true)
        {
            var fields = GetInfo(vecCls, toLower);
            return ActionResult<List<AttFieldStruct>>.OK(fields);
        }

        public ActionResult<Page<VectorClsRecord>> Query(IVectorCls vecCls
            , string geoJson, List<Criteria> criterias, bool isQueryGeometry, int? pageNum, int? pageSize)
        {
            GeoPolygons polygons = null;
            if (!string.IsNullOrEmpty(geoJson))
            {
                polygons = GeometryOpHelper.GeoJson2Polygons(geoJson);
            }

            if (criterias != null && criterias.Any())
            {
                var atts = GetInfo(vecCls, false);
                foreach (var item in criterias)
                {
                    var t = atts.FirstOrDefault(x => x.Field.Equals(item.Field, StringComparison.OrdinalIgnoreCase));
                    if (t == null)
                    {
                        return new ActionResult<Page<VectorClsRecord>>(false, $"'{item.Field}' 不存在");
                    }
                    item.FieldType = atts.FirstOrDefault(x => x.Field == item.Field).Type;
                }
            }
            XRet ret = new XRet(true, "");
            var where = CommonMethod.Criteria2SqlWhere(criterias, (x) => { ret = x; }, true);
            if (!ret.Succ)
            {
                return ActionResult<Page<VectorClsRecord>>.Fail(ret.Obj);
            }
            int totoal = 0;
            var result = DoQuery(vecCls, polygons, isQueryGeometry, pageNum, pageSize, where, ref totoal);
            var ar = ActionResult<Page<VectorClsRecord>>.OK(new Page<VectorClsRecord>
            {
                Data = result,
                Total = totoal
            });

            return ar;
        }

        public ActionResult<List<object>> GetAttValue(IVectorCls vecCls, string fieldName)
        {
            return GetAttValue(vecCls, fieldName, "");
        }

        public ActionResult<string> Parse6x(string file)
        {
            if (string.IsNullOrEmpty(file))
            {
                return ActionResult<string>.Fail("文件路径为空");
            }

            if (!GDBURLHelper.IsValid(file))
            {
                return ActionResult<string>.Fail("文件格式不正确，非6x文件");
            }

            string geoJson = string.Empty;
            var pointList = new List<List<Models.Point>>();
            var sfcls = GDBURLHelper.OpenXCls(file) as SFeatureCls;
            if (sfcls != null)
            {
                var recordSet = sfcls.Query(new QueryDef { CursorType = SetCursorType.ForwardCacheAtt });
                recordSet.MoveFirst();
                if (sfcls.GeomType == GeomType.Pnt)
                {
                    var geoPoints = new GeoPoints();
                    while (!recordSet.IsEOF)
                    {
                        if (recordSet.Geometry is GeoPoints gp)
                        {
                            var dots = gp.GetDots();
                            var dotNum = dots.Count;
                            for (int i = 0; i < dotNum; i++)
                            {
                                geoPoints.Append(new Dot3D { X = dots.GetItem(i).X, Y = dots.GetItem(i).Y, Z = dots.GetItem(i).Z });
                            }
                        }
                        recordSet.MoveNext();
                    }
                    geoJson = geoPoints.ToGeoJSON();
                }
                else if (sfcls.GeomType == GeomType.Lin)
                {
                    var geoLines = new GeoLines();
                    while (!recordSet.IsEOF)
                    {
                        if (recordSet.Geometry is GeoVarLine varLine)
                        {
                            geoLines.Append(varLine);
                        }
                        recordSet.MoveNext();
                    }
                    geoJson = geoLines.ToGeoJSON();
                }
                else if (sfcls.GeomType == GeomType.Reg)
                {
                    var polygons = new GeoPolygons();
                    while (!recordSet.IsEOF)
                    {
                        if (recordSet.Geometry is GeoPolygon polygon)
                        {
                            polygons.Append(polygon);
                        }
                        recordSet.MoveNext();
                    }
                    geoJson = polygons.ToGeoJSON();
                }
                else
                {
                    recordSet.Dispose();
                    GDBURLHelper.CloseXCls(sfcls);
                    return ActionResult<string>.Fail("6x文件数据非点、线、区格式数据");
                }

                recordSet.Dispose();
                GDBURLHelper.CloseXCls(sfcls);
                return new ActionResult<string>(true, "", geoJson);
            }

            return ActionResult<string>.Fail("文件格式不正确，非6x文件");
        }

        public ActionResult<string> ExportToExcel(IVectorCls vecCls, string geoJson, List<Criteria> criterias, int? pageNum, int? pageSize)
        {
            var reslut = Query(vecCls, geoJson, criterias, false, pageNum, pageSize).Obj.Data;
            if (reslut != null)
            {
                var fields = GetFields(vecCls).Obj;
                var path = Path.Combine(CfgManager.Inst.TempPath, Guid.NewGuid().ToString("N") + ".xlsx");
                using (var fs = new FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
                {
                    var wb = WorkbookFactory.Create(path);
                    var sheet = wb.CreateSheet();
                    var row0 = sheet.CreateRow(0);
                    row0.ZeroHeight = true;
                    var row1 = sheet.CreateRow(1);
                    var colCount = fields.Count;
                    for (int c = 0; c < colCount; c++)
                    {
                        row0.CreateCell(c).SetCellValue(fields[c].Field);
                        row1.CreateCell(c).SetCellValue(fields[c].Alias);
                    }

                    var attVals = reslut;
                    var rowCount = attVals.Count() + 2;
                    for (int i = 0; i < rowCount; i++)
                    {
                        var row = sheet.CreateRow(2 + i);
                        for (int k = 0; k < colCount; k++)
                        {
                            var val = attVals[i].Record[fields[k].Field]?.ToString();
                            row.CreateCell(k).SetCellValue(val);
                        }
                    }
                    wb.Write(fs);
                }

                var tmpFileId = DataWorksRuntime.Instance.GetService<IGmFileStorageService>().GetTempFileStorageService()
                     .StoreFile(Path.GetFileName(path), path, "", "", "", "", new Log4NetFileProcReporter());
                File.Delete(path);
                if (string.IsNullOrEmpty(tmpFileId))
                {
                    return new ActionResult<string>(false, "结果存储失败");
                }
                return new ActionResult<string>(true, "", tmpFileId);
            }
            return new ActionResult<string>(false, "没有查到数据");
        }

        #region private

        private List<AttFieldStruct> GetInfo(IVectorCls vecCls, bool toLower = true)
        {
            var fieldStructs = new List<AttFieldStruct>();
            if (vecCls != null)
            {
                var fields = vecCls.Fields;
                var fldCount = fields.Count;
                if (toLower)
                {
                    for (int i = 0; i < fldCount; i++)
                    {
                        var alias = fields[i].GetExtField()?.Alias;
                        fieldStructs.Add(new AttFieldStruct
                        {
                            Field = fields[i].FieldName.ToLower(),
                            Alias = string.IsNullOrEmpty(alias) ? fields[i].FieldName : alias,
                            Type = AttFieldTypeConvert.Convert(fields[i].FieldType)
                        });
                    }
                }
                else
                {
                    for (int i = 0; i < fldCount; i++)
                    {
                        fieldStructs.Add(new AttFieldStruct
                        {
                            Field = fields[i].FieldName,
                            Alias = fields[i].GetExtField()?.Alias ?? fields[i].FieldName,
                            Type = AttFieldTypeConvert.Convert(fields[i].FieldType)
                        });
                    }
                }

            }

            return fieldStructs;
        }

        private List<VectorClsRecord> DoQuery(IVectorCls vecCls, GeoPolygons polygons, bool isQueryGeometry
            , int? pageNum, int? pageSize, string where, ref int total, bool useAlias = false)
        {
            var queryResult = new List<VectorClsRecord>();

            var def = new QueryDef();
            if (isQueryGeometry)
            {
                def.CursorType = SetCursorType.ForwardCacheAll;
            }
            else
            {
                def.CursorType = SetCursorType.ForwardCacheAtt;
            }

            if (polygons != null)
            {
                def.SetSpatial(polygons, SpaQueryMode.Intersect);
            }

            if (!string.IsNullOrEmpty(where))
            {
                def.Filter = where;
            }

            if (isQueryGeometry)
            {
                RecordSet recordSet = null;
                if (vecCls is SFeatureCls sfcls)
                {
                    recordSet = sfcls.Query(def);
                }
                else if (vecCls is AnnotationCls annCls)
                {
                    recordSet = annCls.Query(def);
                }

                if (recordSet != null)
                {
                    recordSet.MoveFirst();
                    while (!recordSet.IsEOF)
                    {
                        var att = recordSet.Att;
                        var fields = att.Fields;
                        var fldCount = fields.Count;

                        var dic = new Dictionary<string, object>();
                        for (int i = 0; i < fldCount; i++)
                        {
                            if (useAlias)
                            {
                                var fieldName = fields[i].GetExtField()?.Alias;
                                fieldName = string.IsNullOrEmpty(fields[i].GetExtField()?.Alias) ? fields[i].FieldName : fields[i].GetExtField()?.Alias;
                                dic.Add(fieldName, att.get_FldVal(fields[i].FieldName));
                            }
                            else
                            {
                                dic.Add(fields[i].FieldName, att.get_FldVal(fields[i].FieldName));
                            }
                        }

                        queryResult.Add(new VectorClsRecord
                        {
                            Oid = recordSet.CurrentID,
                            //Range = recordSet.Rect,
                            Geometry = recordSet.Geometry,
                            Record = dic
                        });

                        recordSet.MoveNext();
                    }
                    recordSet.Dispose();
                }
            }
            else
            {
                RecordSet recordSet = null;
                if (vecCls is SFeatureCls sfcls)
                {
                    recordSet = sfcls.Query(def);
                }
                else if (vecCls is AnnotationCls annCls)
                {
                    recordSet = annCls.Query(def);
                }

                if (recordSet != null)
                {
                    recordSet.MoveFirst();
                    while (!recordSet.IsEOF)
                    {
                        var att = recordSet.Att;
                        var fields = att.Fields;
                        var fldCount = fields.Count;

                        var dic = new Dictionary<string, object>();
                        for (int i = 0; i < fldCount; i++)
                        {
                            dic.Add(fields[i].FieldName, att.get_FldVal(fields[i].FieldName));
                        }

                        queryResult.Add(new VectorClsRecord
                        {
                            Oid = recordSet.CurrentID,
                            //Range = recordSet.Rect,
                            Record = dic
                        });

                        recordSet.MoveNext();
                    }
                    recordSet.Dispose();
                }
            }

            total = queryResult.Count;
            if (pageSize.HasValue && pageNum.HasValue)
            {
                queryResult = queryResult.Skip(pageNum.Value * pageSize.Value).Take(pageSize.Value).ToList();
            }

            return queryResult;
        }

        #endregion


        public ActionResult<Page<VectorClsRecord>> Query(IVectorCls vecCls, List<Criteria> criterias, bool isQueryGeometry, int? pageNum, int? pageSize)
        {
            if (criterias != null && criterias.Any())
            {
                var atts = GetInfo(vecCls, false);
                foreach (var item in criterias)
                {
                    var t = atts.FirstOrDefault(x => x.Field.Equals(item.Field, StringComparison.OrdinalIgnoreCase));
                    if (t == null)
                    {
                        return new ActionResult<Page<VectorClsRecord>>(false, $"'{item.Field}' 不存在");
                    }
                    item.FieldType = atts.FirstOrDefault(x => x.Field == item.Field).Type;
                }
            }
            XRet ret = new XRet(true, "");
            var where = CommonMethod.Criteria2SqlWhere(criterias, (x) => { ret = x; }, true);
            if (!ret.Succ)
            {
                return ActionResult<Page<VectorClsRecord>>.Fail(ret.Obj);
            }
            int totoal = 0;
            var result = DoQuery(vecCls, null, isQueryGeometry, pageNum, pageSize, where, ref totoal);
            return ActionResult<Page<VectorClsRecord>>.OK(new Page<VectorClsRecord>
            {
                Data = result,
                Total = totoal
            });
        }

        public ActionResult<Page<VectorClsRecord>> Query(string mapx, int layerIndex, string geoJson, List<Criteria> criterias, bool isQueryGeometry, int? pageNum, int? pageSize)
        {
            XRet ret = new XRet(true, "");
            var where = CommonMethod.Criteria2SqlWhere(criterias, (x) => { ret = x; }, true);
            if (!ret.Succ)
            {
                return ActionResult<Page<VectorClsRecord>>.Fail(ret.Obj);
            }
            int total = 0;
            var records = new List<VectorClsRecord>();
            IBasCls basCls = null;
            Document document = new Document();
            if (document.Open(mapx) > 0)
            {
                DocumentItem docItem = document.GetMaps()?.GetMap(0)?.get_Layer(layerIndex);
                if (docItem != null)
                {
                    docItem = document.GetScenes()?.GetScene(0)?.GetLayer(layerIndex);
                }
                if (docItem != null)
                {
                    MapLayer mapLayer = docItem as MapLayer;
                    if (mapLayer != null)
                    {
                        basCls = mapLayer.GetData();
                    }
                    else
                    {
                        MapGIS.Scene3D.G3DLayer g3DLayer = docItem as MapGIS.Scene3D.G3DLayer;
                        if (g3DLayer != null)
                        {
                            basCls = g3DLayer.GetData();
                        }
                    }
                }
            };
            if (basCls is IVectorCls vectorCls)
            {
                GeoPolygons polygons = null;
                if (!string.IsNullOrEmpty(geoJson))
                {
                    polygons = GeometryOpHelper.GeoJson2Polygons(geoJson);
                }
                records = DoQuery(vectorCls, polygons, false, pageNum, pageSize, where, ref total);
            }
            document.Close(false);

            return ActionResult<Page<VectorClsRecord>>.OK(new Page<VectorClsRecord>
            {
                Data = records,
                Total = total
            });
        }

        public ActionResult<List<object>> GetAttValue(IVectorCls vecCls, string fieldName, string geoJson)
        {
            if (vecCls == null)
            {
                return ActionResult<List<object>>.Fail("获取图层数据失败");
            }
            var def = new QueryDef();
            if (!string.IsNullOrEmpty(geoJson))
            {
                var polygons = GeometryOpHelper.GeoJson2Polygons(geoJson);
                if (null == polygons)
                {
                    return new ActionResult<List<object>>(false, "请传入正确的几何范围");
                }
                def.SetSpatial(polygons, SpaQueryMode.Intersect);
            }
            var attValCollection = new List<object>();
            RecordSet recordSet = null;
            if (vecCls is SFeatureCls sfcls)
            {
                def.CursorType = SetCursorType.ForwardCacheAtt;
                recordSet = sfcls.Query(def);
            }
            else if (vecCls is AnnotationCls annCls)
            {
                def.CursorType = SetCursorType.ForwardCacheAtt;
                recordSet = annCls.Query(def);
            }
            if (recordSet != null)
            {
                recordSet.MoveFirst();
                while (!recordSet.IsEOF)
                {
                    if ("oid".Equals(fieldName, StringComparison.OrdinalIgnoreCase))
                    {
                        attValCollection.Add(recordSet.CurrentID);
                    }
                    else
                    {
                        var val = recordSet.Att.get_FldVal(fieldName);
                        attValCollection.Add(val);
                    }

                    recordSet.MoveNext();
                }
                recordSet.Dispose();
            }

            return ActionResult<List<object>>.OK(attValCollection);
        }

        public ActionResult<string> ExportToExcel(List<IVectorCls> vectorClsList, string geoJson, List<Criteria> criterias, int? pageNum, int? pageSize)
        {
            var dic = new Dictionary<string, IList<VectorClsRecord>>();
            foreach (var item in vectorClsList)
            {
                var rcd = Query(item, geoJson, criterias, false, pageNum, pageSize).Obj.Data;
                var clsName = string.IsNullOrEmpty(item.AliasName) ? item.ClsName : item.AliasName;
                if (dic.ContainsKey(clsName))
                {
                    clsName = clsName + "(01)";
                    item.ClsName = clsName;
                }
                dic.Add(clsName, rcd);
            }

            var path = Path.Combine(CfgManager.Inst.TempPath, $"查询结果.xlsx");
            using (var fs = new FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
            {
                var wb = new XSSFWorkbook();
                foreach (var item in dic)
                {
                    var fields = GetInfo(vectorClsList.FirstOrDefault(x => x.ClsName == item.Key || x.AliasName == item.Key), false);
                    var sheet = wb.CreateSheet(item.Key);
                    var row0 = sheet.CreateRow(0);
                    row0.ZeroHeight = true;
                    var row1 = sheet.CreateRow(1);
                    for (int c = 0; c < fields.Count; c++)
                    {
                        row0.CreateCell(c).SetCellValue(fields[c].Field);
                        row1.CreateCell(c).SetCellValue(fields[c].Alias);
                    }
                    sheet.DefaultColumnWidth = 30;
                    int rowIndex = 2;
                    foreach (var itv in item.Value)
                    {
                        var rcd = itv.Record;
                        var row = sheet.CreateRow(rowIndex);
                        for (int k = 0; k < fields.Count; k++)
                        {
                            row.CreateCell(k).SetCellValue(rcd[fields[k].Field]?.ToString());
                        }
                        rowIndex += 1;
                    }

                }

                wb.Write(fs);
            }
            var tmpFileId = DataWorksRuntime.Instance.GetService<IGmFileStorageService>().GetTempFileStorageService()
                  .StoreFile(Path.GetFileName(path), path, "", "", "", "", new Log4NetFileProcReporter());
            File.Delete(path);
            if (string.IsNullOrEmpty(tmpFileId))
            {
                return new ActionResult<string>(false, "结果存储失败");
            }
            return new ActionResult<string>(true, "", tmpFileId);
        }

        public ActionResult<List<AttRecord>> GetAttRecord(IVectorCls vecCls, long oId)
        {
            List<AttRecord> attRecords = new List<AttRecord>();
            if (vecCls != null)
            {
                var record = vecCls.GetAtt(oId);
                for (int i = 0; i < record.Fields.Count; i++)
                {
                    var field = record.Fields[i];
                    attRecords.Add(new AttRecord
                    {
                        Field = field.FieldName,
                        Alias = field.GetExtField()?.Alias,
                        Value = record.GetFldToStr(field.FieldName),
                        FieldType = AttFieldTypeConvert.Convert(field.FieldType)
                    });
                }
            }

            return ActionResult<List<AttRecord>>.OK(attRecords);
        }
    }
}
