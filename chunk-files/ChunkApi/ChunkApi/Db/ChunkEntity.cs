using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChunkApi.Db
{
  
    /// <summary>
    /// 上传文件切片记录片
    /// </summary>
    [SugarTable("chunk")]
    public class ChunkEntity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public long Id { get; set; }

        /// <summary>
        /// 分块号
        /// </summary>
        [SugarColumn(ColumnName = "chunk_number")]
        public int ChunkNumber { get; set; }

        /// <summary>
        /// 分块大小
        /// </summary>
        [SugarColumn(ColumnName = "chunk_size")]
        public long ChunkSize { get; set; }

        /// <summary>
        /// 当前分块大小
        /// </summary>
        [SugarColumn(ColumnName = "current_chunk_size")]
        public long CurrentChunkSize { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [SugarColumn]
        public string Filename { get; set; }

        /// <summary>
        /// 标识符
        /// </summary>
        [SugarColumn]
        public string Identifier { get; set; }

        /// <summary>
        /// 相对路径
        /// </summary>
        [SugarColumn(ColumnName = "relative_path")]
        public string RelativePath { get; set; }

        /// <summary>
        /// 相对路径
        /// </summary>
        [SugarColumn(ColumnName = "total_chunks")]
        public int TotalChunks { get; set; }

        /// <summary>
        /// 总大小
        /// </summary>
        [SugarColumn(ColumnName = "total_size")]
        public long TotalSize { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [SugarColumn]
        public string Type { get; set; }
    }
}