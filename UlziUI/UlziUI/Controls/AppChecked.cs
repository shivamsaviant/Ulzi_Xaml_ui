using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppChecked
    public class AppChecked : ContentView
    {
        #region Static members
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create("IsChecked", typeof(bool), typeof(AppChecked), default(bool));
        public static readonly BindableProperty CheckedImageSourceProperty = BindableProperty.Create("CheckedImageSource", typeof(string), typeof(AppChecked), "checked_green");
        public static readonly BindableProperty UncheckedImageSourceProperty = BindableProperty.Create("UncheckedImageSource", typeof(string), typeof(AppChecked), "unchecked");
        public static readonly BindableProperty ImageSizeProperty = BindableProperty.Create("ImageSize", typeof(double), typeof(AppChecked), (double)22);
        #endregion

        public AppChecked() : base()
        {
            var empty = new Image
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
            };
            empty.SetBinding(Image.SourceProperty, new Binding(UncheckedImageSourceProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            empty.SetBinding(Image.HeightRequestProperty, new Binding(ImageSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            empty.SetBinding(Image.WidthRequestProperty, new Binding(ImageSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var check = new Image
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Source = "checked_green"
            };
            check.SetBinding(Image.SourceProperty, new Binding(CheckedImageSourceProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            check.SetBinding(Image.HeightRequestProperty, new Binding(ImageSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            check.SetBinding(Image.WidthRequestProperty, new Binding(ImageSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            check.SetBinding(Image.IsVisibleProperty, new Binding("IsChecked", BindingMode.OneWay, null, null, null, this));

            var touch = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };

            var touchGesture = new TapGestureRecognizer();
            touchGesture.Tapped += (sender, args) =>
            {
                this.IsChecked = !this.IsChecked;
            };
            touch.GestureRecognizers.Add(touchGesture);

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 0,
                ColumnSpacing = 0
            };
            grid.Children.Add(empty);
            grid.Children.Add(check);
            grid.Children.Add(touch);

            this.Content = grid;
        }

        public bool IsChecked
        {
            get { return (bool)this.GetValue(IsCheckedProperty); }
            set { this.SetValue(IsCheckedProperty, value); }
        }

        public string CheckedImageSource
        {
            get { return (string)this.GetValue(CheckedImageSourceProperty); }
            set { this.SetValue(CheckedImageSourceProperty, value); }
        }

        public string UncheckedImageSource
        {
            get { return (string)this.GetValue(UncheckedImageSourceProperty); }
            set { this.SetValue(UncheckedImageSourceProperty, value); }
        }

        public double ImageSize
        {
            get { return (double)this.GetValue(ImageSizeProperty); }
            set { this.SetValue(ImageSizeProperty, value); }
        }
    }
    #endregion
}
