using System;
using Xamarin.Forms;
using UnU.View;
using Xamarin.Forms.Xaml;

namespace UnU
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PrimeraPag());
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
