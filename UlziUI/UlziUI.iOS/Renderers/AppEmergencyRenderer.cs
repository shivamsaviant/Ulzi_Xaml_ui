using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using UlziUI.Controls;
using Xamarin.Forms;
using UlziUI.iOS.Renderers;

[assembly: ExportRenderer(typeof(AppEmergency), typeof(AppEmergencyRenderer))]
namespace UlziUI.iOS.Renderers
{
    #region AppEmergencyRendrerer
    public class AppEmergencyRenderer : ImageRenderer
    {
        private AppEmergency _appEmergency = null;

        protected override void OnElementChanged(ElementChangedEventArgs<Image> args)
        {
            base.OnElementChanged(args);

            _appEmergency = (this.Element as AppEmergency);
        }

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);

            if (_appEmergency != null)
                _appEmergency.DoStarted();
        }

        public override void TouchesEnded(NSSet touches, UIEvent evt)
        {
            base.TouchesEnded(touches, evt);

            if (_appEmergency != null)
                _appEmergency.DoCompleted();
        }

        public override void TouchesMoved(NSSet touches, UIEvent evt)
        {
            base.TouchesMoved(touches, evt);

            if (_appEmergency != null)
            {
                var touch = (touches.AnyObject as UITouch);
                var location = touch.LocationInView(this);
                var prevLocation = touch.PreviousLocationInView(this);
                _appEmergency.DoRunning(location.X - prevLocation.X, location.Y - prevLocation.Y);
            }
        }

        public override void TouchesCancelled(NSSet touches, UIEvent evt)
        {
            base.TouchesCancelled(touches, evt);
        }
    }
    #endregion
}