using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using YouTubeWebsite.Controls;
using YouTubeWebsite.Utilities;

namespace YouTubeWebsite.ViewModels.Controls
{
    public class ChannelGroupContainerViewModel : BaseViewModel
    {
        private string _groupHeader;
        public string GroupHeader
        {
            get => _groupHeader;
            set => RaisePropertyChanged(ref _groupHeader, value);
        }

        private ObservableCollection<ChannelItem> _channels = new ObservableCollection<ChannelItem>();
        public ObservableCollection<ChannelItem> Channels
        {
            get => _channels;
            set => RaisePropertyChanged(ref _channels, value);
        }

        public void ClearChannels() { Channels.Clear(); }
        public void AddChannel(ChannelItem channel) { Channels.Add(channel); }
        public void RemoveChannel(ChannelItem channel) { Channels.Remove(channel); }

        public void AddChannel(string channelIconPath, string channelName, int subscribersCount)
        {
            ChannelItem vi = new ChannelItem();
            ChannelItemViewModel vivm = new ChannelItemViewModel();

            vivm.ChannelIcon = new BitmapImage(new Uri(channelIconPath));
            vivm.ChannelName = channelName;
            vivm.SubscribersCount = subscribersCount;
            vi.DataContext = vivm;

            AddChannel(vi);
        }
    }
}
