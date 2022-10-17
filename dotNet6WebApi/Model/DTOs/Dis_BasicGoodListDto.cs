using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOs
{
    public class Dis_BasicGoodListDto
    {
        [Required]
        public int limit { get; set; }
        [Required]
        public int page { get; set; }

        public List<string> DisCodeArr { get; set; } = new List<string>();

        public string DIS_GoodsName { get; set; }

        public string DIS_GoodsCode { get; set; }

        /// <summary>
        /// 商品状态
        /// </summary>
        public string DIS_Status { get; set; }
    }
}
