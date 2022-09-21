using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Common
{
    /// <summary>
    /// 返回参数
    /// </summary>
    public class ResultBase
    {
        /// <summary>
        /// 操作执行成功
        /// </summary>
        public bool isok { get; set; }
        /// <summary>
        ///返回状态码
        ///10000	操作成功
        ///30024	操作失败
        ///30010    参数为null
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 错误消息
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public object data { get; set; }

        /// <summary>
        /// constructor method
        /// </summary>
        /// <param name="_code"></param>
        /// <param name="_message"></param>
        /// <param name="_data"></param>
        public ResultBase(int _code,string _message,object _data)
        {
            this.code = _code;
            this.message = _message;
            this.data = _data;
            this.isok = (this.code == (int)CodeRemark.success);
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(data);
        }
        /// <summary>
        /// 转换对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T To<T>()
        {
            if (data != null)
            {
                 return (T) data;
            }
            return default(T);
        }
    }


    public enum CodeRemark
    {
        success =10000,
        fail= 30024,
        argumentnull = 30010,
    }
}
