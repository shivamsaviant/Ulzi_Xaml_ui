using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppDatePicker
    public class AppDatePicker : DatePicker
    {
        #region Static members
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppDatePicker), AppFonts.Quicksand, BindingMode.OneWay);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppDatePicker), Device.GetNamedSize(NamedSize.Small, typeof(Label)), BindingMode.OneWay);
        public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.Create("HorizontalTextAlignment", typeof(TextAlignment), typeof(AppDatePicker), TextAlignment.Start, BindingMode.OneWay);
        #endregion

        public AppDatePicker() : base()
        {
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == IsFocusedProperty.PropertyName)
                if (!this.IsFocused)
                    this.DoCompleted();
        }

        private void DoCompleted()
        {
            if (this.Completed != null)
                this.Completed(this, EventArgs.Empty);
        }

        public AppFonts AppFont
        {
            get { return (AppFonts)this.GetValue(AppFontProperty); }
            set { this.SetValue(AppFontProperty, value); }
        }

        public double FontSize
        {
            get { return (double)this.GetValue(FontSizeProperty); }
            set { this.SetValue(FontSizeProperty, value); }
        }

        public TextAlignment HorizontalTextAlignment
        {
            get { return (TextAlignment)this.GetValue(HorizontalTextAlignmentProperty); }
            set { this.SetValue(HorizontalTextAlignmentProperty, value); }
        }

        public event EventHandler Completed;
    }
    #endregion
}
