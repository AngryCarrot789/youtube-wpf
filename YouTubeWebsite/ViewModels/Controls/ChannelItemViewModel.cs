using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using YouTubeWebsite.Utilities;

namespace YouTubeWebsite.ViewModels.Controls
{
    public class ChannelItemViewModel : BaseViewModel
    {
        private ImageSource _channelIcon;
        public ImageSource ChannelIcon
        {
            get => _channelIcon;
            set => RaisePropertyChanged(ref _channelIcon, value);
        }

        private string _channelName;
        public string ChannelName
        {
            get => _channelName;
            set => RaisePropertyChanged(ref _channelName, value);
        }

        private string _subCountString;
        public string SubscribersCountFormatted
        {
            get => _subCountString;
            set => RaisePropertyChanged(ref _subCountString, value);
        }

        private int _subCount;
        public int SubscribersCount
        {
            get => _subCount;
            set { RaisePropertyChanged(ref _subCount, value); SubscribersCountFormatted = $"{string.Format("{0:n0}", value)} subscribers"; }
        }
    }
}
