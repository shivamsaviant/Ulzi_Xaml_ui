using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppPicker
    public class AppPicker : Picker
    {
        #region Static members
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppPicker), AppFonts.Quicksand);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppPicker), Device.GetNamedSize(NamedSize.Small, typeof(Label)), BindingMode.OneWay);
        public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.Create("HorizontalTextAlignment", typeof(TextAlignment), typeof(AppPicker), TextAlignment.Start, BindingMode.OneWay);
        #endregion

        public AppPicker() : base()
        {
            this.SelectedIndexChanged += (sender, args) => {
                object selectedItem = null;
                if (this.SelectedIndex >= 0)
                    selectedItem = this.ItemsSource[this.SelectedIndex];
                this.SelectedItem = selectedItem;
            };
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName == IsFocusedProperty.PropertyName)
                if (!this.IsFocused)
                    this.DoCompleted();

            base.OnPropertyChanged(propertyName);
        }

        public void DoCompleted()
        {
            if (this.Completed != null)
                this.Completed(this, EventArgs.Empty);
        }

        private void FillItems()
        {
            this.Items.Clear();
            if (this.ItemsSource != null)
            {
                foreach (object item in this.ItemsSource)
                    this.Items.Add(item.ToString());
                this.SelectItem();
            }
        }

        private void SelectItem()
        {
            int newIndex = -1;
            if ((this.ItemsSource != null) && (this.SelectedItem != null))
                newIndex = this.ItemsSource.IndexOf(this.SelectedItem);
            this.SelectedIndex = newIndex;
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
