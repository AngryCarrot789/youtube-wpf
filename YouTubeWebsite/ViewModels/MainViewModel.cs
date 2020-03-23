using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using YouTubeWebsite.Controls;
using YouTubeWebsite.Utilities;

namespace YouTubeWebsite.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public VideoContainerViewModel VideosContainer { get; set; }

        public MainViewModel()
        {
            VideosContainer = new VideoContainerViewModel();

            VideosContainer.AddTestItem();
            VideosContainer.AddTestItem();
            VideosContainer.AddTestItem();
            VideosContainer.AddTestItem();
            VideosContainer.AddTestItem();
            VideosContainer.AddTestItem();
            VideosContainer.AddTestItem();
            VideosContainer.AddTestItem();
            VideosContainer.AddTestItem();
            VideosContainer.AddTestItem();
        }
    }
}
