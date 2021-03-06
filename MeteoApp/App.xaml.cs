﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MeteoApp.DatabaseManager;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MeteoApp
{
    public partial class App : Application
    {
        static Database databaseManager;

        public static Database DatabaseManager
        {
            get
            {
                if (databaseManager == null)
                    databaseManager = new Database();

                return databaseManager;
            }
        }

        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new MeteoListPage())
            {
                BarBackgroundColor = Color.LightGreen,
                BarTextColor = Color.White
            };

            MainPage = nav;
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
