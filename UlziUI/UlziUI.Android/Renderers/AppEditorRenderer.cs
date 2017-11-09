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

[assembly: ExportRenderer(typeof(AppEditor), typeof(AppEditorRenderer))]
namespace UlziUI.Droid.Renderers
{
    #region AppEditorRenderer
    public class AppEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> args)
        {
            base.OnElementChanged(args);

            if (this.Control != null)
            {
                this.Control.SetBackgroundResource(Resource.Drawable.appentry_data);
                this.SetAppFont();
                this.SetPlaceholder();
                this.SetPlaceholderColor();
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

            if (args.PropertyName == AppEditor.AppFontProperty.PropertyName)
                this.SetAppFont();
            else if (args.PropertyName == AppEditor.PlaceholderProperty.PropertyName)
                this.SetPlaceholder();
            else if (args.PropertyName == AppEditor.PlaceholderColorProperty.PropertyName)
                this.SetPlaceholderColor();
        }

        private void SetAppFont()
        {
            var element = (this.Element as AppEditor);

            string path = "";
            if (element.AppFont == AppFonts.Quicksand)
                path = "Fonts/Quicksand-Regular.ttf";

            if (!String.IsNullOrEmpty(path))
            {
                Typeface typeFace = Typeface.CreateFromAsset(this.Context.Assets, path);
                this.Control.Typeface = typeFace;
            }
        }

        private void SetPlaceholder()
        {
            var element = (this.Element as AppEditor);

            if ((this.Control != null) && (element != null))
                this.Control.Hint = element.Placeholder;
        }

        private void SetPlaceholderColor()
        {
            var element = (this.Element as AppEditor);

            if ((this.Control != null) && (element != null))
                this.Control.SetHintTextColor(element.PlaceholderColor.ToAndroid());
        }
    }
    #endregion
}