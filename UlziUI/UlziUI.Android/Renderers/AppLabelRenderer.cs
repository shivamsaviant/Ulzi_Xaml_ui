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
using Android.Text.Util;
using UlziUI.Classes.Enums;
using Android.Graphics;
using Android.Text;
using UlziUI.Droid.Renderers;

[assembly: ExportRenderer(typeof(AppLabel), typeof(AppLabelRenderer))]
namespace UlziUI.Droid.Renderers
{
    #region AppLabelRenderer
    public class AppLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> args)
        {
            base.OnElementChanged(args);

            this.SetAppFont();
            this.SetHtmlText();
            this.SetLines(); // This is for Number of lines to be shown in Label
            this.ClickOnLinks(args);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            if (args.PropertyName == AppLabel.AppFontProperty.PropertyName)
                this.SetAppFont();
            else if (args.PropertyName == AppLabel.TextProperty.PropertyName)
                this.SetAppFont();
            else if (args.PropertyName == AppLabel.HtmlTextProperty.PropertyName)
                this.SetHtmlText();
            else if (args.PropertyName == AppLabel.TextColorProperty.PropertyName)
                this.SetHtmlText();

        }

        private void ClickOnLinks(ElementChangedEventArgs<Label> e) // CakeSoft fixed bug SB-17
        {
            if (e.OldElement == null)
            {
                var nativeEditText = (global::Android.Widget.TextView)Control;
                Linkify.AddLinks(nativeEditText, MatchOptions.WebUrls);
            }
        }

        private void SetLines()
        {
            AppLabel multiLineLabel = (AppLabel)Element;

            if (multiLineLabel != null && multiLineLabel.Lines != -1)
            {
                Control.SetSingleLine(false);
                Control.SetLines(multiLineLabel.Lines);
            }
        }

        private void SetAppFont()
        {
            var element = (this.Element as AppLabel);

            string path = "";
            if (element.AppFont == AppFonts.Quicksand)
            {
                if (element.FontAttributes == FontAttributes.Bold)
                    path = "Fonts/Quicksand-Bold.ttf";
                else
                    path = "Fonts/Quicksand-Regular.ttf";
            }

            if (!String.IsNullOrEmpty(path))
            {
                Typeface typeFace = Typeface.CreateFromAsset(this.Context.Assets, path);
                this.Control.Typeface = typeFace;
            }
        }

        private void SetHtmlText()
        {
            var element = (this.Element as AppLabel);

            var text = element.Text;
            if (!String.IsNullOrEmpty(element.HtmlText))
                text = element.HtmlText;

            if (String.IsNullOrEmpty(text))
                text = "";

            ISpanned spanned = null;
            if ((int)Android.OS.Build.VERSION.SdkInt >= 24)
                spanned = Html.FromHtml(text, FromHtmlOptions.ModeLegacy);
            else
#pragma warning disable CS0618 // Type or member is obsolete
                spanned = Html.FromHtml(text);
#pragma warning restore CS0618 // Type or member is obsolete

            this.Control.TextFormatted = spanned;
        }
    }
    #endregion
}