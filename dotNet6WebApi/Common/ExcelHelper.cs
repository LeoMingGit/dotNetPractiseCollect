using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace Common
{
    public static class ExcelHelper
    {
        public static HttpResponseMessage ListToExcel_ResponseMessage<T>(List<T> data,string filename)
        {
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            MemoryStream ms= ListToExcel(data,filename);
            result.Content = new StreamContent(ms);
            filename = filename + DateTime.Now.ToString("yyyymmddhhmmss") + ".xlsx";
            result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
            result.Content.Headers.ContentDisposition.FileName = HttpUtility.UrlEncode(filename);
            System.Web.HttpContext.Current.Response.Headers.Add("Access-Control-Expose-Headers", "Content-Disposition");
            return result;
        }
        /// <summary>
        /// 创建表格样式
        /// </summary>
        /// <param name="sheet"></param>
        /// <returns></returns>
        public static ICellStyle GetCellStyle(IWorkbook workbook, int type,string value)
        {
            ICellStyle style = workbook.CreateCellStyle();
            style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
            style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
            return style;
        }
        public static MemoryStream ListToExcel<T>(List<T> data,string filename="")
        {
            // 2007版本
            string sheetName = "sheet";
            bool isColumnWritten = true;
            IWorkbook workbook = new XSSFWorkbook();
            try
            {
                var sheet = workbook.CreateSheet(sheetName);
                ICellStyle s = workbook.CreateCellStyle();
                s.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.Grey25Percent.Index;
                s.FillPattern = FillPattern.SolidForeground;
                var count = 0;
                var list = new List<string>();
                //标题
                PropertyInfo[] properties = typeof(T).GetProperties();
                if (isColumnWritten)
                {
                    var row = sheet.CreateRow(0);
                    for (int j = 0; j < properties.Count(); j++)
                    {
                        var item = properties[j];
                        var attrsDisplayName = item.GetCustomAttributes(typeof(DisplayNameAttribute), true);
                        if (attrsDisplayName != null && attrsDisplayName.Count() > 0)
                        {
                            var displayName = ((DisplayNameAttribute)attrsDisplayName[0]).DisplayName;
                            row.CreateCell(list.Count()).SetCellValue(displayName);
                            row.GetCell(list.Count()).CellStyle = s;
                            list.Add(item.Name);
                        }
                    }
                    count = 1;
                }
                else
                {
                    count = 0;
                }
                if (data.Count > 0)
                {
                    //数据
                    for (var i = 0; i < data.Count; ++i)
                    {
                        var itemData = data[i];
                        var row = sheet.CreateRow(count);
                        for (int iCell = 0; iCell < list.Count; iCell++)
                        {
                            var p = list[iCell];
                            var Properties = itemData.GetType().GetProperties().Where(c => c.Name == p).FirstOrDefault();
                            var value = Properties.GetValue(itemData)?.ToString();
                            row.CreateCell(iCell).SetCellValue(value);
                            var cell = row.GetCell(iCell);
                            SetBizStyleCell(ref cell, workbook, Properties.Name, filename, value);
                        }
                        ++count;
                    }
                }
                else
                {
                    var row = sheet.CreateRow(count);
                    for (int iCell = 0; iCell < list.Count; iCell++)
                        row.CreateCell(iCell).SetCellValue("");
                }


                for (int columnNum = 0; columnNum <= list.Count; columnNum++)
                {
                    int columnWidth = sheet.GetColumnWidth(columnNum) / 256;//获取当前列宽度
                    for (int rowNum = 0; rowNum <= sheet.LastRowNum; rowNum++)//在这一列上循环行
                    {
                        IRow currentRow = sheet.GetRow(rowNum);
                        ICell currentCell = currentRow.GetCell(columnNum);
                        if (currentCell != null && !currentCell.ToString().IsNullOrEmpty())
                        {
                            int length = Encoding.UTF8.GetBytes(currentCell.ToString()).Length;//获取当前单元格的内容宽度
                            if (columnWidth < length + 1)
                            {
                                columnWidth = length + 1;
                            }//若当前单元格内容宽度大于列宽，则调整列宽为当前单元格宽度，后面的+1是我人为的将宽度增加一个字符
                        }

                    }
                    sheet.SetColumnWidth(columnNum, columnWidth * 256);
                }

                //写入到excel
                var ms = new NpoiMemoryStream();
                ms.AllowClose = false;
                workbook.Write(ms);
                ms.Flush();
                ms.Seek(0, SeekOrigin.Begin);
                ms.AllowClose = true;
                return ms;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 根据业务逻辑来设置某个单元格的样式
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="workbook"></param>
        /// <param name="FieldName"></param>
        /// <param name="exceltype"></param>
        /// <param name="value"></param>
        public  static void SetBizStyleCell(ref ICell cell, IWorkbook workbook ,string FieldName,string exceltype,object value)
        {
            #region   销售订单同步列表
            if (FieldName == "syncStatusRemark"&&exceltype.Contains("销售订单同步列表"))
            {
                if (value.ToString() == "未完成")
                {
                    //创建一个字体颜色
                    IFont font = workbook.CreateFont();
                    //红色
                    font.Color = HSSFColor.Red.Index;
                    //样式
                    ICellStyle style = workbook.CreateCellStyle();
                    //给样式设置字体
                    style.SetFont(font);
                    cell.CellStyle = style;
                }
                else
                {
                    //创建一个字体颜色
                    IFont font = workbook.CreateFont();
                    //红色
                    font.Color = HSSFColor.Green.Index;
                    //样式
                    ICellStyle style = workbook.CreateCellStyle();
                    //给样式设置字体
                    style.SetFont(font);
                    cell.CellStyle = style;
                }
            }

            #endregion 



        }



    }



    public class NpoiMemoryStream : MemoryStream
    {
        public NpoiMemoryStream()
        {
            AllowClose = true;
        }

        public bool AllowClose { get; set; }

        public override void Close()
        {
            if (AllowClose)
                base.Close();
        }
    }


}
