using GamburgerMenu.Views;
using Xamarin.Forms;

namespace GamburgerMenu
{
    public partial class App : Application
    {
        public static NavigationPage NavigationPage { get; private set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
