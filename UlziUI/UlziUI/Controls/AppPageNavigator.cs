using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes.Converters;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppPageNavigator
    public class AppPageNavigator : ContentView
    {
        #region Static members
        public static readonly BindableProperty CountProperty = BindableProperty.Create("Count", typeof(int), typeof(AppPageNavigator), (int)6);
        public static readonly BindableProperty SelectedIndexProperty = BindableProperty.Create("SelectedIndex", typeof(int), typeof(AppPageNavigator), 0);
        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create("ImageSourse", typeof(string), typeof(AppPageNavigator), "page_dot_gray");
        public static readonly BindableProperty SelectedImageSourseProperty = BindableProperty.Create("SelectedImageSourse", typeof(string), typeof(AppPageNavigator), "page_dot_green");
        public static readonly BindableProperty DotSizeProperty = BindableProperty.Create("DotSize", typeof(double), typeof(AppPageNavigator), (double)20);
        public static readonly BindableProperty SpacingProperty = BindableProperty.Create("Spacing", typeof(double), typeof(AppPageNavigator), (double)20);
        #endregion

        private IndexToImageConverter _imageToIndexConverter = new IndexToImageConverter("page_dot_green", "page_dot_gray");

        public AppPageNavigator() : base()
        {
            this.Content = this.CreateContent();
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if ((propertyName == CountProperty.PropertyName) ||
                (propertyName == SelectedIndexProperty.PropertyName))
                this.Content = this.CreateContent();
        }

        private View CreateContent()
        {
            var content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                Orientation = StackOrientation.Horizontal
            };
            content.SetBinding(StackLayout.SpacingProperty, new Binding(SpacingProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            for (int index = 0; index < this.Count; index++)
                content.Children.Add(this.CreateDot(index));

            return content;
        }

        private View CreateDot(int index)
        {
            var image = new Image
            {
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start
            };
            image.SetBinding(Image.SourceProperty, new Binding(SelectedIndexProperty.PropertyName, BindingMode.OneWay, _imageToIndexConverter, index, null, this));
            image.SetBinding(Image.HeightRequestProperty, new Binding(DotSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            image.SetBinding(Image.WidthRequestProperty, new Binding(DotSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            return image;
        }

        public int Count
        {
            get { return (int)this.GetValue(CountProperty); }
            set { this.SetValue(CountProperty, value); }
        }

        public int SelectedIndex
        {
            get { return (int)this.GetValue(SelectedIndexProperty); }
            set { this.SetValue(SelectedIndexProperty, value); }
        }

        public string ImageSource
        {
            get { return (string)this.GetValue(ImageSourceProperty); }
            set { this.SetValue(ImageSourceProperty, value); }
        }

        public string SelectedImageSource
        {
            get { return (string)this.GetValue(SelectedImageSourseProperty); }
            set { this.SetValue(SelectedImageSourseProperty, value); }
        }

        public double DotSize
        {
            get { return (double)this.GetValue(DotSizeProperty); }
            set { this.SetValue(DotSizeProperty, value); }
        }

        public double Spacing
        {
            get { return (double)this.GetValue(SpacingProperty); }
            set { this.SetValue(SpacingProperty, value); }
        }
    }
    #endregion
}
