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

[assembly: ExportRenderer(typeof(AppEditor), typeof(AppEditorRenderer))]
namespace UlziUI.iOS.Renderers
{
    #region AppEditorRenderer
    public class AppEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> args)
        {
            base.OnElementChanged(args);

            if (this.Control != null)
            {
                //                this.Control.BorderStyle = UITextBorderStyle.None;

                NSNotificationCenter.DefaultCenter.AddObserver(UITextView.TextDidBeginEditingNotification, TextChangedEvent);
                NSNotificationCenter.DefaultCenter.AddObserver(UITextView.TextDidEndEditingNotification, TextChangedEvent);

                this.SetAppFont();
                this.SetPlaceholder(this.Control);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(sender, args);

            if (args.PropertyName == AppEditor.AppFontProperty.PropertyName)
                this.SetAppFont();
            else if (args.PropertyName == AppEditor.PlaceholderProperty.PropertyName)
                this.SetPlaceholder(this.Control);
            else if (args.PropertyName == AppEditor.PlaceholderColorProperty.PropertyName)
                this.SetPlaceholder(this.Control);
        }

        private void SetAppFont()
        {
            var element = (this.Element as AppEditor);

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

        private void TextChangedEvent(NSNotification notifcation)
        {
            if (notifcation.Object == this.Control)
            {
                var field = (UITextView)notifcation.Object;
                this.SetPlaceholder(field);
            }
        }

        private void SetPlaceholder(UITextView textView)
        {
            var element = (this.Element as AppEditor);

            if (textView.Text.Equals(element.Placeholder))
            {
                textView.Text = string.Empty;
                textView.TextColor = element.TextColor.ToUIColor();
            }
            else if (string.IsNullOrWhiteSpace(textView.Text))
            {
                textView.TextColor = element.PlaceholderColor.ToUIColor();
                textView.Text = element.Placeholder;
            }
        }
    }
    #endregion
}