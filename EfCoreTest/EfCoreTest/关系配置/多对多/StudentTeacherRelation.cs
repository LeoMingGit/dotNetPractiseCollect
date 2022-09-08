using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace EfCoreTest.关系配置.多对多
{
    [Table("T_StudentTeacherRelations")]
    public class StudentTeacherRelation
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        [Required]
        [StringLength(50)]
        [ForeignKey("Teacher")]
        public string TeacherCode { get; set; }
        [Required]
        [StringLength(50)]
        [ForeignKey("Student")]
        public string StudentCode { get; set; }
        public Student Student { get; set; } = new Student();
        public Teacher Teacher { get; set; } = new Teacher();


    }


}
