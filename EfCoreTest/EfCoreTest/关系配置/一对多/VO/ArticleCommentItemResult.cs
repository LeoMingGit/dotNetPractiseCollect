using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTest.关系配置.一对多.VO
{
    public class ArticleCommentItemResult
    {
        public string ArticleTitle { get; set; }

        public List<string> CmtMsgLst { get; set; }
    }
}
