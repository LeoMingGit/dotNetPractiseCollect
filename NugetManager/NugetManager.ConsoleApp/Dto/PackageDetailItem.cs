using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetManager.ConsoleApp.Dto
{
    internal class PackageDetailItem
    {
        public string PackagePath { get; set; } 

        public  string Title { get; set; }

        public string OriginalVersion { get; set; }
    }
}
