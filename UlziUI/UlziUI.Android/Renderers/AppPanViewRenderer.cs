using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using UlziUI.Controls;
using UlziUI.Droid.Renderers;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(AppPanView), typeof(AppPanViewRenderer))]
namespace UlziUI.Droid.Renderers
{
    #region AppPanViewRenderer
    public class AppPanViewRenderer : ViewRenderer
    {
        private AppPanView _appPanView = null;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> args)
        {
            base.OnElementChanged(args);

            _appPanView = (this.Element as AppPanView);

            this.Touch += this.ControlTouch;
        }

        private void ControlTouch(object sender, TouchEventArgs args)
        {
            if (_appPanView != null)
            {
                var x = args.Event.GetX() / Resources.DisplayMetrics.Density;
                var y = args.Event.GetY() / Resources.DisplayMetrics.Density;

                var ev = AppPanViewEvent.None;

                if (args.Event.Action == MotionEventActions.Down)
                    ev = AppPanViewEvent.Start;
                else if (args.Event.Action == MotionEventActions.Move)
                    ev = AppPanViewEvent.Move;
                else if (args.Event.Action == MotionEventActions.Up)
                    ev = AppPanViewEvent.Complete;

                _appPanView.DoPanEvent(new AppPanViewEventArgs(ev, x, y));
            }
        }
    }
    #endregion
}