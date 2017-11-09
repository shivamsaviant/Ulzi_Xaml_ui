using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppTripCommand
    public class AppTripCommand : ContentView
    {
        #region Static member
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(AppTripCommand), default(string));
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(AppTripCommand), Color.White);
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppTripCommand), AppFonts.Quicksand);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppTripCommand), Label.FontSizeProperty.DefaultValue);
        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create("ImageSource", typeof(string), typeof(AppTripCommand), default(string));
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(AppTripCommand), null);
        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(AppTripCommand), null);
        #endregion

        public AppTripCommand() : base()
        {
            var image = new Image
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };
            image.SetBinding(Image.SourceProperty, new Binding("ImageSource", BindingMode.OneWay, null, null, null, this));

            var text = new AppLabel
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.End,
                HorizontalTextAlignment = TextAlignment.Center
            };
            text.SetBinding(AppLabel.TextProperty, new Binding(TextProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            text.SetBinding(AppLabel.TextColorProperty, new Binding(TextColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            text.SetBinding(AppLabel.AppFontProperty, new Binding(AppFontProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            text.SetBinding(AppLabel.FontSizeProperty, new Binding(FontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var textContent = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.End,
                Padding = new Thickness(0, 0, 0, 8),
                Content = text
            };

            var touch = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };

            var touchGesture = new TapGestureRecognizer();
            touchGesture.Tapped += (sender, args) => {
                if ((this.Command != null) && (this.Command.CanExecute(this.CommandParameter)))
                {
                    this.FadeTo(0.6);
                    this.FadeTo(1);
                    this.Command.Execute(this.CommandParameter);
                }
            };
            touch.GestureRecognizers.Add(touchGesture);

            var content = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 0,
                ColumnSpacing = 0
            };
            content.Children.Add(image);
            content.Children.Add(textContent);
            content.Children.Add(touch);

            this.Content = content;
        }

        public string Text
        {
            get { return (string)this.GetValue(TextProperty); }
            set { this.SetValue(TextProperty, value); }
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

        public string ImageSource
        {
            get { return (string)this.GetValue(ImageSourceProperty); }
            set { this.SetValue(ImageSourceProperty, value); }
        }

        public ICommand Command
        {
            get { return (ICommand)this.GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
        }

        public object CommandParameter
        {
            get { return (object)this.GetValue(CommandParameterProperty); }
            set { this.SetValue(CommandParameterProperty, value); }
        }
    }
    #endregion
}
