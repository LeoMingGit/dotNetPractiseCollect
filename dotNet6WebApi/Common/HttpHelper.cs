using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
namespace Common
{
    public static class HttpHelper
    {

        /// <summary>
        /// http/https请求响应
        /// </summary>
        /// <param name="getOrPost"></param>
        /// <param name="url">地址（要带上http或https）</param>
        /// <param name="headers">请求头</param>
        /// <param name="parameters">提交数据</param>
        /// <param name="dataEncoding">编码类型 utf-8</param>
        /// <param name="contentType">application/x-www-form-urlencoded</param>
        /// <returns></returns>
        public static HttpWebResponse HttpRequest(
            string getOrPost,
            string url,
            Dictionary<string, string> headers,
            Dictionary<string, string> parameters,
            Encoding dataEncoding,
            string contentType
            )
        {
            var request = CreateRequest(getOrPost, url, headers, parameters, dataEncoding, contentType);

            //如果需要POST数据  
            if (getOrPost == "POST" && !(parameters == null || parameters.Count == 0))
            {
                var data = FormatPostParameters(parameters, dataEncoding, contentType);

                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                    stream.Close();
                }
            }

            WebResponse Res = null;
            try
            {
                Res = request.GetResponse();
            }
            catch (WebException ex)
            {
                Res = (HttpWebResponse)ex.Response;
            }
            catch (Exception e)
            {
                throw e;
            }

            if (null == Res)
            {
                return request.GetResponse() as HttpWebResponse;
            }

            return (HttpWebResponse)Res;
        }


