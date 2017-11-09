using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace UlziUI.Droid
{
	[Activity (Label = "UlziUI", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Window.DecorView.SystemUiVisibility = 0;
                var statusBarHeightInfo = typeof(FormsAppCompatActivity).GetField("_statusBarHeight", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                if (statusBarHeightInfo != null)
                    statusBarHeightInfo.SetValue(this, 0);
                Window.SetStatusBarColor(new Android.Graphics.Color(14, 14, 14, 255));
            }

            this.Window.SetFlags(WindowManagerFlags.KeepScreenOn, WindowManagerFlags.KeepScreenOn);
            this.Window.AddFlags(WindowManagerFlags.TranslucentStatus);

            global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new UlziUI.App ());
		}
	}
}

