using System;
using System.Windows.Input;
using GamburgerMenu.Views;
using Xamarin.Forms;

namespace GamburgerMenu.ViewModels
{
    public class MenuPageViewModel
    {
        public ICommand GoHomeCommand { get; set; }
        public ICommand GoSecondCommand { get; set; }
        public ICommand GoThirdCommand { get; private set; }

        public MenuPageViewModel()
        {
            GoHomeCommand = new Command(GoHome);
            GoSecondCommand = new Command(GoSecond);
            GoThirdCommand = new Command(GoThird);
        }

        void GoHome(object obj)
        {
            App.NavigationPage.Navigation.PopToRootAsync();
            App.MenuIsPresented = false;
        }

        void GoSecond(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new SecondPage());
            App.MenuIsPresented = false;
        }

        void GoThird(object obj)
        {
            App.NavigationPage.Navigation.PushAsync(new ThirdPage());
            App.MenuIsPresented = false;
        }
    }
}
