using Model.DTOs;
using Model.VOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.interfaces
{
    public interface IPagination
    {
        ApiResult testPagiantion(Dis_BasicGoodListDto dto );
    }
}
