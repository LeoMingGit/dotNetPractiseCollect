using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NugetManager.ConsoleApp
{
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
                Console.WriteLine("Not Found Local Pakage Source");
                return;
            }

            var allList = FetchAllPackagesAsync(pacakeSource.PackageSource).Result.ToList();


            string targetSource = "http://192.168.120.97:5555/v3/index.json";
            string apiKey = "ichia@sz321";
            foreach (var packageItem in allList)
            {
               // await PushPackageAsync(packageItem.PackagePath.ToString(), targetSource, apiKey);
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
        public async static Task<IEnumerable<PackageSearchMetadata>> FetchAllPackagesAsync(PackageSource packageSource)
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
                    take: 1000, // 每次检索1000个包，您可以根据需要调整这个值
                    log: NullLogger.Instance,
                    cancellationToken: System.Threading.CancellationToken.None);

                // 将 IPackageSearchMetadata 转换为 PackageSearchMetadata 类型
                var packages = searchResults.Select(result => result as PackageSearchMetadata);

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
        /// <param name="packageFilePath"></param>
        /// <param name="source"></param>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private async static Task PushPackageAsync(string packageFilePath, string source, string apiKey)
            {
                var processInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = $"nuget push \"{packageFilePath}\" -s {source} -k {apiKey}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using (var process = new Process())
                {
                    process.StartInfo = processInfo;

                    process.OutputDataReceived += (sender, args) => Console.WriteLine(args.Data);
                    process.ErrorDataReceived += (sender, args) => Console.WriteLine($"ERROR: {args.Data}");

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    await process.WaitForExitAsync();

                    if (process.ExitCode != 0)
                    {
                        throw new Exception($"dotnet nuget push failed with exit code {process.ExitCode}");
                    }
                }
            }

    }
}
