using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Common
{
    public static class EfCoreHelper
    {
        public static DataTable ExcuteDataTable(DbContext ctx, string sql, List<SqlParameter> listParam = null)
        {
            SqlHelper sqlHelper = new SqlHelper(ctx);

            if (listParam == null)
            {
                return sqlHelper.ExecuteDataTable(sql);
            }
            else
            {
                SqlParameter[] arr = new SqlParameter[listParam.Count];
                for (int i = 0; i < listParam.Count; i++)
                {
                    arr[i] = listParam[i];
                }
                return sqlHelper.ExecuteDataTable(sql, CommandType.Text, arr);
            }

        }
        public static List<T> ExcuteDataTable<T>(DbContext ctx, string sql, List<SqlParameter> listParam = null)
        {
            SqlHelper sqlHelper = new SqlHelper(ctx);

            if (listParam == null)
            {
                DataTable dt = sqlHelper.ExecuteDataTable(sql);
                return CommonHelper.ConvertDataTable<T>(dt);

            }
            else
            {
                SqlParameter[] arr = new SqlParameter[listParam.Count];
                for (int i = 0; i < listParam.Count; i++)
                {
                    arr[i] = listParam[i];
                }
                DataTable dt = sqlHelper.ExecuteDataTable(sql, CommandType.Text, arr);
                return CommonHelper.ConvertDataTable<T>(dt);
            }

        }


        /// <summary>
        /// /
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ctx"></param>
        /// <param name="listParam"></param>
        /// <param name="sql"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static List<T> ExecutePaginationSqlRtnList<T>(DbContext ctx, string sql, List<SqlParameter> listParam, string sort, int limit, int page)
        {
            DataTable dt = ExecutePaginationSqlRtnDataTable(ctx, sql, listParam, sort, limit, page);
            return CommonHelper.ConvertDataTable<T>(dt);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="listParam"></param>
        /// <param name="sql"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static DataTable ExecutePaginationSqlRtnDataTable(DbContext ctx, string sql, List<SqlParameter> listParam, string sort, int limit, int page)
        {
            // sort,limit, page 不必考虑防止注入
            string pagesql = string.Format("SELECT TOP {0} * FROM ( SELECT ROW_NUMBER() OVER (ORDER BY {1} ) AS RowNumber,* FROM ( {2} ) temp ) as A  WHERE RowNumber > {0}*({3}-1) ", limit, sort, sql, page);
            SqlHelper sqlHelper = new SqlHelper(ctx);
            if (listParam.Count == 0)
            {
                return sqlHelper.ExecuteDataTable(pagesql);
            }
            else
            {
                SqlParameter[] arr = new SqlParameter[listParam.Count];
                for (int i = 0; i < listParam.Count; i++)
                {
                    arr[i] = listParam[i];
                }
                return sqlHelper.ExecuteDataTable(pagesql, CommandType.Text, arr);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="listParam"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteCountSql(DbContext ctx, string sql, List<SqlParameter> listParam)
        {
            string sqlcount = string.Format(" select COUNT(1) from ({0})temp ", sql);
            SqlHelper sqlHelper = new SqlHelper(ctx);

            if (listParam.Count == 0)
            {
                return (int)sqlHelper.ExecuteScalar(sqlcount);
            }
            else
            {
                SqlParameter[] arr = new SqlParameter[listParam.Count];
                for (int i = 0; i < listParam.Count; i++)
                {
                    arr[i] = listParam[i];
                }
                return (int)sqlHelper.ExecuteScalar(sqlcount, CommandType.Text, arr);
            }

        }

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ctx"></param>
        /// <param name="tableName"></param>
        /// <param name="list"></param>
        public static void BulkInsert<T>(DbContext ctx, string tableName, IList<T> list)
        {
            SqlHelper sqlHelper = new SqlHelper(ctx);
            sqlHelper.BulkInsert(tableName, list);
        }



    }

}
