using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using YouTubeWebsite.Controls;
using YouTubeWebsite.Utilities;
using YouTubeWebsite.ViewModels.Controls;

namespace YouTubeWebsite.ViewModels
{
    public class VideoContainerViewModel : BaseViewModel
    {
        private ObservableCollection<object> _groupItems = new ObservableCollection<object>();
        public ObservableCollection<object> GroupItems
        {
            get => _groupItems;
            set => RaisePropertyChanged(ref _groupItems, value);
        }

        public void ClearItems() { GroupItems.Clear(); }
        public void AddGroup(object group) { GroupItems.Add(group); }
        public void RemoveGroup(object group) { GroupItems.Remove(group); }

        public void AddTestItem()
        {
            VideoGroupContainer vgc = new VideoGroupContainer();
            VideoGroupContainerViewModel vgcvm = new VideoGroupContainerViewModel();
            ChannelGroupContainer cgc = new ChannelGroupContainer();
            ChannelGroupContainerViewModel cgcvm = new ChannelGroupContainerViewModel();

            vgcvm.AddVideo(@"E:\VSProjects\YouTubeWebsite\YouTubeWebsite\Image1.png", 
                "How to quickscope a lamp", 
                @"https://www.youtube.com/watch?v=6g6LQQvNoz4", 
                "YourPetGoose", 
                6946620, 1337);

            vgcvm.AddVideo(@"E:\VSProjects\YouTubeWebsite\YouTubeWebsite\Image2.png",
                "AIR SIREN EXPLODES!!!1! (MUST WATCH!) (GONE SEXUAL)",
                @"https://www.youtube.com/watch?v=6g6LQQvNoz4",
                "iminmemumscarbroombroom",
                1123846, 2);
            vgcvm.AddVideo(@"E:\VSProjects\YouTubeWebsite\YouTubeWebsite\Image2.png",
                "AIR SIREN EXPLODES!!!1! (MUST WATCH!) (GONE SEXUAL)",
                @"https://www.youtube.com/watch?v=6g6LQQvNoz4",
                "iminmemumscarbroombroom",
                16, 335);
            vgcvm.AddVideo(@"E:\VSProjects\YouTubeWebsite\YouTubeWebsite\Image2.png",
                "AIR SIREN EXPLODES!!!1! (MUST WATCH!) (GONE SEXUAL)",
                @"https://www.youtube.com/watch?v=6g6LQQvNoz4",
                "iminmemumscarbroombroom",
                112382446, 3557);
            vgcvm.AddVideo(@"E:\VSProjects\YouTubeWebsite\YouTubeWebsite\Image2.png",
                "AIR SIREN EXPLODES!!!1! (MUST WATCH!) (GONE SEXUAL)",
                @"https://www.youtube.com/watch?v=6g6LQQvNoz4",
                "iminmemumscarbroombroom",
                134646, 3333);

            vgcvm.AddVideo(@"E:\VSProjects\YouTubeWebsite\YouTubeWebsite\Image1.png",
                "How to quickscope a lamp",
                @"https://www.youtube.com/watch?v=6g6LQQvNoz4",
                "YourPetGoose",
                69420, 1337);
            vgcvm.AddVideo(@"E:\VSProjects\YouTubeWebsite\YouTubeWebsite\Image1.png",
                "How to quickscope a lamp",
                @"https://www.youtube.com/watch?v=6g6LQQvNoz4",
                "YourPetGoose",
                69420, 1337);

            cgcvm.AddChannel(@"E:\VSProjects\YouTubeWebsite\YouTubeWebsite\Image3.png", "YourWiFiPasswordIs", 166332);
            cgcvm.AddChannel(@"E:\VSProjects\YouTubeWebsite\YouTubeWebsite\Image4.png", "The Cake is NOT a lie", 289437569);
            cgcvm.AddChannel(@"E:\VSProjects\YouTubeWebsite\YouTubeWebsite\Image4.png", "aeaeae", 24552);
            cgcvm.AddChannel(@"E:\VSProjects\YouTubeWebsite\YouTubeWebsite\Image3.png", "intel pentium d", 71892365);

            cgcvm.GroupHeader = "You might like these channels!";
            vgcvm.GroupHeader = "Check out these cool videos!";

            vgc.DataContext = vgcvm;
            cgc.DataContext = cgcvm;

            GroupItems.Add(vgc);
            GroupItems.Add(cgc);
        }

        public void CreateTestVideo()
        {

        }
    }
}
