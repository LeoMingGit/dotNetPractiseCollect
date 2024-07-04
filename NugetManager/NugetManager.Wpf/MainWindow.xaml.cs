using NuGet.Common;
using NuGet.Configuration;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NugetManager.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadPackageSources();
        }

        private void LoadPackageSources()
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

            listBoxSources.ItemsSource = packageSourceItems;
        }

        private async void listBoxSources_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (listBoxSources.SelectedItem != null)
            {
                var selectedSourceItem = listBoxSources.SelectedItem as PackageSourceItem;

                if (selectedSourceItem != null)
                {
 
                    // Fetch and display packages from the selected NuGet source
                    await FetchPackagesFromSourceAsync(selectedSourceItem.PackageSource);
                }
            }
        }

        private async Task FetchPackagesFromSourceAsync(PackageSource packageSource)
        {
            try
            {
                var repository = Repository.Factory.GetCoreV3(packageSource.Source);
                var searchResource = await repository.GetResourceAsync<PackageSearchResource>();
         
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to push packages: {ex.Message}");
            }
        }


        private List<string> FindPackageFiles(string directory)
        {
            return Directory.GetFiles(directory, "*.nupkg", SearchOption.AllDirectories).ToList();
        }
    }
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
