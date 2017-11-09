using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppButton
    public class AppButton : Button
    {
        #region Static members
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppButton), AppFonts.Quicksand);
        public static readonly BindableProperty AppButtonStyleProperty = BindableProperty.Create("AppButtonStyle", typeof(AppButtonStyles), typeof(AppButton), AppButtonStyles.Silver);
        #endregion

        public AppButton() : base()
        {
            this.BorderRadius = 8;
            this.BorderWidth = 1;
            this.TextColor = Color.White;

            this.SetButtonStyle();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == AppButtonStyleProperty.PropertyName)
                this.SetButtonStyle();
        }

        private void SetButtonStyle()
        {
            var color = Color.FromHex("#1BA4A8");
            var borderColor = Color.FromHex("#1BA4A8");

            if (this.AppButtonStyle == AppButtonStyles.Gold)
            {
                color = Color.FromHex("#1BA4A8");
                borderColor = Color.FromHex("#1BA4A8");
            }
            else if (this.AppButtonStyle == AppButtonStyles.Silver)
            {
                color = Color.FromHex("#5FC5B6");
                borderColor = Color.FromHex("#5FC5B6");
            }
            else if (this.AppButtonStyle == AppButtonStyles.Free)
            {
                color = Color.FromHex("#A4AAB3");
                borderColor = Color.FromHex("#A4AAB3");
            }
            else if (this.AppButtonStyle == AppButtonStyles.Facebook)
            {
                color = Color.FromHex("#3B5998");
                borderColor = Color.FromHex("#3B5998");
            }
            else if (this.AppButtonStyle == AppButtonStyles.Gray)
            {
                color = Color.FromHex("#C7C7CD");
                borderColor = Color.FromHex("#C7C7CD");
            }
            else if (this.AppButtonStyle == AppButtonStyles.TransparentRed)
            {
                color = Color.FromRgba(229, 112, 106, 128);
                borderColor = Color.FromHex("#C7C7CD");
            }

            this.BorderColor = color;
            this.BackgroundColor = color;
        }

        public AppFonts AppFont
        {
            get { return (AppFonts)this.GetValue(AppFontProperty); }
            set { this.SetValue(AppFontProperty, value); }
        }

        public AppButtonStyles AppButtonStyle
        {
            get { return (AppButtonStyles)this.GetValue(AppButtonStyleProperty); }
            set { this.SetValue(AppButtonStyleProperty, value); }
        }
    }
    #endregion
}
