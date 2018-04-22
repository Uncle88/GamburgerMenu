using System;
using System.Collections.Generic;
using GamburgerMenu.ViewModels;
using Xamarin.Forms;

namespace GamburgerMenu.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            BindingContext = new MenuPageViewModel();
            InitializeComponent();
        }
    }
}
