using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    /// <summary>
    /// This is the Horizontal button
    /// </summary>
    public partial class AppHorizontalButton : ContentView
    {
        #region Static members
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(AppHorizontalButton), "");
        public static readonly BindableProperty ImageProperty = BindableProperty.Create("Image", typeof(string), typeof(AppHorizontalButton), "");
        public static readonly BindableProperty BorderWidthProperty = BindableProperty.Create("BorderWidth", typeof(double), typeof(AppHorizontalButton), 0.0);

        #endregion

        public string Text
        {
            get { return (string)this.GetValue(TextProperty); }
            set
            {
                this.SetValue(TextProperty, value);
                ButtonText.Text = value;
            }
        }

        public double BorderWidth
        {
            get { return (double)this.GetValue(BorderWidthProperty); }
            set
            {
                this.SetValue(BorderWidthProperty, value);
                ButtonImage.StrokeWidth = value;
            }
        }

        public string Image
        {
            get { return (string)this.GetValue(ImageProperty); }
            set
            {
                this.SetValue(ImageProperty, value);
                ButtonImage.Source = value;
            }
        }
        
        public AppHorizontalButton()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            this.SetBinding(AppHorizontalButton.TextProperty, "Text", BindingMode.OneWay);
            this.SetBinding(AppHorizontalButton.ImageProperty, "Image", BindingMode.OneWay);
            this.SetBinding(AppHorizontalButton.BorderWidthProperty, "BorderWidth", BindingMode.OneWay);
        }
    }
}
