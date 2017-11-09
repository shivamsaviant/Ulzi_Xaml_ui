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

[assembly: ExportRenderer(typeof(AppButton), typeof(AppButtonRenderer))]
namespace UlziUI.iOS.Renderers
{
    #region AppButtonRenderer
    public class AppButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> args)
        {
            base.OnElementChanged(args);
            //Cakesoft Fixed SB - 44
            Control.TitleLabel.LineBreakMode = UILineBreakMode.WordWrap;
            // BS=
            Control.TitleLabel.TextAlignment = UITextAlignment.Center;
            this.SetBackground();
            this.SetAppFont();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            if (args.PropertyName == AppButton.AppFontProperty.PropertyName)
                this.SetAppFont();
            else if (args.PropertyName == AppButton.AppButtonStyleProperty.PropertyName)
                this.SetBackground();
        }

        private void SetBackground()
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
}