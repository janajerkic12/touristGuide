﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JanaJerkic_Feb2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Glavna();
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
