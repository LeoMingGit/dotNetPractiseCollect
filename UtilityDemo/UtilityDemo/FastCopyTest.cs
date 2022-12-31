
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityDemo.Model;

namespace UtilityDemo
{
    public static class FastCopyTest
    {

        public static void Test()
        {
            List<AdvancedCourseInfo>  advancedCourseInfo = new List<AdvancedCourseInfo>();
            for (int i = 0; i < 10; i++)
            {
                AdvancedCourseInfo item = new AdvancedCourseInfo()
                {
                    Description = $"我是一个课程，序号为{i.ToString()}",
                    Name = i.ToString(),
                    courseTime = DateTime.Now,
                };
                advancedCourseInfo.Add(item);
            }

            List<CourseInfo>  courseInfos = new List<CourseInfo>();

            foreach (var source in advancedCourseInfo)
            {
                CourseInfo taget = new CourseInfo();

                FastCopy.Copy(source, taget);
                courseInfos.Add(taget);
            }
            SerializeService serializeService = new SerializeService();
            var json = serializeService.SerializeObject(courseInfos);

            Console.WriteLine(json);

        }
    }
}
