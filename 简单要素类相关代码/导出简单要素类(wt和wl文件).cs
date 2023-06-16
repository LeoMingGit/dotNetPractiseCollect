
        /// <summary>
        /// 生成点类型要素类
        /// </summary>
        /// <param name="gdb"></param>
        /// <param name="projectName"></param>
        /// <param name="sheetName"></param>
        /// <param name="mainSheetDataList"></param>
        /// <returns></returns>
        private  ActionResult<string> GeneratePointSfcls(DataBase gdb,string projectName,string sheetName, List<MainSheetExport6XDto> mainSheetDataList)
        {
            //按照项目名称创建一个简单要素集（简单要素集名称为项目名称 + 当前时间戳）
            var timestamp = GeoSuveryCommonHelper.GetUnixTimestamp();
            // 创建简单要素集
            var sfsName = $"{projectName}_{timestamp}";
            var dsID = gdb.CreateFds(sfsName, 0);
            if (dsID <= 0) return new ActionResult<string>(false, "创建简单要素集失败");
            //要素类名称：表单名称+时间
            var config = ProjectConfig.Instance;
            var tempgdburl = $"{config.DBUrl}/ds/{sfsName}";
            var sfsclsName = sheetName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            PntInfo _PntInfo = new PntInfo();
            //设置点的图形信息
            int[] outcl = new int[3];
            outcl[0] = 6;
            float[] outpen = new float[3];
            outpen[0] = 5;
            _PntInfo.SymID = 34; //符号编号,34代表一个圆点符号（参考平台符号库）
            _PntInfo.OutClr = outcl; //可变颜色1,6:红色（参考平台颜色库）
            _PntInfo.Width = 5; //宽度
            _PntInfo.Height = 8; //高度
            _PntInfo.OutPenW = outpen; //外部笔宽1
                                       //创建点类型的简单要素类
            var  _sfcls = GDBURLHelper.CreateXCls($"{tempgdburl}/sfcls/{sfsclsName}", GeomType.Pnt) as SFeatureCls;
            var fields = new GeoObjects.Att.Fields();
            //属性的表头
            foreach (var item in mainSheetDataList.FirstOrDefault()?.Data)
            {
                fields.AppendField(MapGisOper.CreateStringField(item.Name, item.Name, 2));
            }
            _sfcls.Fields = fields;
            //添加点位
            var moveIndex = 0;
            foreach (var item in mainSheetDataList)
            {
                //构造点
                var dot = new Dot3D((double)item.X, (double)item.Y, 0);
                //添加点，返出成功添加的点的ID
                var _GeoPoints = new GeoPoints();
                _GeoPoints.Append(dot);
                var rcd = new Record();
                rcd.Fields = _sfcls.Fields;//赋值属性，很重要
                foreach (var itemSheet in mainSheetDataList[moveIndex++].Data)
                {
                    rcd.SetValue(itemSheet.Name, itemSheet.Value);
                }
                var ObjID = _sfcls.Append(_GeoPoints, rcd, _PntInfo);//ObjID > 0 添加点简单要素成功
            }

            //转换成wt文件
            DataConvert DataCvr = new DataConvert();
            //CfgManager.Inst.TempPath  此版本不支持
            var tempPath = Path.Combine(CfgManager.Inst.ProgramPath, "Temp");
            if (Directory.Exists(tempPath) == false) Directory.CreateDirectory(tempPath);
            var wtFilePath = Path.Combine(tempPath, $"{ sheetName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss")}.wt");
            //创建转换后的要素类
            SFeatureCls pntsfcls = new SFeatureCls(gdb);
            int sur = DataCvr.OpenSource(_sfcls);
            int des = DataCvr.OpenDestination(wtFilePath);
            //控制是否转换成功
            bool flag = false;
            if (sur > 0 && des > 0)
            {
                //转换数据
                flag = DataCvr.Convert() > 0;
            }
            //关闭类、数据库、断开数据源
            GDBURLHelper.CloseXCls(_sfcls);
            gdb.Close();
            if (flag == false) return new ActionResult<string>(false, "转换成6x文件失败", "");
            return new ActionResult<string>(true, "生成6x文件成功", wtFilePath);

        }

        /// <summary>
        /// 生成线类型的简单要素类
        /// </summary>
        /// <param name="gdb"></param>
        /// <param name="projectName"></param>
        /// <param name="sheetName"></param>
        /// <param name="mainSheetDataList"></param>
        /// <returns></returns>
        private ActionResult<string> GenerateLineSfcls(DataBase gdb, string projectName, string sheetName, List<MainSheetExport6XDto> mainSheetDataList)
        {
            //按照项目名称创建一个简单要素集（简单要素集名称为项目名称 + 当前时间戳）
            var timestamp = GeoSuveryCommonHelper.GetUnixTimestamp();
            // 创建简单要素集
            var sfsName = $"{projectName}_{timestamp}";
            var dsID = gdb.CreateFds(sfsName, 0);
            if (dsID <= 0) return new ActionResult<string>(false, "创建简单要素集失败");
            //要素类名称：表单名称+时间
            var config = ProjectConfig.Instance;
            var tempgdburl = $"{config.DBUrl}/ds/{sfsName}";
            var sfsclsName = sheetName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
            //设置线的图形信息
            var _LinInfo = new LinInfo();
            int[] outcl = new int[3];
            outcl[0] = 7;
            float[] outpen = new float[3];
            outpen[0] = 8;
            _LinInfo.OutClr = outcl;
            _LinInfo.OutPenW = outpen;

            //创建线类型的简单要素类
            var _sfcls = GDBURLHelper.CreateXCls($"{tempgdburl}/sfcls/{sfsclsName}", GeomType.Lin) as SFeatureCls;
            var fields = new GeoObjects.Att.Fields();
            //属性的表头
            foreach (var item in mainSheetDataList.FirstOrDefault()?.Data)
            {
                fields.AppendField(MapGisOper.CreateStringField(item.Name, item.Name, 2));
            }
            _sfcls.Fields = fields;
            //添加线
            var moveIndex = 0;
            foreach (var item in mainSheetDataList)
            {
                var _GeoVarLine = new GeoVarLine();
                var dotsList = item.LineData.OrderBy(x => x.Index).ToList();
                foreach (var dotItem in dotsList)
                {
                    var dot = new Dot3D((double)dotItem.X, (double)dotItem.Y, 0);
                    _GeoVarLine.Append(dot);
                }
                var rcd = new Record();
                rcd.Fields = _sfcls.Fields;//赋值属性，很重要
                foreach (var itemSheet in mainSheetDataList[moveIndex++].Data)
                {
                    rcd.SetValue(itemSheet.Name, itemSheet.Value);
                }
                var ObjID = _sfcls.Append(_GeoVarLine, rcd, _LinInfo);//ObjID > 0 添加点简单要素成功
            }

            //转换成wt文件
            DataConvert DataCvr = new DataConvert();
            //CfgManager.Inst.TempPath  此版本不支持
            var tempPath = Path.Combine(CfgManager.Inst.ProgramPath, "Temp");
            if (Directory.Exists(tempPath) == false) Directory.CreateDirectory(tempPath);
            var wlFilePath = Path.Combine(tempPath, $"{ sheetName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss")}.wl");
            //创建转换后的要素类
            SFeatureCls pntsfcls = new SFeatureCls(gdb);
            int sur = DataCvr.OpenSource(_sfcls);
            int des = DataCvr.OpenDestination(wlFilePath);
            //控制是否转换成功
            bool flag = false;
            if (sur > 0 && des > 0)
            {
                //转换数据
                flag = DataCvr.Convert() > 0;
            }
            //关闭类、数据库、断开数据源
            GDBURLHelper.CloseXCls(_sfcls);
            gdb.Close();
            if (flag == false) return new ActionResult<string>(false, "转换成6x文件失败", "");
            return new ActionResult<string>(true, "生成6x文件成功", wlFilePath);

        }

        /// <summary>
        /// 查询主表中的数据
        /// </summary>
        /// <param name="prjId">项目Id</param>
        /// <param name="sheetName">表单ID</param>
        /// <param name="sheetDataIds">选择的数据ID</param>
        /// <param name="sfclsType">要素类的类型</param>
        /// <returns></returns>
        private List<MainSheetExport6XDto> ResolveMainSheetData(string prjId,string sheetName,List<string> sheetDataIds, out string sfclsType)
        {
            var mongodb = MongoDBHelper.MongoDB;
            // 模板数据，从sheet集合中取
            var  templateCollection = mongodb?.GetCollection<SheetInfo>(MongoDBHelper.SheetCollectionName);
            var templateFilter = Builders<SheetInfo>.Filter.And(
                Builders<SheetInfo>.Filter.Eq(_ => _.PrjId, prjId),
                Builders<SheetInfo>.Filter.Eq(_ => _.SheetName, sheetName)
            );
            var  templateData= templateCollection.Find(templateFilter).ToList().FirstOrDefault();
            //查询简单要素类的类型
            sfclsType = templateData.sfclsType;
            // 获取主表数据，从sheetData集合中取数据
            var sheetDataCollection = mongodb?.GetCollection<SheetDataInfo>(MongoDBHelper.SheetDataCollectionName);
            var sheetDataFilter = Builders<SheetDataInfo>.Filter.And(
                Builders<SheetDataInfo>.Filter.In(_ => _.Id, sheetDataIds),
                Builders<SheetDataInfo>.Filter.Eq(_ => _.PrjId, prjId),
                Builders<SheetDataInfo>.Filter.Eq(_ => _.SheetName, sheetName)
            );
            var sheetDataList = sheetDataCollection.Find(sheetDataFilter).ToList();

            //模板数据 和主表数据要进行比对

            var listData = new List<MainSheetExport6XDto>();
            var templateFiledData = SheetServerImpl.ParseData(templateData.Data)?.Obj;
            foreach (var item in sheetDataList)
            {
                var dataRes = SheetServerImpl.ParseData(item.Data)?.Obj;
                var dto = new MainSheetExport6XDto();
                var itemData = new List<NameValueObj>();
                foreach (var key in templateFiledData.Keys)
                {
                    //字段的名称会被修改，所以根据key来关联起来
                    if (dataRes.ContainsKey(key))
                    {
                        var target_value_name = dataRes[key] as NameValueObj;
                        target_value_name.Name = (templateFiledData[key] as NameValueObj).Name;
                        itemData.Add(target_value_name);
                    }
                    else
                    {
                        //主表数据中没有相应的字段
                        var target_value_name = templateFiledData[key] as NameValueObj;
                        itemData.Add(target_value_name);
                    }
                }
                dto.LineData = item.LineData;
                dto.Data = itemData;
                if (itemData.Where(x => x.Name == "X").ToList().FirstOrDefault()!=null&&double.TryParse( itemData.Where(x => x.Name == "X").ToList().FirstOrDefault().Value?.ToString(),out double tmpX))
                {
                    dto.X = tmpX;
                }
                if (itemData.Where(x => x.Name == "Y").ToList().FirstOrDefault() != null && double.TryParse(itemData.Where(x => x.Name == "Y").ToList().FirstOrDefault().Value?.ToString(), out double tmpY))
                {
                    dto.Y = tmpY;
                }
                listData.Add(dto);
            }
           
            return listData;
        }