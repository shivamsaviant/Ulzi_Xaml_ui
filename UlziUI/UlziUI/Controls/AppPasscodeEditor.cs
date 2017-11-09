using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UlziUI.Classes.Converters;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppPasscodeEditor
    public class AppPasscodeEditor : ContentView
    {
        #region Static member
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(AppPasscodeEditor), default(string));
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(AppPasscodeEditor), Color.FromHex("#9B9B9B"));
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppPasscodeEditor), AppFonts.Quicksand);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppPasscodeEditor), Device.GetNamedSize(NamedSize.Medium, typeof(Label)));
        public static readonly BindableProperty CellWidthProperty = BindableProperty.Create("CellWidth", typeof(double), typeof(AppPasscodeEditor), (double)48);
        public static readonly BindableProperty CellSpacingProperty = BindableProperty.Create("CellSpacing", typeof(double), typeof(AppPasscodeEditor), (double)16);
        public static readonly BindableProperty PasscodeColorProperty = BindableProperty.Create("PasscodeColor", typeof(AppPasscodeColors), typeof(AppPasscodeEditor), AppPasscodeColors.Gray);
        public static readonly BindableProperty IsLinesVisibleProperty = BindableProperty.Create("IsLinesVisible", typeof(bool), typeof(AppPasscodeEditor), true);
        public static readonly BindableProperty IsLongProperty = BindableProperty.Create("IsLong", typeof(bool), typeof(AppPasscodeEditor), false);
        public static readonly BindableProperty LineColorProperty = BindableProperty.Create("LineColor", typeof(Color), typeof(AppPasscodeEditor), Color.FromHex("#9B9B9B"));
        public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create("IsPassword", typeof(bool), typeof(AppPasscodeEditor), true);
        #endregion

        private StringIndexValueConverter _stringIndexValueConverter = new StringIndexValueConverter();

        private Grid _grid = null;

        private Image _firstCharImage = null;
        private Image _secondCharImage = null;
        private Image _thirdCharImage = null;
        private Image _fourthCharImage = null;
        private Image _fifthCharImage = null;
        private Image _sixthCharImage = null;

        private Label _firstCharLabel = null;
        private Label _secondCharLabel = null;
        private Label _thirdCharLabel = null;
        private Label _fourthCharLabel = null;
        private Label _fifthCharLabel = null;
        private Label _sixthCharLabel = null;

        private View _firstLine = null;
        private View _secondLine = null;
        private View _thirdLine = null;
        private View _fourthLine = null;
        private View _fifthLine = null;
        private View _sixthLine = null;

        public AppPasscodeEditor() : base()
        {
            _firstCharImage = this.CreateChar();
            _secondCharImage = this.CreateChar();
            _thirdCharImage = this.CreateChar();
            _fourthCharImage = this.CreateChar();
            _fifthCharImage = this.CreateChar();
            _sixthCharImage = this.CreateChar();

            _firstCharLabel = this.CreateLabel(0);
            _secondCharLabel = this.CreateLabel(1);
            _thirdCharLabel = this.CreateLabel(2);
            _fourthCharLabel = this.CreateLabel(3);
            _fifthCharLabel = this.CreateLabel(4);
            _sixthCharLabel = this.CreateLabel(5);

            _firstLine = this.CreateLine();
            _secondLine = this.CreateLine();
            _thirdLine = this.CreateLine();
            _fourthLine = this.CreateLine();
            _fifthLine = this.CreateLine();
            _sixthLine = this.CreateLine();

            _grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
                ColumnSpacing = 0,
                RowSpacing = 0,
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) },
                    new ColumnDefinition { Width = new GridLength(0, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) },
                    new ColumnDefinition { Width = new GridLength(0, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) },
                    new ColumnDefinition { Width = new GridLength(0, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) },
                    new ColumnDefinition { Width = new GridLength(0, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) },
                    new ColumnDefinition { Width = new GridLength(0, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) }
                }
            };

            _grid.Children.Add(this.CreateCharContent(_firstCharImage, _firstCharLabel, _firstLine), 0, 0);
            _grid.Children.Add(this.CreateCharContent(_secondCharImage, _secondCharLabel, _secondLine), 2, 0);
            _grid.Children.Add(this.CreateCharContent(_thirdCharImage, _thirdCharLabel, _thirdLine), 4, 0);
            _grid.Children.Add(this.CreateCharContent(_fourthCharImage, _fourthCharLabel, _fourthLine), 6, 0);
            _grid.Children.Add(this.CreateCharContent(_fifthCharImage, _fifthCharLabel, _fifthLine), 8, 0);
            _grid.Children.Add(this.CreateCharContent(_sixthCharImage, _sixthCharLabel, _sixthLine), 10, 0);

            this.Content = _grid;

            this.SetCharColor();
            this.SetCellWidth();
            this.SetCellSpacing();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName == TextProperty.PropertyName)
                this.SetCharsVisible();
            else if (propertyName == PasscodeColorProperty.PropertyName)
                this.SetCharColor();
            else if (propertyName == IsLinesVisibleProperty.PropertyName)
                this.SetLinesVisible();
            else if (propertyName == IsLongProperty.PropertyName)
            {
                this.SetLinesVisible();
                this.SetCellWidth();
                this.SetCellSpacing();
            }
            else if (propertyName == CellWidthProperty.PropertyName)
                this.SetCellWidth();
            else if (propertyName == CellSpacingProperty.PropertyName)
                this.SetCellSpacing();
            else if (propertyName == IsVisibleProperty.PropertyName)
            {
                this.SetCharsVisible();
                this.SetLinesVisible();
            }
            else if (propertyName == IsPasswordProperty.PropertyName)
                this.SetCharsVisible();

            base.OnPropertyChanged(propertyName);
        }

        private void SetCharColor()
        {
            if (_firstCharImage != null)
            {
                var source = "oval_gray";
                if (this.PasscodeColor == AppPasscodeColors.White)
                    source = "oval_white";

                _firstCharImage.Source = source;
                _secondCharImage.Source = source;
                _thirdCharImage.Source = source;
                _fourthCharImage.Source = source;
                _fifthCharImage.Source = source;
                _sixthCharImage.Source = source;
            }
        }

        private void SetCellSpacing()
        {
            _grid.ColumnDefinitions[1].Width = new GridLength(this.CellSpacing, GridUnitType.Absolute);
            _grid.ColumnDefinitions[3].Width = new GridLength(this.CellSpacing, GridUnitType.Absolute);
            _grid.ColumnDefinitions[5].Width = new GridLength(this.CellSpacing, GridUnitType.Absolute);
            _grid.ColumnDefinitions[7].Width = new GridLength((this.IsLong ? this.CellSpacing : 0), GridUnitType.Absolute);
            _grid.ColumnDefinitions[9].Width = new GridLength((this.IsLong ? this.CellSpacing : 0), GridUnitType.Absolute);
        }

        private Image CreateChar()
        {
            var image = new Image
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Source = "oval_gray"
            };
            return image;
        }

        private Label CreateLabel(int index)
        {
            var label = new AppLabel
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            label.SetBinding(AppLabel.TextProperty, new Binding(TextProperty.PropertyName, BindingMode.OneWay, _stringIndexValueConverter, index, null, this));
            label.SetBinding(AppLabel.TextColorProperty, new Binding(TextColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            label.SetBinding(AppLabel.AppFontProperty, new Binding(AppFontProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            label.SetBinding(AppLabel.FontSizeProperty, new Binding(FontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            return label;
        }

        private View CreateCharContent(View image, View label, View line)
        {
            var content = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
                }
            };

            content.Children.Add(image, 0, 0);
            content.Children.Add(label, 0, 0);
            content.Children.Add(line, 0, 1);

            return content;
        }

        private View CreateLine()
        {
            var contentView = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = 1
            };
            contentView.SetBinding(ContentView.BackgroundColorProperty, new Binding("LineColor", BindingMode.OneWay, null, null, null, this));
            return contentView;
        }

        private void SetCharsVisible()
        {
            if (_firstCharImage != null)
            {
                _firstCharImage.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 1) && (this.IsPassword));
                _secondCharImage.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 2) && (this.IsPassword));
                _thirdCharImage.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 3) && (this.IsPassword));
                _fourthCharImage.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 4) && (this.IsPassword));
                _fifthCharImage.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 5) && (this.IsPassword) && (this.IsLong));
                _sixthCharImage.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 6) && (this.IsPassword) && (this.IsLong));

                _firstCharLabel.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 1) && (!this.IsPassword));
                _secondCharLabel.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 2) && (!this.IsPassword));
                _thirdCharLabel.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 3) && (!this.IsPassword));
                _fourthCharLabel.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 4) && (!this.IsPassword));
                _fifthCharLabel.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 5) && (!this.IsPassword) && (this.IsLong));
                _sixthCharLabel.IsVisible = ((!String.IsNullOrEmpty(this.Text)) && (this.Text.Length >= 6) && (!this.IsPassword) && (this.IsLong));
            }
        }

        private void SetLinesVisible()
        {
            if (_firstLine != null)
            {
                _firstLine.IsVisible = this.IsLinesVisible;
                _secondLine.IsVisible = this.IsLinesVisible;
                _thirdLine.IsVisible = this.IsLinesVisible;
                _fourthLine.IsVisible = this.IsLinesVisible;
                _fifthLine.IsVisible = this.IsLinesVisible && this.IsLong;
                _sixthLine.IsVisible = this.IsLinesVisible && this.IsLong;
            }
        }

        private void SetCellWidth()
        {
            _firstLine.WidthRequest = this.CellWidth;
            _secondLine.WidthRequest = this.CellWidth;
            _thirdLine.WidthRequest = this.CellWidth;
            _fourthLine.WidthRequest = this.CellWidth;
            _fifthLine.WidthRequest = (this.IsLong ? this.CellWidth : 0);
            _sixthLine.WidthRequest = (this.IsLong ? this.CellWidth : 0);
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

        public bool IsPassword
        {
            get { return (bool)this.GetValue(IsPasswordProperty); }
            set { this.SetValue(IsPasswordProperty, value); }
        }

        public double CellWidth
        {
            get { return (double)this.GetValue(CellWidthProperty); }
            set { this.SetValue(CellWidthProperty, value); }
        }

        public double CellSpacing
        {
            get { return (double)this.GetValue(CellSpacingProperty); }
            set { this.SetValue(CellSpacingProperty, value); }
        }

        public AppPasscodeColors PasscodeColor
        {
            get { return (AppPasscodeColors)this.GetValue(PasscodeColorProperty); }
            set { this.SetValue(PasscodeColorProperty, value); }
        }

        public bool IsLinesVisible
        {
            get { return (bool)this.GetValue(IsLinesVisibleProperty); }
            set { this.SetValue(IsLinesVisibleProperty, value); }
        }

        public bool IsLong
        {
            get { return (bool)this.GetValue(IsLongProperty); }
            set { this.SetValue(IsLongProperty, value); }
        }

        public Color LineColor
        {
            get { return (Color)this.GetValue(LineColorProperty); }
            set { this.SetValue(LineColorProperty, value); }
        }
    }
    #endregion
}
