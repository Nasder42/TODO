using System;
using System.Collections.Generic;
using TODO.Views;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TODO
{
    public class App : Application
    {
        public App()
        {

            MainPage = new NavigationPage(new MainPage());

            //MainPage = new TestPage();
            //MainPage.Navigation.PushAsync(new TestPage());
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=6511dd50-ae11-49b8-a7ee-7e98c744c29b;" + "uwp={Your UWP App secret here};" + "ios={Your iOS App secret here}", typeof(Analytics), typeof(Crashes));
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
