using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.VOs
{
    public class DIS_BasicGoodsListResult
    {
        public int totalCount { get; set; }
        public List<DIS_BasicGoodsListItem> list { get; set; } = new List<DIS_BasicGoodsListItem>();


    }
    public class DIS_BasicGoodsListItem
    {
        public string cusCode { get; set; }
        public string cusName { get; set; }
        public string distributorSoldTo { get; set; }
        public string DIS_GoodsCode { get; set; }
        public string DIS_GoodsName { get; set; }
        public string DIS_GoodsSpecification { get; set; }
        public string DIS_Remark { get; set; }
        public string DIS_Status { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Company { get; set; }
        public string CompanyCode { get; set; }
        public string StatusRemark { get; set; }
    }

}
