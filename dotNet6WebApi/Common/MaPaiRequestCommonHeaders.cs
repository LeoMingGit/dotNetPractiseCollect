using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
     public  class MaPaiRequestCommonHeaders
    {
        /// <summary>
        /// 当前时间戳
        /// </summary>
        public string Timestamp { get; set; }
        /// <summary>
        /// 签名算法字符串，算法规则：入参+时间戳+随机字符串+秘钥，经过SHA-256算法加密后产生
        /// </summary>
        public string Signature { get; set; }
        /// <summary>
        /// 随机字符串
        /// </summary>
        public string Nonce { get; set; }
        /// <summary>
        /// 由盟帆提供
        /// </summary>
        public  string ext_app_id { get; set; }

        private  static string static_ext_app_id= CommonHelper.GetServerConfigStr("ext_app_id");
        /// <summary>
        /// 私钥
        /// </summary>
        private static string secret = CommonHelper.GetServerConfigStr("secret");

       private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="body">请求参数的body体</param>
        public MaPaiRequestCommonHeaders(string body)
        {
            String nonce = System.Guid.NewGuid().ToString();//放入请求头中的随机串
            long timestamp = CurrentTimeMillis();//放入请求头中的时间戳
            String digest = SHA256Helper.Instance.digest("", body, timestamp.ToString(), nonce, secret);
            this.Timestamp = timestamp.ToString();
            this.Nonce = nonce;
            this.Signature = digest;
            this.ext_app_id = static_ext_app_id;
        }

        public MaPaiRequestCommonHeaders(string body,string _secret,string _ext_app_id)
        {
            String nonce = System.Guid.NewGuid().ToString();//放入请求头中的随机串
            long timestamp = CurrentTimeMillis();//放入请求头中的时间戳
            String digest = SHA256Helper.Instance.digest("", body, timestamp.ToString(), nonce, _secret);
            this.Timestamp = timestamp.ToString();
            this.Nonce = nonce;
            this.Signature = digest;
            this.ext_app_id = _ext_app_id;
        }

    }
}
