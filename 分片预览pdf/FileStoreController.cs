using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace MapGIS.GM.API.GuangDongMapPlat.Controller
{

    /// <summary>
    /// 文件处理
    /// </summary>
    [RoutePrefix("api/fs")]
    public class FileStoreController : ApiController
    {

        /// <summary>
        /// 文件预览
        /// </summary>
        /// <param name="filepath">文件路径</param>
        /// <returns></returns>
        [Description("文件预览")]
        [HttpGet, Route("preview")]
        public  HttpResponseMessage Preview([Description("文件路径")] string filepath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filepath);
                long fileSize = fileInfo.Length;
                var response = Request.CreateResponse();
                StreamContent content = null;
                // 下载的字节范围
                long startByte = 0, endByte = fileSize - 1, totalByte = fileSize;
                if (Request.Headers.TryGetValues("range", out IEnumerable<string> rangeHeader))
                {
                    // 断点续传
                    var rangeString = rangeHeader.FirstOrDefault();
                    var match = Regex.Match(rangeString, @"bytes=(\d+)-(\d+)");
                    // 文件总大小
                    totalByte = fileSize;
                    startByte = long.Parse(match.Groups[1].Value);
                    endByte = long.Parse(match.Groups[2].Value);
                    // 返回http状态
                    response.StatusCode = HttpStatusCode.PartialContent;
                    long bytesToRead = endByte - startByte + 1;
                    var contentStream = ReadFileInRange(filepath, startByte, endByte);
                    content = new StreamContent(contentStream);
                    content.Headers.ContentLength = Convert.ToInt32(endByte - startByte + 1);

                }
                else
                {
                    // 文件总大小
                    totalByte = fileSize;
                    // 下载起始位置
                    startByte = 0;
                    // 下载结束位置
                    endByte = totalByte - 1;
                    response.StatusCode = HttpStatusCode.OK;
                    using (var ms = new MemoryStream())
                    {
                        content = new StreamContent(ms);
                    }


                }
                   
                  
                   
                //表明服务器支持分片加载
                response.Headers.AcceptRanges.Add("bytes");
                //Content - Range: bytes 0 - 65535 / 408244，表明此次返回的文件范围
                content.Headers.ContentRange = new ContentRangeHeaderValue(startByte, endByte, totalByte);
                ////告知浏览器这是一个字节流，浏览器处理字节流的默认方式就是下载
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response.Content = content;
                //需要设置此属性，否则浏览器默认不会读取到响应头中的Accept-Ranges属性，因此会认为服务器端不支持分片，所以会直接全文下载
                response.Headers.Add("Access-Control-Expose-Headers", "*");
                response.Headers.Add("Access-Control-Allow-Headers", "range,Accept-Ranges,Content-Range,Content-Type,X-CAF-Authorization-Token,sessionToken,X-TOKEN,Cache-Control,If-Modified-Since");
                return response;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "服务器内部异常");
            }
        }


        private static MemoryStream ReadFileInRange(string filePath, long startByte, long endByte)
        {
            // 验证参数
            if (startByte < 0 || endByte < startByte)
            {
                throw new ArgumentException("Invalid byte range");
            }

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    // 计算要读取的字节数
                    long bytesToRead = endByte - startByte + 1;

                    // 创建缓冲区
                    byte[] buffer = new byte[bytesToRead];

                    // 将文件流的位置设置为开始字节
                    fileStream.Seek(startByte, SeekOrigin.Begin);

                    // 读取字节到缓冲区
                    fileStream.Read(buffer, 0, (int)bytesToRead);

                    // 创建一个MemoryStream来存储读取的字节
                    MemoryStream resultStream = new MemoryStream(buffer);

                    return resultStream;
                }
            }
            catch (Exception ex)
            {
                // 在这里处理任何异常，比如文件未找到或读取错误
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }






    }

}
