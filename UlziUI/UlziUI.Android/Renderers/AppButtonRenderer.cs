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
using System.ComponentModel;
using UlziUI.Controls;
using UlziUI.Classes.Enums;
using Android.Graphics;
using UlziUI.Droid.Renderers;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(AppButton), typeof(AppButtonRenderer))]
namespace UlziUI.Droid.Renderers
{
    #region AppButtonRenderer
    public class AppButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> args)
        {
            base.OnElementChanged(args);

            this.SetBackgroundResource();
            this.SetAppFont();
            this.Control.SetAllCaps(false);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            if (args.PropertyName == AppButton.AppFontProperty.PropertyName)
                this.SetAppFont();
            else if (args.PropertyName == AppButton.AppButtonStyleProperty.PropertyName)
                this.SetBackgroundResource();
        }

        private void SetBackgroundResource()
        {
            var element = (this.Element as AppButton);
        }

        private void SetAppFont()
        {
            var element = (this.Element as AppButton);

            if (element != null)
            {
                string path = "";
                if (element.AppFont == AppFonts.Quicksand)
                    path = "Fonts/Quicksand-Regular.ttf";

                if (!String.IsNullOrEmpty(path))
                {
                    Typeface typeFace = Typeface.CreateFromAsset(this.Context.Assets, path);
                    this.Control.Typeface = typeFace;
                }
            }
        }
    }
    #endregion
}