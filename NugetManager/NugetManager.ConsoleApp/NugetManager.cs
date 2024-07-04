using BaGetter.Protocol;
using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using NugetManager.ConsoleApp.Dto;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
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
        public static async void SynctAllNugetPackages()
        {
            var pacakeSource = GetLocalPackageSources();
            if(pacakeSource == null)
            {
                Console.WriteLine("未找到本机Nuget源");
                return;
            }
            var allLocalNugetList = FetchAllPackagesAsync(pacakeSource.PackageSource).Result.ToList();

            if(allLocalNugetList == null || allLocalNugetList.Count() == 0)
            {
                Console.WriteLine("本地Nuget数量为0");
            }
           var errorList = new List<string>();
            foreach (var packageItem in allLocalNugetList)
            {
                var targetItem = ToPackageDetailItem(packageItem);
                var msg =await PushPackageAsync(targetItem);
                if(false == string.IsNullOrEmpty(msg))
                {
                    errorList.Add(msg);
                }
            }

            Console.Write("\n\n\n");
            Console.Write($"------------------------------------{DateTime.Now}----------------------------------------\n\n");

            Console.WriteLine($"总数：{allLocalNugetList.Count}条\n", Color.Green);
            Console.WriteLine($"成功：{allLocalNugetList.Count- errorList.Count}条\n",Color.Green);
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
        /// 獲取本地Nuget 源
        /// </summary>
        /// <returns></returns>
        private static PackageSourceItem GetLocalPackageSources()
        {
            var settings = Settings.LoadDefaultSettings(null);
            var packageSourceProvider = new PackageSourceProvider(settings);
            var sources = packageSourceProvider.LoadPackageSources().Where(source => source.IsEnabled);

            var packageSourceItems = new List<PackageSourceItem>();
            foreach (var source in sources)
            {
                packageSourceItems.Add(new PackageSourceItem
                {
                    Name = source.Name,
                    Source = source.Source,
                    PackageSource = source
                });
            }
            return packageSourceItems.Where(x=>x.Name == "Microsoft Visual Studio Offline Packages").ToList().FirstOrDefault();
        }


        private static readonly HttpClient HttpClientInstance = new HttpClient();

        /// <summary>
        /// 獲取所有NuGet明細
        /// </summary>
        /// <param name="packageSource">NuGet包源</param>
        /// <returns>返回包含所有包明細的列表</returns>
        public async static Task<IEnumerable<dynamic>> FetchAllPackagesAsync(PackageSource packageSource)
        {
            try
            {
                var repository = Repository.Factory.GetCoreV3(packageSource.Source);
                var searchResource = await repository.GetResourceAsync<PackageSearchResource>();

                var searchFilter = new SearchFilter(includePrerelease: true);
                var searchResults = await searchResource.SearchAsync(
                    "", // 空字符串表示搜索所有包
                    searchFilter,
                    skip: 0,
                    take: 10000, // 每次检索10000个包，您可以根据需要调整这个值
                    log: NullLogger.Instance,
                    cancellationToken: System.Threading.CancellationToken.None);
                var packages = searchResults.ToList();

                return packages;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching packages: {ex.Message}");
                return new List<PackageSearchMetadata>();
            }
        }


        /// <summary>
        /// 推送到遠端
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        private async static Task<string> PushPackageAsync(PackageDetailItem dto)
        {

            var source = "http://192.168.120.97:5555/v3/index.json";
            var apiKey = "ichia@sz321";
            var pacageFullName = $"{dto.Title}.{dto.OriginalVersion}";
            var client = new NuGetClient("http://192.168.120.97:5555/v3/index.json");
            var nugetList = await client.SearchAsync(dto.Title);
            if (string.IsNullOrEmpty(dto.OriginalVersion) && nugetList.Count > 0)
            {
                Console.WriteLine($"{pacageFullName} 已上传");
                return string.Empty;
            }
            var filterNugetList = nugetList.Where(x => x.Version.Equals(dto.OriginalVersion)).ToList();
            if (filterNugetList.Count > 0)
            {
                Console.WriteLine($"{pacageFullName} 已上传");
                return string.Empty;
            }


            var processInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = $"nuget push \"{pacageFullName}\" -s {source} -k {apiKey}",
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

        /// <summary>
        /// 轉成 PackageDetailItem
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static PackageDetailItem ToPackageDetailItem(dynamic data)
        {
            var dto = new PackageDetailItem();
            dto.PackagePath = data.PackagePath;
            dto.Title = data.Title;
            if (data.Identity.HasVersion)
            {
                dto.OriginalVersion = data.Identity.Version.OriginalVersion;
            }
            return dto;
        }
    }
}
