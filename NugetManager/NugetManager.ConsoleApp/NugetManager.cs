using BaGetter.Protocol;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using NuGet.Versioning;
using NugetManager.ConsoleApp.Dto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Xml.Linq;
using Console = Colorful.Console;

namespace NugetManager.ConsoleApp
{

    /// <summary>
    /// nuget上传管理
    /// </summary>
    public class NugetManager
    {

        /// <summary>
        /// 同步本地所有的Nuget 包
        /// </summary>
        /// <param name="slnPath"></param>
        public static async void SynctAllNugetPackages(string slnPath)
        {
            var slnNugetList = GetAllNugetBySlnPath(slnPath);
            if (slnNugetList == null || slnNugetList.Count==0)
            {
                Console.WriteLine("未找到项目中的依赖项");
                return;
            }
          
            var errorList = new List<string>();
            foreach (var packageItem in slnNugetList)
            {
                var msg =await PushPackageAsync(packageItem);
                if(false == string.IsNullOrEmpty(msg))
                {
                    errorList.Add(msg);
                }
            }

            Console.Write("\n\n\n");
            Console.Write($"------------------------------------{DateTime.Now}----------------------------------------\n\n");

            Console.WriteLine($"总数：{slnNugetList.Count}条\n", Color.Green);
            Console.WriteLine($"成功：{slnNugetList.Count- errorList.Count}条\n",Color.Green);
            if(errorList.Count > 0) 
            {
                Console.WriteLine($"失败：{errorList.Count}", Color.Red);
                foreach (var item in errorList)
                {
                    Console.WriteLine($"\n {item}");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="packageName"></param>
        /// <param name="packageVersion"></param>
        /// <returns></returns>
        private static ProjPackageItem GetLocalNuGetPackagePath(string packageName, string packageVersion)
        {
            // 获取当前用户的 NuGet 包目录
            string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string nugetPackageRoot = Path.Combine(userProfile, ".nuget", "packages");
            string _temp_packageVersion = string.Empty;
            if (packageVersion.Contains("*"))
            {
                // 查找满足版本要求的包
                string packageDir = Path.Combine(nugetPackageRoot, packageName);
                if (Directory.Exists(packageDir))
                {
                    var versionDirs = Directory.GetDirectories(packageDir);
                    var versions = versionDirs.Select(Path.GetFileName)
                                              .Where(v => Version.TryParse(v, out _))
                                              .Select(Version.Parse)
                                              .OrderByDescending(v => v);

                    foreach (var version in versions)
                    {
                        if (VersionSatisfies(packageVersion, version))
                        {
                            _temp_packageVersion = version.ToString();
                            break;
                        }
                    }
                    if (string.IsNullOrEmpty(_temp_packageVersion))
                    {
                        Console.WriteLine($"{packageName} {packageVersion}",Color.Red);
                    }
                    packageVersion = _temp_packageVersion;
                }
            }
            // 构建包的完整路径
            var packagePath = Path.Combine(nugetPackageRoot, packageName, packageVersion,$"{packageName}.{packageVersion}.nupkg");
            return new ProjPackageItem { packageName = packageName, packageVersion = packageVersion, fullPath = packagePath };
         }

        private static bool VersionSatisfies(string versionPattern, Version version)
        {
            // 简单的通配符匹配实现
            var patternParts = versionPattern.Split('.');
            var versionParts = version.ToString().Split('.');

            for (int i = 0; i < patternParts.Length; i++)
            {
                if (patternParts[i] == "*") continue;
                if (i >= versionParts.Length || patternParts[i] != versionParts[i]) return false;
            }

            return true;
        }


        /// <summary>
        /// 获取指定文件夹的项目依赖
        /// </summary>
        /// <param name="slnPath"></param>
        private static List<ProjPackageItem> GetAllNugetBySlnPath(string slnPath)
        {
            if (Directory.Exists(slnPath)==false)
            {
                return new List<ProjPackageItem>();
            }
            var nugetPackages = new List<ProjPackageItem>();

            // 获取所有 .csproj 文件
            string[] projectFiles = Directory.GetFiles(slnPath, "*.csproj", SearchOption.AllDirectories);

            foreach (string projectFile in projectFiles)
            {
                // 加载和解析 .csproj 文件
                XDocument projectXml = XDocument.Load(projectFile);
                XNamespace ns = projectXml.Root.Name.Namespace;

                // 查找所有 PackageReference 元素
                foreach (XElement packageReference in projectXml.Descendants(ns + "PackageReference"))
                {
                    string packageName = packageReference.Attribute("Include")?.Value;
                    string packageVersion = packageReference.Attribute("Version")?.Value;

                    if (!string.IsNullOrEmpty(packageName) && !string.IsNullOrEmpty(packageVersion))
                    {
                        var packageItem= GetLocalNuGetPackagePath(packageName, packageVersion);
                   
                        nugetPackages.Add(packageItem);
                    }
                }
            }

            return nugetPackages;

        }



        /// <summary>
        /// 推送到遠端
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        private async static Task<string> PushPackageAsync(ProjPackageItem dto)
        {
            var source = "http://192.168.120.97:5555/v3/index.json";
            var apiKey = "ichia@sz321";
            var pacageFullName = $"{dto.packageName}.{dto.packageVersion}";
            if (File.Exists(dto.fullPath) == false)
            {
                Console.WriteLine($"{pacageFullName} 未找到");
                return $"{pacageFullName} 未找到";
            }

            var client = new NuGetClient("http://192.168.120.97:5555/v3/index.json");
            var nugetList = await client.SearchAsync(dto.packageName);
            if (string.IsNullOrEmpty(dto.packageVersion) && nugetList.Count > 0)
            {
                Console.WriteLine($"{pacageFullName} 已上传");
                return string.Empty;
            }
            var filterNugetList = nugetList.Where(x => x.Version.Equals(dto.packageVersion)).ToList();
            if (filterNugetList.Count > 0)
            {
                Console.WriteLine($"{pacageFullName} 已上传");
                return string.Empty;
            }

            var processInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"nuget push \"{dto.fullPath}\" -s {source} -k {apiKey}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = new Process())
            {
                process.StartInfo = processInfo;

                process.OutputDataReceived += (sender, args) => Console.WriteLine($"{pacageFullName} 成功: {args.Data}");
                process.ErrorDataReceived += (sender, args) => Console.WriteLine($"{pacageFullName} 失败: {args.Data}", Color.Red);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                await process.WaitForExitAsync();

                if (process.ExitCode != 0)
                {
                    Console.WriteLine($"{pacageFullName} 上传失败", Color.Red);
                   
                    return $"{pacageFullName} 上传失败";

                }
                Console.WriteLine($"{pacageFullName} 上传成功", Color.Green);
                return string.Empty;
            }
        }

    }
}
