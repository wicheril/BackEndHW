using HomeWorkBackend.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeWorkBackend
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Product());
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
