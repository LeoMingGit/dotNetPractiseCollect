using Model.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.interfaces
{
    public interface IUserManagerRepository
    {
        Base_Customer_SysInfo QueryUserInfoById(string id);
    }
}
