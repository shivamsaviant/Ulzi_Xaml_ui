using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Views.Pages;
using Xamarin.Forms;

namespace UlziUI
{
    #region App
    public class App : Application
    {
        public App() : base()
        {
            
            //this.MainPage = new MainPage();
            this.MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("#61A8A1"), BarTextColor = Color.FromHex("#FFFFFF") };
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }
    }
    #endregion
}
