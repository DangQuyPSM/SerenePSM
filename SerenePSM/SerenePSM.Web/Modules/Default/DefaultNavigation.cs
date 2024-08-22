using Serenity.Navigation;
using MyPages = SerenePSM.Default.Pages;

[assembly: NavigationMenu(6000, "Danh mục", icon: "fa-users")]
//[assembly: NavigationLink(6100, "Danh mục/Movies",
//    typeof(MyPages.MoviePage), icon: "fa-video-camera")]
//[assembly: NavigationLink(int.MaxValue, "Default/Genre", typeof(MyPages.GenrePage), icon: null)]
[assembly: NavigationLink(6100, "Danh mục/Danh mục đối tượng", typeof(MyPages.Pfk7101Page), icon: "fa-users")]
[assembly: NavigationLink(6100, "Danh mục/Danh mục tổng hợp", typeof(MyPages.Pfk7171Page), icon: "fa fa-address-card")]
[assembly: NavigationLink(6100, "Danh mục/Danh mục vật tư", typeof(MyPages.Pfk7231Page), icon: "fa fa-address-card")]
[assembly: NavigationLink(6100, "Danh mục/Danh mục màu", typeof(MyPages.Pfk7121Page), icon: "fa fa-adjust")]
[assembly: NavigationLink(6100, "Danh mục/Danh mục nhân sự", typeof(MyPages.Pfk7411Page), icon: "fa-users")]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7171", typeof(MyPages.Pfk7171Page), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7101", typeof(MyPages.Pfk7101Page), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7171", typeof(MyPages.Pfk7171Page), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7231", typeof(MyPages.Pfk7231Page), icon: null)]



