using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EfCoreTest.关系配置.一对多
{
    [Table("T_Articles")]
    public class Article
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string Code { get; set; }//主键
        [Required]
        [StringLength(150)]
        public string Title { get; set; }//标题
        [Required]
        [StringLength(500)]
        public string Content { get; set; }//内容
        //Navigational Property
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>(); //此文章的若干条评论
    }
}
