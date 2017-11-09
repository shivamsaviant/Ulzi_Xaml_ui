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
using Xamarin.Forms;
using System.ComponentModel;
using UlziUI.Controls;
using UlziUI.Classes.Enums;
using Android.Graphics;
using UlziUI.Droid.Renderers;

[assembly: ExportRenderer(typeof(AppEntry), typeof(AppEntryRenderer))]
[assembly: ExportRenderer(typeof(AppEntryCapitalization), typeof(AppEntryFullNameRenderer))]
namespace UlziUI.Droid.Renderers
{
    #region AppEntryRenderer
    public class AppEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> args)
        {
            base.OnElementChanged(args);

            if (this.Control != null)
            {
                this.Control.SetBackgroundResource(Resource.Drawable.appentry_data);
                this.SetAppFont();
            }

            if (args.OldElement == null)
            {
                var nativeEditText = (global::Android.Widget.EditText)Control;
                nativeEditText.SetSelectAllOnFocus(true);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            if (args.PropertyName == AppEntry.AppFontProperty.PropertyName)
                this.SetAppFont();
        }

        private void SetAppFont()
        {
            var element = (this.Element as AppEntry);

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
    #endregion

    #region AppEntryFullNameRenderer
    public class AppEntryFullNameRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> args)
        {
            base.OnElementChanged(args);

            if (this.Control != null)
            {
                this.Control.SetBackgroundResource(Resource.Drawable.appentry_data);
                this.Control.InputType = Android.Text.InputTypes.TextFlagCapWords;
                this.SetAppFont();
            }

            if (args.OldElement == null)
            {
                var nativeEditText = (global::Android.Widget.EditText)Control;
                nativeEditText.SetSelectAllOnFocus(true);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            if (args.PropertyName == AppEntryCapitalization.AppFontProperty.PropertyName)
                this.SetAppFont();
        }

        private void SetAppFont()
        {
            var element = (this.Element as AppEntryCapitalization);

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
    #endregion
}