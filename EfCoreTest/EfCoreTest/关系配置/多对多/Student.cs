using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EfCoreTest.关系配置.多对多
{

    [Table("T_Students")]
    public class Student
    {
        [Key]
        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public List<StudentTeacherRelation> StudentTeacherRelations { get; set; }=new List<StudentTeacherRelation>();
    }
}
