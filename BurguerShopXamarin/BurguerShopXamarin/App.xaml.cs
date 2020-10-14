using BurguerShopXamarin.Views;
using Xamarin.Forms;


[assembly: ExportFont("BebasNeue.ttf", Alias = "ThemeFont")]
[assembly: ExportFont("Roboto.ttf", Alias = "LightFont")]
namespace BurguerShopXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LandingPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
