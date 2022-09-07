using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EfCoreTest.关系配置.一对一
{
    [Table("T_Delivery")]

    public class Delivery
    {

        [ForeignKey("Order")]
        [StringLength(50)]
        public string OrderCodeRef { get; set; }//指向订单的外键

        [Key]
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        public string CompanyName { get; set; }//快递公司名
        [Required]
        public String Number { get; set; }//快递单号
        public virtual Order Order { get; set; }//订单

    }
}
