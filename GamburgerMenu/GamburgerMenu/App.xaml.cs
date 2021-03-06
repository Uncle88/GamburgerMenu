﻿using GamburgerMenu.Views;
using Xamarin.Forms;

namespace GamburgerMenu
{
    public partial class App : Application
    {
        public static NavigationPage NavigationPage { get; private set; }
        private static RootPage RootPage;
		public static bool MenuIsPresented
        {
            get
            {
                return RootPage.IsPresented;
            }
            set
            {
                RootPage.IsPresented = value;
            }
        }

		public App()
        {
            InitializeComponent();
            var menuPage = new MenuPage();
            NavigationPage = new NavigationPage(new HomePage());

            RootPage = new RootPage();
            RootPage.Master = menuPage;
            RootPage.Detail = NavigationPage;
            MainPage = RootPage;
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
