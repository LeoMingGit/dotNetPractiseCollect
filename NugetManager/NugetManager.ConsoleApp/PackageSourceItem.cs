using NuGet.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetManager.ConsoleApp
{
    public class PackageSourceItem
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public PackageSource PackageSource { get; set; }

        public override string ToString()
        {
            return Source;
        }
    }
}
