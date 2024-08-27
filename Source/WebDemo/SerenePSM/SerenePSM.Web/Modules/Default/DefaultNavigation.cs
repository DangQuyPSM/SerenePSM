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
[assembly: NavigationLink(6100, "Danh mục/Danh mục chi tiết", typeof(MyPages.Pfk7103Page), icon: "fa-users")]
[assembly: NavigationLink(6100, "Danh mục/Danh mục máy móc", typeof(MyPages.Pfk7155Page), icon: "fa-users")]
[assembly: NavigationLink(6100, "Danh mục/Danh mục dãy size", typeof(MyPages.Pfk7104Page), icon: "fa-users")]
[assembly: NavigationLink(6100, "Danh mục/Danh mục công cụ Size Range", typeof(MyPages.Pfk7105Page), icon: "fa-users")]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7171", typeof(MyPages.Pfk7171Page), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7101", typeof(MyPages.Pfk7101Page), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7171", typeof(MyPages.Pfk7171Page), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7231", typeof(MyPages.Pfk7231Page), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7103", typeof(MyPages.Pfk7103Page), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7155", typeof(MyPages.Pfk7155Page), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7104", typeof(MyPages.Pfk7104Page), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Default/Pfk7105", typeof(MyPages.Pfk7105Page), icon: null)]
//[assembly: NavigationLink(6100, "Danh mục/Danh mục dãy size", typeof(MyPages.Pfk7104Page), icon: "fa-users")]
[assembly: NavigationMenu(7000, "Kinh doanh", icon: "fa fa-adjust")]
[assembly: NavigationLink(7100, "Kinh doanh/Danh mục sản phẩm", typeof(MyPages.Pfk7106Page), icon: "fa fa-adjust")]



