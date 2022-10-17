using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Common
{
    public static class CommonHelper
    {
        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }
        public static bool isValidJavaTimeStamp(string javaTimeStampStr)
        {
            try
            {
                double javaTimeStamp = double.Parse(javaTimeStampStr);
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dateTime = dateTime.AddMilliseconds(javaTimeStamp).ToLocalTime();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        public static DateTime JavaTimeStampToDateTime(double javaTimeStamp)
        {
            // Java timestamp is milliseconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddMilliseconds(javaTimeStamp).ToLocalTime();
            return dateTime;
        }
        /// <summary>
        /// Returns an individual HTTP Header value
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetHeader(this HttpContentHeaders headers, string key, string defaultValue)
        {
            IEnumerable<string> keys = null;
            if (!headers.TryGetValues(key, out keys))
                return defaultValue;

            return keys.First();
        }

        #region DataTabl to List<T>

        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                try
                {
                    foreach (PropertyInfo pro in temp.GetProperties())
                    {
                        if (pro.Name == column.ColumnName && dr[column.ColumnName] != DBNull.Value)
                            pro.SetValue(obj, dr[column.ColumnName] == DBNull.Value ? "" : dr[column.ColumnName], null);
                        else
                            continue;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            return obj;
        }
        #endregion
        public static TTarget CopyToProperties<TSource, TTarget>(TSource sourceItem)
        {
            if (null == sourceItem)
            {
                return default(TTarget);
            }

            var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace, };
            var serializedObject = Newtonsoft.Json.JsonConvert.SerializeObject(sourceItem, deserializeSettings);

            return Newtonsoft.Json.JsonConvert.DeserializeObject<TTarget>(serializedObject);
        }
    }
}
