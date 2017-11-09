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

[assembly: ExportRenderer(typeof(AppLabel), typeof(AppLabelRenderer))]
namespace UlziUI.iOS.Renderers
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
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            if (args.PropertyName == AppLabel.AppFontProperty.PropertyName)
                this.SetAppFont();
            else if (args.PropertyName == AppLabel.FontSizeProperty.PropertyName)
                this.SetAppFont();
            else if (args.PropertyName == AppLabel.TextProperty.PropertyName)
                this.SetAppFont();
            else if (args.PropertyName == AppLabel.HtmlTextProperty.PropertyName)
                this.SetHtmlText();
            else if (args.PropertyName == AppLabel.TextColorProperty.PropertyName)
                this.SetHtmlText();
            else if (args.PropertyName == AppLabel.FontAttributesProperty.PropertyName)
                this.SetAppFont();
        }

        private void SetAppFont()
        {
            var element = (this.Element as AppLabel);
            if (element != null)
            {
                string path = "";
                if (element.AppFont == AppFonts.Quicksand)
                {
                    if (element.FontAttributes == FontAttributes.Bold)
                        path = "Quicksand-Bold";
                    else
                        path = "Quicksand-Regular";
                }

                if (!String.IsNullOrEmpty(path))
                {
                    var font = UIFont.FromName(path, (nfloat)element.FontSize);
                    if (font != null)
                        this.Control.Font = font;
                }
            }

            this.SetHtmlText();
        }

        private void SetLines()
        {
            AppLabel multiLineLabel = (AppLabel)Element;
            if (multiLineLabel != null && multiLineLabel.Lines != -1)
                Control.Lines = multiLineLabel.Lines;
        }

        private void SetHtmlText()
        {
            var element = (this.Element as AppLabel);

            if ((element != null) && (!String.IsNullOrEmpty(element.HtmlText)))
            {
                try
                {
                    var attr = new NSAttributedStringDocumentAttributes();
                    var nsError = new NSError();
                    attr.DocumentType = NSDocumentType.HTML;

                    nfloat r, g, b, a;
                    var elementColor = element.TextColor.ToUIColor();
                    elementColor.GetRGBA(out r, out g, out b, out a);
                    var textColor = string.Format("#{0:X2}{1:X2}{2:X2}", (int)(r * 255.0), (int)(g * 255.0), (int)(b * 255.0));

                    var html = element.HtmlText + String.Format("<style>body{{font-family: '{0}'; font-size:{1}px; color:{2}}}</style>", this.Control.Font.Name, this.Control.Font.PointSize, textColor);

                    var myHtmlData = NSData.FromString(html, NSStringEncoding.Unicode);

                    var attributedString = new NSAttributedString(myHtmlData, attr, ref nsError);

                    this.Control.AttributedText = attributedString;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
    #endregion
}