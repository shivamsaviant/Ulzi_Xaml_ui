using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppDatePickerEditor
    public class AppDatePickerEditor : ContentView
    {
        #region Static members
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(AppDatePickerEditor), Color.Black);
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppDatePickerEditor), AppFonts.Quicksand);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppDatePickerEditor), Entry.FontSizeProperty.DefaultValue);
        public static readonly BindableProperty LineColorProperty = BindableProperty.Create("LineColor", typeof(Color), typeof(AppDatePickerEditor), Color.White);
        public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.Create("HorizontalTextAlignment", typeof(TextAlignment), typeof(AppDatePickerEditor), TextAlignment.Start, BindingMode.OneWay);
        public static readonly BindableProperty DateProperty = BindableProperty.Create("Date", typeof(DateTime), typeof(AppDatePickerEditor), DateTime.Today.AddYears(15));
        #endregion

        private AppDatePicker _picker = null;

        public AppDatePickerEditor() : base()
        {
            _picker = new AppDatePicker
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.End
            };
            _picker.SetBinding(AppDatePicker.TextColorProperty, new Binding(TextColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _picker.SetBinding(AppDatePicker.AppFontProperty, new Binding(AppFontProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _picker.SetBinding(AppDatePicker.FontSizeProperty, new Binding(FontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _picker.SetBinding(AppDatePicker.HorizontalTextAlignmentProperty, new Binding(HorizontalTextAlignmentProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _picker.SetBinding(AppDatePicker.DateProperty, new Binding(DateProperty.PropertyName, BindingMode.TwoWay, null, null, null, this));

            _picker.Completed += (sender, args) => {
                this.DoCompleted();
            };

            var line = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };
            line.SetBinding(ContentView.BackgroundColorProperty, new Binding(LineColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 10,
                ColumnSpacing = 0,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Absolute) }
                }
            };
            grid.Children.Add(_picker, 0, 0);
            grid.Children.Add(line, 0, 1);

            var touchGesture = new TapGestureRecognizer();
            touchGesture.Tapped += (sender, args) => {
                _picker.Focus();
            };
            this.GestureRecognizers.Add(touchGesture);

            this.Content = grid;
        }

        public bool SetFocus()
        {
            return _picker.Focus();
        }

        private void DoCompleted()
        {
            if (this.Completed != null)
                this.Completed(this, EventArgs.Empty);
        }

        public Color TextColor
        {
            get { return (Color)this.GetValue(TextColorProperty); }
            set { this.SetValue(TextColorProperty, value); }
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

        public Color LineColor
        {
            get { return (Color)this.GetValue(LineColorProperty); }
            set { this.SetValue(LineColorProperty, value); }
        }

        public TextAlignment HorizontalTextAlignment
        {
            get { return (TextAlignment)this.GetValue(HorizontalTextAlignmentProperty); }
            set { this.SetValue(HorizontalTextAlignmentProperty, value); }
        }

        public DateTime Date
        {
            get { return (DateTime)this.GetValue(DateProperty); }
            set { this.SetValue(DateProperty, value); }
        }

        public event EventHandler Completed;
    }
    #endregion
}
