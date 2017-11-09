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
using Xamarin.Forms;
using UlziUI.Droid.Renderers;

[assembly: ExportRenderer(typeof(AppEmergency), typeof(AppEmergencyRenderer))]
namespace UlziUI.Droid.Renderers
{
    #region AppEmergencyRenderer
    public class AppEmergencyRenderer : ImageRenderer
    {
        private AppEmergency _appEmergency = null;

        private float _startX = 0;
        private float _startY = 0;

        protected override void OnElementChanged(ElementChangedEventArgs<Image> args)
        {
            base.OnElementChanged(args);

            _appEmergency = (this.Element as AppEmergency);

            if (this.Control != null)
                this.Control.Touch += ControlTouch;
        }

        private void ControlTouch(object sender, TouchEventArgs args)
        {
            if (_appEmergency != null)
            {
                if (args.Event.Action == MotionEventActions.Down)
                {
                    _appEmergency.DoStarted();
                    _startX = args.Event.GetX() / Resources.DisplayMetrics.Density;
                    _startY = args.Event.GetY() / Resources.DisplayMetrics.Density;

                    Console.WriteLine("Start coordinates => {0}, {1}", _startX, _startY);

                }
                else if (args.Event.Action == MotionEventActions.Move)
                {
                    var x = (args.Event.GetX() / Resources.DisplayMetrics.Density);
                    var y = (args.Event.GetY() / Resources.DisplayMetrics.Density);

                    var deltaX = x - _startX;
                    var deltaY = y - _startY;

                    Console.WriteLine("Coordinates => {0}, {1} ---- Delta => {2}, {3}", x, y, deltaX, deltaY);

                    _appEmergency.DoRunning(deltaX, deltaY);
                }
                else if (args.Event.Action == MotionEventActions.Up)
                {
                    _appEmergency.DoCompleted();
                    _startX = 0;
                    _startY = 0;
                }
            }
        }
    }
    #endregion
}