using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityDemo
{
    /// <summary>
    /// 
    /// </summary>
    public class PathHelper
    {
     
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public  static  string GetCurrentExcuteAppPath()
        {
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();
            return currentDirectory;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static string   PathCombine( params string[] paths)
        {
            return Path.Combine(paths);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public  static  string  GetParentDirectory(string path)
        {
            return System.IO.Directory.GetParent(path)?.FullName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetCountParentDirectory(string path, int x)
        {
            for (int i = 0; i < x; i++)
            {
                path = System.IO.Directory.GetParent(path)?.FullName;
            }
            return path;
        }
    }
}
