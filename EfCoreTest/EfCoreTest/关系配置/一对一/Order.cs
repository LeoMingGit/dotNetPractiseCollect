using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EfCoreTest.关系配置.一对一
{
    [Table("T_Orders")]
    public class Order
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }//商品名
        [Required]
        public string Address { get; set; }//收货地址

        public virtual Delivery Delivery { get; set; }//快递信息

    }
}
