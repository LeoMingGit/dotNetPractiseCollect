using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace Common
{
    /// <summary>
    /// ADO.NET-------底层的数据操作
    /// </summary>
    public class SqlHelper
    {

        public SqlHelper(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private DbContext dbContext;

        /// <summary>  
        /// 批量插入  
        /// </summary>  
        /// <typeparam name="T">泛型集合的类型</typeparam>  
        /// <param name="dbs">连接对象</param>  
        /// <param name="tableName">将泛型集合插入到本地数据库表的表名</param>  
        /// <param name="list">要插入大泛型集合</param>  
        public void BulkInsert<T>(string tableName, IList<T> list)
        {
            SqlConnection conn = (SqlConnection)dbContext.Database.GetDbConnection();
            if (conn.State != ConnectionState.Open)
            {
                conn.Open(); //打开Connection连接  
            }
            using (var bulkCopy = new SqlBulkCopy(conn))
            {
                bulkCopy.BatchSize = list.Count;
                bulkCopy.DestinationTableName = tableName;

                var table = new DataTable();
                var props = TypeDescriptor.GetProperties(typeof(T))

                    .Cast<PropertyDescriptor>()
                    .Where(propertyInfo => propertyInfo.PropertyType.Namespace.Equals("System"))
                    .ToArray();

                foreach (var propertyInfo in props)
                {
                    bulkCopy.ColumnMappings.Add(propertyInfo.Name, propertyInfo.Name);
                    table.Columns.Add(propertyInfo.Name, Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType);
                }

                var values = new object[props.Length];
                foreach (var item in list)
                {
                    for (var i = 0; i < values.Length; i++)
                    {
                        values[i] = props[i].GetValue(item);
                    }
                    table.Rows.Add(values);
                }
                bulkCopy.WriteToServer(table);
            }
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close(); //关闭Connection连接  
            }
        }

        #region 执行一个查询，返回查询的结果集+ExecuteDataTable(string sql, CommandType commandtype, SqlParameter[] parameters)
        public DataTable ExecuteDataTable(string sql)
        {
            return ExecuteDataTable(sql, CommandType.Text, null);
        }
        public DataTable ExecuteDataTable(string sql, CommandType commandType)
        {
            return ExecuteDataTable(sql, commandType, null);
        }

        /// <summary>
        /// 执行一个查询，返回查询的结果集。
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandtype"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string sql, CommandType commandtype, SqlParameter[] parameters)
        {
            DataTable data = new DataTable();  //实例化datatable,用于装载查询的结果集
            using (SqlConnection conn = (SqlConnection)dbContext.Database.GetDbConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = commandtype;
                    if (parameters != null)
                    {
                        foreach (SqlParameter parameter in parameters)
                        {
                            cmd.Parameters.Add(parameter);   //将参数添加到sql语句中。
                        }
                    }
                    //申明sqldataadapter，通过cmd来实例化它，这个是数据设备器，可以直接往datatable,dataset中写入。
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);   //利用Fill来填充。
                }
            }
            return data;
        }
        #endregion

        #region 返回一个SqlDataReader对象。

        public SqlDataReader ExecuteReader(string sql)
        {
            return ExecuteReader(sql, CommandType.Text, null);
        }
        public SqlDataReader ExecuteReader(string sql, CommandType commandType)
        {
            return ExecuteReader(sql, commandType, null);
        }

        /// <summary>
        /// 返回一个SqlDataReader，从 SQL Server 数据库读取行的只进流的方式
        /// </summary>
        /// <returns></returns>
        public SqlDataReader ExecuteReader(string sql, CommandType commandType, SqlParameter[] parameters)
        {
            SqlConnection conn = (SqlConnection)dbContext.Database.GetDbConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            conn.Open();
            //CommandBehavior.CloseConnection+关闭reader对象关闭与其连接的Connection对象。
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        #endregion

        #region 执行一个查询，返回结果集的首行首列。忽略其他行，其他列
        /// <summary>
        /// 只执行sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql)
        {
            return ExecuteScalar(sql, CommandType.Text, null);
        }
        /// <summary>
        /// 可以执行存储过程
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql, CommandType commandType)
        {
            return ExecuteScalar(sql, commandType, null);
        }
        /// <summary>
        /// 执行一个查询，返回结果集的首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sql, CommandType commandType, SqlParameter[] parameters)
        {
            SqlConnection conn = (SqlConnection)dbContext.Database.GetDbConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = commandType;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(parameter);
                }
            }
            conn.Open();
            //cmd.ExecuteScalar()+执行查询，并返回查询所返回的结果集中第一行的第一列。 忽略其他列或行。
            object result = cmd.ExecuteScalar();
            conn.Close();
            return result;
        }

        #endregion

        #region 进行CRUD操作

        public int ExecuteNonQuery(string sql)
        {
            return ExecuteNonQuery(sql, CommandType.Text, null);
        }
        public int ExecuteNonQuery(string sql, CommandType commandType)
        {
            return ExecuteNonQuery(sql, commandType, null);
        }
        /// <summary>
        /// 对数据库进行增删改的操作
        /// </summary>
        /// <param name="sql">执行的Sql语句</param>
        /// <param name="commandType">要执行的查询语句类型，如存储过程或者sql文本命令</param>
        /// <param name="parameters">Transact-SQL语句或者存储过程的参数数组</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql, CommandType commandType, SqlParameter[] parameters)
        {
            SqlConnection conn = (SqlConnection)dbContext.Database.GetDbConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = commandType;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    cmd.Parameters.Add(cmd);
                }
            }
            conn.Open();
            int count = cmd.ExecuteNonQuery();
            conn.Close();
            return count;
        }

        #endregion

        #region  返回当前连接的数据库中所有用户创建的数据库
        /// <summary>
        /// 返回当前连接的数据库中所有用户创建的数据库
        /// </summary>        
        /// <param name="tableName">表名</param>
        /// <returns></returns>
        public DataTable GetTable(string tableName)
        {
            DataTable table = new DataTable();
            using (SqlConnection conn = (SqlConnection)dbContext.Database.GetDbConnection())
            {
                conn.Open();
                table = conn.GetSchema(tableName);
            }
            return table;
        }
        #endregion
    }
}
