using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UlziUI.Classes;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppNumericKeyboard
    public class AppNumericKeyboard : ContentView
    {
        #region Static members
        public static readonly BindableProperty NumberFontSizeProperty = BindableProperty.Create("NumberFontSize", typeof(double), typeof(AppNumericKeyboard), default(double));
        public static readonly BindableProperty CharsFontSizeProperty = BindableProperty.Create("CharsFontSize", typeof(double), typeof(AppNumericKeyboard), default(double));
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(AppNumericKeyboard), default(string));
        public static readonly BindableProperty KeyHeightProperty = BindableProperty.Create("KeyHeight", typeof(double), typeof(AppNumericKeyboard), default(double));
        public static readonly BindableProperty TextLengthProperty = BindableProperty.Create("TextLength", typeof(int), typeof(AppNumericKeyboard), 4);
        #endregion

        public AppNumericKeyboard() : base()
        {
            this.Padding = new Thickness(0, 1, 0, 0);
            this.BackgroundColor = Color.FromHex("#D1D5DB");

            var keyCommand = new VisualCommand(this.Key);
            var backspaceCommand = new VisualCommand(this.Backspace);

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                RowSpacing = 1,
                ColumnSpacing = 1,
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                },
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
                }
            };
            grid.Children.Add(this.CreateKey("1", " ", keyCommand), 0, 0);
            grid.Children.Add(this.CreateKey("2", "ABC", keyCommand), 1, 0);
            grid.Children.Add(this.CreateKey("3", "DEF", keyCommand), 2, 0);
            grid.Children.Add(this.CreateKey("4", "GHI", keyCommand), 0, 1);
            grid.Children.Add(this.CreateKey("5", "JKL", keyCommand), 1, 1);
            grid.Children.Add(this.CreateKey("6", "MNO", keyCommand), 2, 1);
            grid.Children.Add(this.CreateKey("7", "PQRS", keyCommand), 0, 2);
            grid.Children.Add(this.CreateKey("8", "TUV", keyCommand), 1, 2);
            grid.Children.Add(this.CreateKey("9", "WXYZ", keyCommand), 2, 2);
            grid.Children.Add(this.CreateKey("0", "", keyCommand), 1, 3);
            grid.Children.Add(this.CreateBackspace(backspaceCommand), 2, 3);

            this.Content = grid;
        }

        private void Key(object parameter)
        {
            var number = (parameter != null ? parameter.ToString() : "");
            if (!String.IsNullOrEmpty(number))
            {
                var length = (String.IsNullOrEmpty(this.Text) ? 0 : this.Text.Length);
                if (length < this.TextLength)
                    this.Text += number;
            }
        }

        private void Backspace(object parameter)
        {
            if (!String.IsNullOrEmpty(this.Text))
            {
                var length = this.Text.Length;
                if (length > 0)
                    this.Text = this.Text.Substring(0, length - 1);
            }
        }

        private View CreateKey(string number, string chars, ICommand command)
        {
            var key = new AppNumericKeyboardKey
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                Number = number,
                Chars = chars,
                Command = command
            };
            key.SetBinding(AppNumericKeyboardKey.NumberFontSizeProperty, new Binding("NumberFontSize", BindingMode.OneWay, null, null, null, this));
            key.SetBinding(AppNumericKeyboardKey.CharsFontSizeProperty, new Binding("CharsFontSize", BindingMode.OneWay, null, null, null, this));
            key.SetBinding(AppNumericKeyboardKey.HeightRequestProperty, new Binding("KeyHeight", BindingMode.OneWay, null, null, null, this));
            return key;
        }

        private View CreateBackspace(ICommand command)
        {
            var appCommand = new AppCommand
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                ImageSource = "backspace",
                Command = command
            };
            appCommand.SetBinding(AppCommand.HeightRequestProperty, new Binding("KeyHeight", BindingMode.OneWay, null, null, null, this));
            appCommand.SetBinding(AppCommand.ImageSizeProperty, new Binding("NumberFontSize", BindingMode.OneWay, null, null, null, this));
            return appCommand;
        }

        public double NumberFontSize
        {
            get { return (double)this.GetValue(NumberFontSizeProperty); }
            set { this.SetValue(NumberFontSizeProperty, value); }
        }

        public double CharsFontSize
        {
            get { return (double)this.GetValue(CharsFontSizeProperty); }
            set { this.SetValue(CharsFontSizeProperty, value); }
        }

        public string Text
        {
            get { return (string)this.GetValue(TextProperty); }
            set { this.SetValue(TextProperty, value); }
        }

        public double KeyHeight
        {
            get { return (double)this.GetValue(KeyHeightProperty); }
            set { this.SetValue(KeyHeightProperty, value); }
        }

        public int TextLength
        {
            get { return (int)this.GetValue(TextLengthProperty); }
            set { this.SetValue(TextLengthProperty, value); }
        }
    }
    #endregion
}