        /// <summary>
        /// 创建HTTP请求对象
        /// </summary>
        /// <param name="getOrPost"></param>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        /// <param name="parameters"></param>
        /// <param name="paraEncoding"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        private static HttpWebRequest CreateRequest(
            string getOrPost
            , string url
            , Dictionary<string, string> headers
            , Dictionary<string, string> parameters
            , Encoding paraEncoding
            , string contentType
            )
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("url");
            }

            if (parameters != null && parameters.Count > 0 && paraEncoding == null)
            {
                throw new ArgumentNullException("requestEncoding");
            }

            HttpWebRequest request = null;
            //判断是否是https  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback =
                    new RemoteCertificateValidationCallback(CheckValidationResult);
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }

            if (getOrPost == "GET")
            {
                request.Method = "GET";

                if (parameters != null && parameters.Count > 0)
                {
                    url = FormatGetParametersToUrl(url, parameters, paraEncoding);
                }
            }
            else
            {
                request.Method = "POST";
            }

            if (contentType == null)
            {
                request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
            }
            else
            {
                request.ContentType = contentType;
            }

            //POST的数据大于1024字节的时候，如果不设置会分两步
            request.ServicePoint.Expect100Continue = false;
            request.ServicePoint.ConnectionLimit = int.MaxValue;

            if (headers != null)
            {
                FormatRequestHeaders(headers, request);
            }

            return request;
        }


        /// <summary>
        /// 格式化请求头信息
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="request"></param>
        private static void FormatRequestHeaders(Dictionary<string, string> headers, HttpWebRequest request)
        {
            foreach (var hd in headers)
            {
                //因为HttpWebRequest中很多标准标头都被封装成只能通过属性设置，添加的话会抛出异常
                switch (hd.Key.ToLower())
                {
                    case "connection":
                        request.KeepAlive = false;
                        break;
                    case "content-type":
                        request.ContentType = hd.Value;
                        break;
                    case "transfer-enconding":
                        request.TransferEncoding = hd.Value;
                        break;
                    default:
                        request.Headers.Add(hd.Key, hd.Value);
                        break;
                }
            }
        }


        /// <summary>
        /// 格式化Get请求参数
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="parameters">参数</param>
        /// <param name="paraEncoding">编码格式</param>
        /// <returns></returns>

        private static string FormatGetParametersToUrl(string url, Dictionary<string, string> parameters, Encoding paraEncoding)
        {
            if (url.IndexOf("?") < 0)
                url += "?";
            int i = 0;
            string sendContext = "";
            foreach (var parameter in parameters)
            {
                if (i > 0)
                {
                    sendContext += "&";
                }

                sendContext += HttpUtility.UrlEncode(parameter.Key, paraEncoding)
                       + "=" + HttpUtility.UrlEncode(parameter.Value, paraEncoding);
                ++i;
            }

            url += sendContext;
            return url;
        }


        /// <summary>
        /// 格式化Post请求参数
        /// </summary>
        /// <param name="parameters">编码格式</param>
        /// <param name="dataEncoding">编码格式</param>
        /// <param name="contentType">类型</param>
        /// <returns></returns>
        private static byte[] FormatPostParameters(Dictionary<string, string> parameters, Encoding dataEncoding, string contentType)
        {
            string sendContext = "";
            int i = 0;
            if (!string.IsNullOrEmpty(contentType) && contentType.ToLower().Trim() == "application/json")
            {
                sendContext = "{";
            }

            foreach (var para in parameters)
            {
                if (!string.IsNullOrEmpty(contentType) && contentType.ToLower().Trim() == "application/json")
                {
                    if (i > 0)
                    {
                        if (para.Value.StartsWith("{"))
                        {
                            sendContext += string.Format(@",""{0}"":{1}", para.Key, para.Value);
                        }
                        else
                        {
                            sendContext += string.Format(@",""{0}"":""{1}""", para.Key, para.Value);
                        }

                    }
                    else
                    {
                        if (para.Value.StartsWith("{"))
                        {
                            sendContext += string.Format(@"""{0}"":{1}", para.Key, para.Value);
                        }
                        else
                        {
                            sendContext += string.Format(@"""{0}"":""{1}""", para.Key, para.Value);
                        }

                    }
                }
                else
                {
                    if (i > 0)
                    {
                        sendContext += string.Format("&{0}={1}", para.Key, HttpUtility.UrlEncode(para.Value, dataEncoding));
                    }
                    else
                    {
                        sendContext = string.Format("{0}={1}", para.Key, HttpUtility.UrlEncode(para.Value, dataEncoding));
                    }
                }

                i++;
            }

            if (!string.IsNullOrEmpty(contentType) && contentType.ToLower().Trim() == "application/json")
            {
                sendContext += "}";
            }

            byte[] data = dataEncoding.GetBytes(sendContext);
            return data;
        }


        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain,
            SslPolicyErrors errors)
        {
            return true; //总是接受  
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="headers"></param>
        /// <param name="jsondata"></param>
        /// <returns></returns>
        public static string PostJsonRequest(string Url, Dictionary<string, string> headers, string jsondata)
        {
            string RR = "";
            //
            WebRequest request = WebRequest.Create(Url);              //创建一个请求，把接口地址填进来
            request.Method = "post";       //设置请求的方法属性
            request.ContentType = "application/json";           //设置请求标头
            request.Timeout = 30 * 1000;
            if (headers != null)
            {
                FormatRequestHeaders(headers, request as HttpWebRequest);
            }
            //创建后数据并将其转换为字节数组
            byte[] byteArray = Encoding.UTF8.GetBytes(jsondata);
            request.ContentLength = byteArray.Length;   //请求长度
            //
            Stream dataStream = request.GetRequestStream();  //得到请求流
            dataStream.Write(byteArray, 0, byteArray.Length); //将数据写入请求流
            dataStream.Close();         //关闭流对象
                                        //
                                        //发送请求并获取相应回应数据       
                                        //Console.WriteLine(((HttpWebResponse)response).StatusDescription); //显示状态
            try
            {
                WebResponse response = request.GetResponse();  //得到的响应

                dataStream = response.GetResponseStream();   //获取服务器返回的流
                                                             //StreamReader php = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
                StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);//打开流   //.GetEncoding("UTF-8")
                                                                                  //
                RR = reader.ReadToEnd();//读取内容
                                        //
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (WebException ex)
            {
                WebResponse response = (HttpWebResponse)ex.Response;
                dataStream = response.GetResponseStream();   //获取服务器返回的流
                                                             //StreamReader php = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
                StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);//打开流   //.GetEncoding("UTF-8")
                                                                                  //
                RR = reader.ReadToEnd();//读取内容
                                        //
                reader.Close();
                dataStream.Close();
                response.Close();
            }

            //
            return RR;
        }


        //创建GET的HTTP请求
        public static string CreateGetHttpResponse(string url, Dictionary<string, string> headers, Dictionary<string, string> param)
        {
            url = FormatGetParametersToUrl(url, param, Encoding.UTF8);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "Mozilla / 5.0(Windows NT 10.0; Win64; x64; rv: 48.0) Gecko / 20100101 Firefox / 48.0"; //火狐用户代理
            request.Method = "GET";
            request.Timeout = 30 * 1000;
            if (headers != null)
            {
                FormatRequestHeaders(headers, request as HttpWebRequest);
            }
            WebResponse response = request.GetResponse();  //得到的响应
            Stream dataStream = response.GetResponseStream();   //获取服务器返回的流
            StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);//打开流   //.GetEncoding("UTF-8")
            string RR = reader.ReadToEnd();//读取内容
            reader.Close();
            dataStream.Close();
            response.Close();
            return RR;
        }


    }

}
