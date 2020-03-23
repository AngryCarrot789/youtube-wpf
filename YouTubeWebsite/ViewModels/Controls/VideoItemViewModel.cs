using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using YouTubeWebsite.Utilities;

namespace YouTubeWebsite.ViewModels.Controls
{
    public class VideoItemViewModel : BaseViewModel
    {
        private ImageSource _thumbnail;
        public ImageSource Thumbnail
        {
            get => _thumbnail;
            set => RaisePropertyChanged(ref _thumbnail, value);
        }

        private string _videoName;
        public string VideoName
        {
            get => _videoName;
            set => RaisePropertyChanged(ref _videoName, value);
        }

        private string _videoURL;
        public string VideoURL
        {
            get => _videoURL;
            set => RaisePropertyChanged(ref _videoURL, value);
        }

        private string _channelName;
        public string ChannelName
        {
            get => _channelName;
            set => RaisePropertyChanged(ref _channelName, value);
        }

        private string _viewCounterString;
        public string ViewCounterFormatted
        {
            get => _viewCounterString;
            set => RaisePropertyChanged(ref _viewCounterString, value);
        }

        private string _dateUploadedString;
        public string DateUploadedFormatted
        {
            get => _dateUploadedString;
            set => RaisePropertyChanged(ref _dateUploadedString, value);
        }

        private int _viewCounter;
        public int ViewCounter
        {
            get => _viewCounter;
            set { RaisePropertyChanged(ref _viewCounter, value); ViewCounterFormatted = $"{string.Format("{0:n0}", value)} views"; }
        }

        private int _dateUploaded;
        /// <summary>
        /// In days
        /// </summary>
        public int DateUploaded
        {
            get => _dateUploaded;
            set { RaisePropertyChanged(ref _dateUploaded, value); DateUploadedFormatted = $"{value} days ago"; }
        }
    }
}
