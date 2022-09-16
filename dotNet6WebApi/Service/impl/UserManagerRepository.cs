using Model.Base;
using Model.Table;
using Service.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Microsoft.EntityFrameworkCore;

namespace Service.impl
{
    public class UserManagerRepository : IUserManagerRepository
    {
        private readonly IDbContextFactory<BaseDbContext> _contextFactory;

        public UserManagerRepository(IDbContextFactory<BaseDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public Base_Customer_SysInfo QueryUserInfoById(string id)
        {
            ////string sql = $"select  * from  Base_Customer_SysInfo where AppKey='{id}'";
            ////return EfCoreHelper.ExcuteDataTable<Base_Customer_SysInfo>(_context, sql).FirstOrDefault();
            //var res = _context.Base_Customer_SysInfos.Where(p => p.AppKey.Equals(id)).FirstOrDefault();
            //return res;
            using (var context = _contextFactory.CreateDbContext())
            {
                // ...
                var res = context.Base_Customer_SysInfos.Where(p => p.AppKey.Equals(id)).FirstOrDefault();
                return res;
            }
        }
    }
}
