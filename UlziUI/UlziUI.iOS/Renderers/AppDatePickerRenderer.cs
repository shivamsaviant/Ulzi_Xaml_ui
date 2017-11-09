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

[assembly: ExportRenderer(typeof(AppDatePicker), typeof(AppDatePickerRenderer))]
namespace UlziUI.iOS.Renderers
{
    #region AppDatePickerRenderer
    public class AppDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> args)
        {
            base.OnElementChanged(args);

            if (this.Control != null)
            {
                this.Control.BorderStyle = UITextBorderStyle.None;

                this.SetAppFont();
                this.SetFontSize();
                this.SetHorizontalTextAlignment();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            if (args.PropertyName == AppDatePicker.AppFontProperty.PropertyName)
                this.SetAppFont();
            else if (args.PropertyName == AppDatePicker.FontSizeProperty.PropertyName)
                this.SetFontSize();
            else if (args.PropertyName == AppDatePicker.HorizontalTextAlignmentProperty.PropertyName)
                this.SetHorizontalTextAlignment();
        }

        private void SetAppFont()
        {
            var element = (this.Element as AppDatePicker);

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

        private void SetFontSize()
        {
            var view = (this.Element as AppDatePicker);

            if (view != null)
                this.Control.Font.WithSize((nfloat)view.FontSize);
        }

        private void SetHorizontalTextAlignment()
        {
            var view = (this.Element as AppDatePicker);

            if (view != null)
            {
                var textAlignment = UITextAlignment.Left;
                if (view.HorizontalTextAlignment == Xamarin.Forms.TextAlignment.Center)
                    textAlignment = UITextAlignment.Center;
                else if (view.HorizontalTextAlignment == Xamarin.Forms.TextAlignment.End)
                    textAlignment = UITextAlignment.Right;

                this.Control.TextAlignment = textAlignment;
            }
        }
    }
    #endregion
}