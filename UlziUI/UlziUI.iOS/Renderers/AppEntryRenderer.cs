using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using System.ComponentModel;
using UlziUI.Controls;
using UlziUI.Classes.Enums;
using UlziUI.iOS.Renderers;

[assembly: ExportRenderer(typeof(AppEntry), typeof(AppEntryRenderer))]
[assembly: ExportRenderer(typeof(AppEntryCapitalization), typeof(AppEntryFullNameRenderer))]
namespace UlziUI.iOS.Renderers
{
    #region AppEntryRenderer
    public class AppEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> args)
        {
            base.OnElementChanged(args);

            if (this.Control != null)
            {
                this.Control.BorderStyle = UITextBorderStyle.None;
                this.Control.ReturnKeyType = UIReturnKeyType.Done;
                this.SetAppFont();
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

            if (element != null)
            {
                string path = "";
                if (element.AppFont == AppFonts.Quicksand)
                    path = "Quicksand-Regular";

                if (!String.IsNullOrEmpty(path))
                {
                    var font = UIFont.FromName(path, (nfloat)element.FontSize);
                    if (font != null)
                        this.Control.Font = font;
                }
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
                this.Control.BorderStyle = UITextBorderStyle.None;
                this.Control.ReturnKeyType = UIReturnKeyType.Done;
                this.Control.AutocapitalizationType = UITextAutocapitalizationType.Words;
                this.SetAppFont();
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
                path = "Quicksand-Regular";

            if (!String.IsNullOrEmpty(path))
            {
                var font = UIFont.FromName(path, (nfloat)element.FontSize);
                if (font != null)
                    this.Control.Font = font;
            }
        }
    }
    #endregion
}