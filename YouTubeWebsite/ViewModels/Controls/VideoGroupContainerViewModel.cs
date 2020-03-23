using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using YouTubeWebsite.Controls;
using YouTubeWebsite.Utilities;

namespace YouTubeWebsite.ViewModels.Controls
{
    public class VideoGroupContainerViewModel : BaseViewModel
    {
        private string _groupHeader;
        public string GroupHeader
        {
            get => _groupHeader;
            set => RaisePropertyChanged(ref _groupHeader, value);
        }

        private ObservableCollection<VideoItem> _videos = new ObservableCollection<VideoItem>();
        public ObservableCollection<VideoItem> Videos
        {
            get => _videos;
            set => RaisePropertyChanged(ref _videos, value);
        }

        public void ClearVideos() { Videos.Clear(); }
        public void AddVideo(VideoItem video) { Videos.Add(video); }
        public void RemoveVideo(VideoItem video) { Videos.Remove(video); }

        public void AddVideo(string thumbnailPath, string videoName, string videoURL, string channelName, int viewCounter, int daysUploadedFor)
        {
            VideoItem vi = new VideoItem();
            VideoItemViewModel vivm = new VideoItemViewModel();

            vivm.Thumbnail = new BitmapImage(new Uri(thumbnailPath));
            vivm.VideoName = videoName;
            vivm.VideoURL = videoURL;
            vivm.ChannelName = channelName;
            vivm.ViewCounter = viewCounter;
            vivm.DateUploaded = daysUploadedFor;
            vi.DataContext = vivm;

            AddVideo(vi);
        }
    }
}
