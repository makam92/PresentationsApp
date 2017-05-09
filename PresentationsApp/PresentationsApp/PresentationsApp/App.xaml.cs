using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Xamarin.Forms;

namespace PresentationsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            MainPage = new NavigationPage(new PresentationsApp.MainPage());
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
