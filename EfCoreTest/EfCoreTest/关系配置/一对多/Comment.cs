using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EfCoreTest.关系配置.一对多
{
    [Table("T_Comments")]
    public class Comment
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string Code { get; set; }//主键

        [Required]
        [StringLength(50)]
        [ForeignKey("Article")]
        public string AriticleCodeRef { get; set; }
        [Required]
        [StringLength(500)]
        public string Message { get; set; }

        /// <summary>
        /// 可为空
        /// </summary>
        public DateTime? AuditTime { get; set; }

        //Navigational Property
        public virtual Article Article { get; set; }
    }
}
