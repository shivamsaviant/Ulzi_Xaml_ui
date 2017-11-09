using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppEditor
    public class AppEditor : Editor
    {
        #region Static members
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppEditor), AppFonts.Quicksand);
        public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create("Placeholder", typeof(string), typeof(AppEditor), default(string));
        public static readonly BindableProperty PlaceholderColorProperty = BindableProperty.Create("PlaceholderColor", typeof(Color), typeof(AppEditor), Color.Gray);
        #endregion

        public AppEditor() : base()
        {
        }

        public AppFonts AppFont
        {
            get { return (AppFonts)this.GetValue(AppFontProperty); }
            set { this.SetValue(AppFontProperty, value); }
        }

        public string Placeholder
        {
            get { return (string)this.GetValue(PlaceholderProperty); }
            set { this.SetValue(PlaceholderProperty, value); }
        }

        public Color PlaceholderColor
        {
            get { return (Color)this.GetValue(PlaceholderColorProperty); }
            set { this.SetValue(PlaceholderColorProperty, value); }
        }
    }
    #endregion
}
