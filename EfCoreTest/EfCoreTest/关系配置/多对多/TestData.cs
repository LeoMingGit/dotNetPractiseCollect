using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTest.关系配置.多对多
{
    public static class TestData
    {
        public static  void Test()
        {
            InsertData();
        }

        private static void InsertData()
        {
            using var ctx = new TestDbContext();
            string TeacherCode = Guid.NewGuid().ToString("N");
            string StudentCode = Guid.NewGuid().ToString("N");
            StudentTeacherRelation s = new StudentTeacherRelation();
            s.Code = Guid.NewGuid().ToString("N");
            s.TeacherCode = TeacherCode;
            s.StudentCode = StudentCode;
            s.Teacher = new Teacher()
            {
                Code = TeacherCode,
                Name = "李老师"
            };
            s.Student = new Student()
            {
                Code = StudentCode,
                Name = "李同学"
            };
            ctx.StudentTeacherRelations.Add(s);
            ctx.SaveChanges();
        }
    }
}
