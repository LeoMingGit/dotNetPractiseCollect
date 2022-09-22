using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace Common.Extensions
{
    public static class Extensions
    {
        public static string GetErrorMessages(this ModelStateDictionary dictionary)
        {
            var dic = dictionary.SelectMany(m => m.Value.Errors).Select(x => x.ErrorMessage).ToList();
            string errorStr = string.Join(",", dic);
            return errorStr;
        }

        public static string GetErrorMsg(this Exception ex, params object[] args)
        {

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("\n");
            stringBuilder.AppendLine($"========================================开始:{DateTime.Now.ToString("yyyy年MM月dd HH时mm分ss秒")}==============================================");
            stringBuilder.AppendLine("\n");
            stringBuilder.AppendLine("以下为参数:");
            foreach (var item in args)
            {
                stringBuilder.AppendLine(JsonHelper.ToJson(item));
                stringBuilder.AppendLine("\n");
            }
            stringBuilder.AppendFormat("ErrorMsg:{0}", ex.Message);
            stringBuilder.AppendLine("\n");
            stringBuilder.AppendFormat("StackTrace:{0}", ex.StackTrace);
            stringBuilder.AppendLine("\n");
            stringBuilder.AppendLine($"========================================结束:{DateTime.Now.ToString("yyyy年MM月dd HH时mm分ss秒")}==============================================");
            stringBuilder.AppendLine("\n");
            return stringBuilder.ToString();
        }
        public static IEnumerable<TResult> LeftJoin<TOuter, TInner, TKey, TResult>(
    this IEnumerable<TOuter> outer,
    IEnumerable<TInner> inner,
    Func<TOuter, TKey> outerKeySelector,
    Func<TInner, TKey> innerKeySelector,
    Func<TOuter, TInner, TResult> resultSelector)
        {
            return outer
                .GroupJoin(inner,
                    outerKeySelector,
                    innerKeySelector,
                    (outerObj, inners) => new { outerObj, inners = inners.DefaultIfEmpty() })
                .SelectMany(a => a.inners.Select(innerObj => resultSelector(a.outerObj, innerObj)));
        }




        public static bool InRange(this DateTime dateToCheck, DateTime startDate, DateTime endDate)
        {
            return dateToCheck >= startDate && dateToCheck < endDate;
        }




    }
}
