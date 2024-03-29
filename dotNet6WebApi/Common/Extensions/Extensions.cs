﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extensions
{
    public static class CommonExtensions
    {


        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> keys = new HashSet<TKey>();
            foreach (TSource element in source)
                if (keys.Add(keySelector(element)))
                    yield return element;
        }

        public static string ToStringZeroIFNull(this Object obj)
        {
            try
            {
                if (obj == null) return "0";
                return Convert.ToString(obj);
            }
            catch (Exception ex)
            {
                return "0";
            }
        }
        public static DateTime? ToDateTimeNull(this string obj)
        {
            try
            {
                if (obj == null) return null;
                return Convert.ToDateTime(obj);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// "1,2,3" to List<int>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static List<int> ToListInt(this string obj)
        {
            try
            {
                List<int> lst = obj.Split(',').Select(p => int.Parse(p.Trim())).ToList();
                return lst;
            }
            catch (Exception)
            {
                return new List<int>();
            }
        }

        public static bool IsNullOrEmpty(this string obj)
        {
            return string.IsNullOrEmpty(obj);
        }
    }
}
