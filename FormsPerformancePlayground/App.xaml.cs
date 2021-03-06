﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsPerformancePlayground
{
    public partial class App : Application
    {
        public static NavigationPage Nav;

        public App()
        {
            InitializeComponent();

            Nav = new NavigationPage(new MainPage());
            MainPage = Nav;
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

