using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Table
{
    [Table("Base_Customer_SysInfo")]

    public class Base_Customer_SysInfo
    {

        [Key]
        public string cusCode { get; set; }
        public string? cusName { get; set; }
        public string? flag { get; set; }
        public string sysName_cn { get; set; }
        public string? sysName_en { get; set; }
        public string? sysUrl { get; set; }
        public string? sysUserCode { get; set; }
        public string? sysPWD { get; set; }
        public string? sysVersion { get; set; }
        public string? sysToken { get; set; }
        public DateTime? sysToken_updateTime { get; set; }
        public decimal? sysToken_validHours { get; set; }
        public string? AppKey { get; set; }
        public string? AppSecret { get; set; }
        public string? refresh_token { get; set; }
        public string? grandCode { get; set; }
        public decimal? syncTimeSpan { get; set; }


        public DateTime? updateTime { get; set; }

    }

}
