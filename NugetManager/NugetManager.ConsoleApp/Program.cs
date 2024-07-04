using System;

namespace NugetManager.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NugetManager.SynctAllNugetPackages();
            Console.ReadLine();
        }
    }
}
