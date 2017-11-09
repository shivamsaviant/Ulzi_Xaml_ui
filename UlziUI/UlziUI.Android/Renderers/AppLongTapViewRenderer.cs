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

[assembly: ExportRenderer(typeof(AppLongTapView), typeof(AppLongTapViewRenderer))]
namespace UlziUI.Droid.Renderers
{
    #region AppLongTapViewRenderer
    public class AppLongTapViewRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> args)
        {
            base.OnElementChanged(args);

            this.LongClick += ViewLongClick;
        }

        private void ViewLongClick(object sender, LongClickEventArgs args)
        {
            var element = (this.Element as AppLongTapView);
            if ((element.Command != null) && (element.Command.CanExecute(element.CommandParameter)))
                element.Command.Execute(element.CommandParameter);
        }
    }
    #endregion
}