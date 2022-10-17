using Common;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model.Base;
using Model.DTOs;
using Model.VOs;
using Service.interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.impl
{
    public class PaginationImpl : IPagination
    {
        private readonly IDbContextFactory<BaseDbContext> _contextFactory;

        public PaginationImpl(IDbContextFactory<BaseDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public ApiResult testPagiantion(Dis_BasicGoodListDto dto)
        {
            using (var context = _contextFactory.CreateDbContext())
            {

                string mainsql = @" SELECT  sys.cusName, goods.*,
                                    case when  isnull(Dis_Status,'N')='Y' then '有效' else '失效' end as  StatusRemark
                                    from  ETL_Task_DIS_BasicGoods  goods
                                    left join  Base_Customer_SysInfo sys
                                    on goods.cusCode = sys.cusCode where 1 = 1";
                List<SqlParameter> listParam = new List<SqlParameter>();
                if (dto.DisCodeArr.Count > 0)//客户编码 
                {
                    List<SqlParameter> tmp_list = new List<SqlParameter>();
                    //string inStr = dto.DisCodeArr.ToInSql("cusCode", ref tmp_list);
                    //mainsql += $" and  goods.cusCode in ({inStr}) ";
                    listParam.AddRange(tmp_list);
                }
                if (!string.IsNullOrEmpty(dto.DIS_GoodsName))//商品名称
                {
                    mainsql += " and  goods.DIS_GoodsName like @DIS_GoodsName  ";
                    listParam.Add(new SqlParameter() { ParameterName = "@DIS_GoodsName", Value = string.Format("%{0}%", dto.DIS_GoodsName) });
                }
                if (!string.IsNullOrEmpty(dto.DIS_GoodsCode))//商品编码
                {
                    mainsql += " and   goods.DIS_GoodsCode like @DIS_GoodsCode  ";
                    listParam.Add(new SqlParameter() { ParameterName = "@DIS_GoodsCode", Value = string.Format("%{0}%", dto.DIS_GoodsCode) });
                }
                if (!string.IsNullOrEmpty(dto.DIS_Status))//商品状态
                {
                    mainsql += " and  isnull(goods.DIS_Status,'N') = @DIS_Status  ";
                    listParam.Add(new SqlParameter() { ParameterName = "@DIS_Status", Value = dto.DIS_Status });
                }
                //分页
                listParam.Add(new SqlParameter() { ParameterName = "@pageindex", Value = dto.page });
                listParam.Add(new SqlParameter() { ParameterName = "@pagesize", Value = dto.limit });
                string page_sql = $"select * from  ( select ROW_NUMBER() OVER (ORDER BY case when  ModifyDate  is null then '1900-01-01' else ModifyDate end   desc ,CreateDate desc ) AS RowNumber,  * from ( {mainsql} ) as t1 ) as t2 where RowNumber BETWEEN (@pagesize*(@pageindex-1)+1) AND @pageindex*@pagesize ";
                string total_sql = $" select count(*) as total from  ({mainsql} ) tbtemp ";
                List<SqlParameter> listparam = new List<SqlParameter>();
                DataTable dt = EfCoreHelper.ExcuteDataTable(context, mainsql, listparam);
                DIS_BasicGoodsListResult result = new DIS_BasicGoodsListResult();
                result.list = CommonHelper.ConvertDataTable<DIS_BasicGoodsListItem>(dt);
                DataTable dt_total = EfCoreHelper.ExcuteDataTable(context, total_sql, listparam);
                result.totalCount = int.Parse(dt_total.Rows[0][0].ToString());
                return new ApiResult<DIS_BasicGoodsListResult>(result);
            }

        }
    }
}
