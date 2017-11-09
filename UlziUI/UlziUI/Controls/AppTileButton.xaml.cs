using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    /// <summary>
    /// This is a tile button used for the contact list
    /// </summary>
    public partial class AppTileButton : ContentView
    {

        #region Static members
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(AppTileButton), "");
        public static readonly BindableProperty ImageProperty = BindableProperty.Create("Image", typeof(string), typeof(AppTileButton), "");
        #endregion

        public string Text
        {
            get { return (string)this.GetValue(TextProperty); }
            set { this.SetValue(TextProperty, value);
                ButtonText.Text = value;
            }
        }

        public string Image
        {
            get { return (string)this.GetValue(ImageProperty); }
            set { this.SetValue(ImageProperty, value);
                ButtonImage.Source = value;
            }
        }

        public AppTileButton()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            this.SetBinding(AppTileButton.TextProperty, "Text", BindingMode.OneWay);
            this.SetBinding(AppTileButton.ImageProperty, "Image", BindingMode.OneWay);
        }
    }
}
