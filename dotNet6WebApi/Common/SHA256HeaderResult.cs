using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class SHA256HeaderResult
    {
        public string Timestamp { get; set; } = "";

        public string Signature { get; set; } = "";

        public string Nonce { get; set; } = "";

        public string ext_app_id { get; set; } = "";

        public bool IsNotEmptyAndValid()
        {
            if (string.IsNullOrEmpty(Timestamp)
                || string.IsNullOrEmpty(Signature) ||
                string.IsNullOrEmpty(Nonce) ||
                string.IsNullOrEmpty(ext_app_id)
                )
            {
                return false;
            }
            if (CommonHelper.isValidJavaTimeStamp(Timestamp) == false)
            {
                ///无效的时间戳格式
                return false;
            }
            return true;
        }
        public Dictionary<string, string> getHeadersDic()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Timestamp", Timestamp);
            dic.Add("Signature", Signature);
            dic.Add("Nonce", Nonce);
            dic.Add("ext-app-id", ext_app_id);
            return dic;
        }
    }
}
