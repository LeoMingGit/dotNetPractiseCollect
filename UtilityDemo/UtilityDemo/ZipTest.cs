using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityDemo
{
    public class ZipTest
    {
        public  static void Test()
        {
            string resource_path=PathHelper.GetCountParentDirectory( PathHelper.GetCurrentExcuteAppPath(),3);
            string source_path = PathHelper.PathCombine(resource_path, @"Resource\yashuo_test");
            string target_zip_path = PathHelper.GetParentDirectory(source_path);
            ZipHelper.ZipDirectory(source_path, target_zip_path,"yasuo_test", true);//加密压缩
        }
    }
}
