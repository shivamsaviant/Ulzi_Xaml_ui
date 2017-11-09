using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppNumericKeyboardKey
    public class AppNumericKeyboardKey : ContentView
    {
        #region Static members
        public static readonly BindableProperty NumberProperty = BindableProperty.Create("Number", typeof(string), typeof(AppNumericKeyboardKey), default(string));
        public static readonly BindableProperty CharsProperty = BindableProperty.Create("Chars", typeof(string), typeof(AppNumericKeyboardKey), default(string));
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(AppNumericKeyboardKey), null);
        public static readonly BindableProperty NumberFontSizeProperty = BindableProperty.Create("NumberFontSize", typeof(double), typeof(AppNumericKeyboardKey), default(double));
        public static readonly BindableProperty CharsFontSizeProperty = BindableProperty.Create("CharsFontSize", typeof(double), typeof(AppNumericKeyboardKey), default(double));
        #endregion

        private Label _chars = null;

        public AppNumericKeyboardKey() : base()
        {
            this.BackgroundColor = Color.White;

            var number = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#030303")
            };
            number.SetBinding(Label.TextProperty, new Binding("Number", BindingMode.OneWay, null, null, null, this));
            number.SetBinding(Label.FontSizeProperty, new Binding("NumberFontSize", BindingMode.OneWay, null, null, null, this));

            _chars = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#030303")
            };
            _chars.SetBinding(Label.TextProperty, new Binding("Chars", BindingMode.OneWay, null, null, null, this));
            _chars.SetBinding(Label.FontSizeProperty, new Binding("CharsFontSize", BindingMode.OneWay, null, null, null, this));

            var stack = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Vertical,
                Spacing = 0
            };
            stack.Children.Add(number);
            stack.Children.Add(_chars);

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 0,
                ColumnSpacing = 0
            };
            grid.Children.Add(stack);

            var touchGesture = new TapGestureRecognizer();
            touchGesture.Tapped += async (sender, args) =>
            {
                if ((this.Command != null) && (this.Command.CanExecute(this.Number)))
                {
                    //this.FadeTo(0.6);
                    //this.FadeTo(1);
                    grid.BackgroundColor = Color.LightGray;   // CakeSoft fixed bug SB-77
                    this.Command.Execute(this.Number);
                }
                await Task.Delay(100);
                grid.BackgroundColor = Color.White;
            };
            grid.GestureRecognizers.Add(touchGesture);

            this.Content = grid;

            this.SetCharsVisible();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == CharsProperty.PropertyName)
                this.SetCharsVisible();
        }

        private void SetCharsVisible()
        {
            _chars.IsVisible = !String.IsNullOrEmpty(this.Chars);
        }

        public string Number
        {
            get { return (string)this.GetValue(NumberProperty); }
            set { this.SetValue(NumberProperty, value); }
        }

        public string Chars
        {
            get { return (string)this.GetValue(CharsProperty); }
            set { this.SetValue(CharsProperty, value); }
        }

        public ICommand Command
        {
            get { return (ICommand)this.GetValue(CommandProperty); }
            set { this.SetValue(CommandProperty, value); }
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
    }
    #endregion
}
