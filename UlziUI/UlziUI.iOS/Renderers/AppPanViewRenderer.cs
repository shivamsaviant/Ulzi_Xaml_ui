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

[assembly: ExportRenderer(typeof(AppPanView), typeof(AppPanViewRenderer))]
namespace UlziUI.iOS.Renderers
{
    #region AppPanViewRenderer
    public class AppPanViewRenderer : ViewRenderer
    {
        private AppPanView _appPanView = null;

        protected override void OnElementChanged(ElementChangedEventArgs<View> args)
        {
            base.OnElementChanged(args);

            _appPanView = (this.Element as AppPanView);
        }

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);

            if (_appPanView != null)
            {
                var touch = (touches.AnyObject as UITouch);
                var location = touch.LocationInView(this);
                _appPanView.DoPanEvent(new AppPanViewEventArgs(AppPanViewEvent.Start, (double)location.X, (double)location.Y));
            }
        }

        public override void TouchesEnded(NSSet touches, UIEvent evt)
        {
            base.TouchesEnded(touches, evt);

            if (_appPanView != null)
            {
                var touch = (touches.AnyObject as UITouch);
                var location = touch.LocationInView(this);
                _appPanView.DoPanEvent(new AppPanViewEventArgs(AppPanViewEvent.Complete, (double)location.X, (double)location.Y));
            }
        }

        public override void TouchesMoved(NSSet touches, UIEvent evt)
        {
            base.TouchesMoved(touches, evt);

            if (_appPanView != null)
            {
                var touch = (touches.AnyObject as UITouch);
                var location = touch.LocationInView(this);
                _appPanView.DoPanEvent(new AppPanViewEventArgs(AppPanViewEvent.Move, (double)location.X, (double)location.Y));
            }
        }

        public override void TouchesCancelled(NSSet touches, UIEvent evt)
        {
            base.TouchesCancelled(touches, evt);

            if (_appPanView != null)
            {
                var touch = (touches.AnyObject as UITouch);
                var location = touch.LocationInView(this);
                _appPanView.DoPanEvent(new AppPanViewEventArgs(AppPanViewEvent.Complete, (double)location.X, (double)location.Y));
            }
        }
    }
    #endregion
}