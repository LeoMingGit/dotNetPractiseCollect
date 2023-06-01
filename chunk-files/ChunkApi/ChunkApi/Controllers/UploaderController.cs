using ChunkApi.Db;
using ChunkApi.Dto;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ChunkApi.Controllers
{
    [RoutePrefix("boot")]
    public class UploaderController : ApiController
    {

        /// <summary>
        /// 上传分片文件
        /// </summary>
        /// <returns></returns>
        [HttpPost, Route("uploader/chunk")]
        public async Task<HttpResponseMessage> UploadChunk()
        {
            try
            {
                var provider = new MultipartFormDataStreamProvider(Path.GetTempPath());
                await Request.Content.ReadAsMultipartAsync(provider);
                var chunk = new ChunkEntity()
                {
                    ChunkNumber = int.Parse(provider.FormData.GetValues("chunkNumber").FirstOrDefault()),
                    ChunkSize = long.Parse(provider.FormData.GetValues("chunkSize").FirstOrDefault()),
                    CurrentChunkSize = long.Parse(provider.FormData.GetValues("currentChunkSize").FirstOrDefault()),
                    TotalSize = long.Parse(provider.FormData.GetValues("totalSize").FirstOrDefault()),
                    Identifier = provider.FormData.GetValues("identifier").FirstOrDefault(),
                    Filename = provider.FormData.GetValues("filename").FirstOrDefault(),
                    RelativePath = provider.FormData.GetValues("relativePath").FirstOrDefault(),
                    TotalChunks = int.Parse(provider.FormData.GetValues("totalChunks").FirstOrDefault()),
                };
                var file = provider.FileData.FirstOrDefault();
                Console.WriteLine($"file originName: {file.LocalFileName}, chunkNumber: { chunk.ChunkNumber}");
                string root = @"E:\代码练习\dotNetPractiseCollect\chunk-files\files-storege";// your local path
                if (!Directory.Exists(root)) Directory.CreateDirectory(root);
                var filePath = file.LocalFileName;
                var rawFileBytes = File.ReadAllBytes(filePath);
                // 将文件移动到指定文件夹
                var targetFilePath = GenerateUploadPath(root, chunk);
                File.WriteAllBytes(targetFilePath, rawFileBytes);
                //保存分片记录
                using (var db = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = "Server=localhost;Port=3306;Database=test;Uid=root;Pwd=123456;",
                    DbType = DbType.MySql, // 数据库类型
                    IsAutoCloseConnection = true, // 自动释放连接，避免内存泄漏
                }))
                {
                    Guid guid = Guid.NewGuid();
                    chunk.Id = BitConverter.ToInt64(guid.ToByteArray(), 0);
                    db.Insertable<ChunkEntity>(chunk).ExecuteCommand();
                }
                return Request.CreateResponse(HttpStatusCode.OK, "文件上传成功");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "服务器内部异常");
            }
        }

        /// <summary>
        /// 检查分片文件
        /// </summary>
        /// <param name="chunk"></param>
        /// <returns></returns>
        [HttpGet, Route("uploader/chunk")]
        public HttpResponseMessage CheckChunk([FromUri] ChunkEntity chunk)
        {
            try
            {
                if (checkChunk(chunk.Identifier, chunk.ChunkNumber) == false)
                {
                    return Request.CreateResponse(HttpStatusCode.NotModified);
                }
                return Request.CreateResponse(HttpStatusCode.OK, chunk);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "服务器内部异常");
            }

        }

        /// <summary>
        /// 合并分片文件
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("uploader/mergeFile")]
        public async Task<HttpResponseMessage> MergeFileAsync([FromBody] MergeFileDto fileInfo)
        {
            try
            {
                string filename = fileInfo.Filename;
                string uploadFolder = @"E:\代码练习\dotNetPractiseCollect\chunk-files\files-storege";// your local path
                var file = uploadFolder + "/" + fileInfo.Identifier + "/" + filename;
                var folder = uploadFolder + "/" + fileInfo.Identifier;
                var isMergeOk = await MergeChunkFilesAsync(file, folder, filename);
                using (var db = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = "Server=localhost;Port=3306;Database=test;Uid=root;Pwd=123456;",
                    DbType = DbType.MySql, // 数据库类型
                    IsAutoCloseConnection = true, // 自动释放连接，避免内存泄漏
                }))
                {
                    db.Deleteable<ChunkEntity>().Where(x => x.Identifier == fileInfo.Identifier).ExecuteCommand();

                }
                if (isMergeOk == false)
                {
                    Console.WriteLine("合成的文件：" + filename);
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "合并失败");
                }

                return Request.CreateResponse(HttpStatusCode.BadRequest, "合并失败");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "服务器内部异常");
            }

        }
        /// <summary>
        /// 查询分片是否存在
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="chunkNumber"></param>
        /// <returns>true:分片存在，false:分片不存在</returns>
        private bool checkChunk(string identifier, int chunkNumber)
        {
            try
            {
                using (var db = new SqlSugarClient(new ConnectionConfig()
                {
                    ConnectionString = "Server=localhost;Port=3306;Database=test;Uid=root;Pwd=123456;",
                    DbType = DbType.MySql, // 数据库类型
                    IsAutoCloseConnection = true, // 自动释放连接，避免内存泄漏
                }))
                {
                    var flag = db.Queryable<ChunkEntity>().Where(x => x.Identifier == identifier && x.ChunkNumber == chunkNumber).Count() > 0;
                    return flag;
                }

             
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        /// <summary>
        /// 生成上传文件路径
        /// </summary>
        /// <param name="uploadFolder"></param>
        /// <param name="chunk"></param>
        /// <returns></returns>
        private string GenerateUploadPath(string uploadFolder, ChunkEntity chunk)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(uploadFolder).Append("/").Append(chunk.Identifier);
            //判断uploadFolder/identifier 路径是否存在，不存在则创建
            if (!Directory.Exists(sb.ToString()))
            {
                Console.WriteLine("文件路径不存在: {0}", sb.ToString());
                try
                {
                    Directory.CreateDirectory(sb.ToString());
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                }
            }
            var path = sb.Append("/").Append(chunk.Filename).Append("-").Append(chunk.ChunkNumber).ToString();
            return path;
        }


        /// <summary>
        /// 分片文件合并
        /// </summary>
        /// <param name="targetFile">目标文件名</param>
        /// <param name="folder">源文件所在目录</param>
        /// <param name="filename">需要排除的文件名</param>
        /// <returns>返回是否成功合并</returns>
        private async Task<bool> MergeChunkFilesAsync(string targetFile, string folder, string filename)
        {

            DirectoryInfo directory = new DirectoryInfo(folder);
            var files = directory.GetFiles();
            // 根据文件名中的“-”进行排序，按照降序排列
            var paths = new List<string>();
            foreach (var item in files)
            {
                var ext = Path.GetExtension(item.FullName);
                if (ext.Contains("-"))
                {
                    paths.Add(item.FullName);
                }
            }
            paths = paths.OrderBy(path => int.Parse(path.Split('-').Last())).ToList();
            if (System.IO.File.Exists(targetFile))
            {
                System.IO.File.Delete(targetFile);
            }
            using (var fileStream = new FileStream(targetFile, FileMode.Create))
            {
                // 依次将非排除文件的内容追加到目标文件中，并删除源文件
                foreach (var path in paths)
                {

                    var saveFile = files.Where(x => x.FullName == path).FirstOrDefault();
                    using (FileStream fileChunk = new FileStream(saveFile.FullName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        await fileChunk.CopyToAsync(fileStream);
                    }
                    //合并后删除该块
                    File.Delete(saveFile.FullName);
                }
            }
            return true;
        }

    }
}
