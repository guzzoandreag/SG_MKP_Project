﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SG_MKP_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new frmLogin();
        }

        protected override void OnStart()
        {
            //
        }

        protected override void OnSleep()
        {
            //
        }

        protected override void OnResume()
        {
            //
        }
    }
}
