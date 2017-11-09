using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppEntry
    public class AppEntry : Entry
    {
        #region Static members
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppEntry), AppFonts.Quicksand);
        #endregion

        public AppEntry() : base()
        {
        }

        public AppFonts AppFont
        {
            get { return (AppFonts)this.GetValue(AppFontProperty); }
            set { this.SetValue(AppFontProperty, value); }
        }
    }
    #endregion
}
