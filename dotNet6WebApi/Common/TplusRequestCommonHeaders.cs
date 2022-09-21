using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public  class TplusRequestCommonHeaders
    {
        private Dictionary<string, string> dicHeaer;
        public Dictionary<string, string> GetRequestHeaders()
        {
            return dicHeaer;
        }
        public TplusRequestCommonHeaders(TplusHeadersObject obj)
        {
            dicHeaer = new Dictionary<string, string>();
            dicHeaer.Add("openToken", obj.openToken);
            dicHeaer.Add("appKey", obj.appKey);
            dicHeaer.Add("appSecret", obj.appSecret);
        }
    }

    public class TplusHeadersObject
    {
        public string openToken { get; set; }

        public string appKey { get; set; }

        public  string appSecret { get; set; }

    }

}
