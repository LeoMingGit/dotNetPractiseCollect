using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChunkApi.Dto
{

    /// <summary>
    /// 文件数据传输对象
    /// </summary>
    public class MergeFileDto
    {
        /// <summary>
        /// 文件名
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// 唯一标识符
        /// </summary>
        public string Identifier { get; set; }

        /// <summary>
        /// 文件总大小
        /// </summary>
        public int TotalSize { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 文件ID
        /// </summary>
        public string Id { get; set; }

 
    }
}