using EfCoreTest.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreTest.Common;
using Microsoft.Data.SqlClient;

namespace EfCoreTest.Test
{
    /// <summary>
    /// 参考网站 ： https://entityframework-extensions.net/
    /// https://www.nuget.org/packages/Z.EntityFramework.Extensions.EFCore/7.0.0-preview.6.22329.4-03
    /// </summary>
    public class TestDog
    {

        /// <summary>
        /// 批量插入数据
        /// </summary>
        public void BatchInsertToDog()
        {
            using (var ctx = new TestDbContext())
            {
                var clockInsert = new Stopwatch();//统计耗时

                List<Dog> lst = new List<Dog>();
                for (int i = 0; i < 100; i++)
                {
                    Dog d = new Dog()
                    {
                        Code = Guid.NewGuid().ToString("N").Substring(0, 6),
                        Name = "Sheldonor" + new Random().Next(1, 1000),
                    };
                    lst.Add(d);
                }
                clockInsert.Start();
                ctx.BulkInsert(lst);
                clockInsert.Stop();
                Console.WriteLine($"总共用时： {clockInsert.ElapsedMilliseconds} + \" ms\"");
            }
        }

        public void TestQuery()
        {
            using (var ctx = new TestDbContext())
            {
                string sql = "select * from [T_Dog] ";
                List<SqlParameter> para = new List<SqlParameter>();
                int page = 1;
                int limit = 20;
                List<Dog> lst = EfCoreHelper.ExecutePaginationSqlRtnList<Dog>(ctx, para, sql, " Name desc", limit, page);
                int total = EfCoreHelper.ExecuteCountSql(ctx, para, sql);
            }
        }
    }
}
