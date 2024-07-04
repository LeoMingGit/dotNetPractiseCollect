using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetManager.ConsoleApp.Dto
{
    internal class ProjPackageItem
    {
        public string packageName {  get; set; }

        public string packageVersion { get; set; }

        public  string  fullPath { get; set; }
    }
}
