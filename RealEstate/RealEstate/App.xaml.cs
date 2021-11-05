using RealEstate.Themes;
using RealEstate.Views;
using Xamarin.Forms;

namespace RealEstate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            ThemeHelper.ChangeTheme(Settings.ThemeOption, true);
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            ThemeHelper.ChangeTheme(Settings.ThemeOption, true);
        }
    }
}
