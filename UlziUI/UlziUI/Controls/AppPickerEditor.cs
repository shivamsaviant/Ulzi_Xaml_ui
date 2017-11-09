using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppPickerPicker
    public class AppPickerEditor : ContentView
    {
        #region Static members
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(AppPickerEditor), Color.Black);
        public static readonly BindableProperty ErrorTextColorProperty = BindableProperty.Create("ErrorTextColor", typeof(Color), typeof(AppPickerEditor), Color.Red);
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppPickerEditor), AppFonts.Quicksand);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppPickerEditor), Entry.FontSizeProperty.DefaultValue);
        public static readonly BindableProperty LineColorProperty = BindableProperty.Create("LineColor", typeof(Color), typeof(AppPickerEditor), Color.White);
        public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.Create("HorizontalTextAlignment", typeof(TextAlignment), typeof(AppPickerEditor), TextAlignment.Start, BindingMode.OneWay);
        public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create("ItemsSource", typeof(IList), typeof(AppPickerEditor), null, BindingMode.OneWay);
        public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create("SelectedItem", typeof(object), typeof(AppPickerEditor), null, BindingMode.OneWay);
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(AppPickerEditor), default(string), BindingMode.OneWay);
        public static readonly BindableProperty IsErrorProperty = BindableProperty.Create("IsError", typeof(bool), typeof(AppPickerEditor), default(bool));
        #endregion

        private AppPicker _picker = null;

        public AppPickerEditor() : base()
        {
            _picker = new AppPicker
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.End
            };
            _picker.SetBinding(AppPicker.AppFontProperty, new Binding(AppFontProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _picker.SetBinding(AppPicker.FontSizeProperty, new Binding(FontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _picker.SetBinding(AppPicker.HorizontalTextAlignmentProperty, new Binding(HorizontalTextAlignmentProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _picker.SetBinding(AppPicker.ItemsSourceProperty, new Binding(ItemsSourceProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _picker.SetBinding(AppPicker.SelectedItemProperty, new Binding(SelectedItemProperty.PropertyName, BindingMode.TwoWay, null, null, null, this));
            _picker.SetBinding(AppPicker.TitleProperty, new Binding(TitleProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

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

            this.SetColor();

            this.Content = grid;
        }

        public bool SetFocus()
        {
            return _picker.Focus();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == IsErrorProperty.PropertyName)
                this.SetColor();
        }

        private void SetColor()
        {
            _picker.TextColor = (this.IsError ? this.ErrorTextColor : this.TextColor);
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

        public Color ErrorTextColor
        {
            get { return (Color)this.GetValue(ErrorTextColorProperty); }
            set { this.SetValue(ErrorTextColorProperty, value); }
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

        public IList ItemsSource
        {
            get { return (IList)this.GetValue(ItemsSourceProperty); }
            set { this.SetValue(ItemsSourceProperty, value); }
        }

        public object SelectedItem
        {
            get { return this.GetValue(SelectedItemProperty); }
            set { this.SetValue(SelectedItemProperty, value); }
        }

        public string Title
        {
            get { return (string)this.GetValue(TitleProperty); }
            set { this.SetValue(TitleProperty, value); }
        }

        public bool IsError
        {
            get { return (bool)this.GetValue(IsErrorProperty); }
            set { this.SetValue(IsErrorProperty, value); }
        }

        public event EventHandler Completed;
    }
    #endregion
}
