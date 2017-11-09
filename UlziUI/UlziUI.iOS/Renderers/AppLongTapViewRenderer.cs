using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UlziUI.Controls;
using UlziUI.iOS.Renderers;

[assembly: ExportRenderer(typeof(AppLongTapView), typeof(AppLongTapViewRenderer))]
namespace UlziUI.iOS.Renderers
{
    #region AppLongTapViewRenderer
    public class AppLongTapViewRenderer : ViewRenderer
    {
        private int _index = 0;
        protected override void OnElementChanged(ElementChangedEventArgs<View> args)
        {
            base.OnElementChanged(args);

            var longPressGestureRecognizer = new UILongPressGestureRecognizer(() => {
                if (_index == 0)
                {
                    var element = (this.Element as AppLongTapView);
                    if ((element.Command != null) && (element.Command.CanExecute(element.CommandParameter)))
                        element.Command.Execute(element.CommandParameter);
                    _index++;
                }
                else
                    _index = 0;
            });

            this.AddGestureRecognizer(longPressGestureRecognizer);
        }
    }
    #endregion
}