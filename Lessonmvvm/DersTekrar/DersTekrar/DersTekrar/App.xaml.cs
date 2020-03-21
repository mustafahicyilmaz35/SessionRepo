using System;
using DersTekrar.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DersTekrar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StudentView());
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
