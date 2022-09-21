using System.ComponentModel.DataAnnotations;

namespace Common.CommonDto
{
    /// <summary>
    /// 
    /// </summary>
    public class CurrentUserDto
    {
        [Required]
        public string CompanyCode { get; set; }
        [Required]

        public string companyToken { get; set; }
        [Required]
        public string UserTypeKey { get; set; }

    }

    /// <summary>
    /// 用户类型
    /// </summary>
    public static class UseryType
    {
        /// <summary>
        ///  经销商（如 蔡棣）
        /// </summary>
        public static string DisCode { get; set; } = "0200";

        /// <summary>
        /// 厂商
        /// </summary>
        public static string FacCod { get; set; } = "0100";

    }
}
