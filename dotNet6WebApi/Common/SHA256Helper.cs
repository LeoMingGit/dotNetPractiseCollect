using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class SHA256Helper
    {

        #region 单例
        private static object _objLock = new object();
        private static SHA256Helper _instance = null;

        public static SHA256Helper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_objLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SHA256Helper();
                        }
                    }
                }
                return _instance;
            }
        }

        #endregion

        /**
         * @param paramStr: 请求路径中的参数键值对,若没有，则传入空字符串
         * @param body: 请求参数的body体
         * @param timestamp 放入请求头中的时间戳
         * @param nonce 放入请求头中的随机串
         * @param nonce 私钥
         */
        // 对请求参数进行计算获取参数签名
        public String digest(String paramStr, String body, String timestamp, String nonce, String secret)
        {
            String str = "";
            paramStr = "(" + paramStr + ")(" + (body == null ? "" : body) + ")(" + timestamp + ")(" + nonce + ")(" + secret + ")";
            str = sha256(paramStr);
            return str;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="randomString"></param>
        /// <returns></returns>
        public static string sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();

        }


    }
}
