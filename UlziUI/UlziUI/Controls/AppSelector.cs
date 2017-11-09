using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppSelector
    public class AppSelector : ContentView
    {
        #region Static members
        public static readonly BindableProperty IsLeftProperty = BindableProperty.Create("IsLeft", typeof(bool), typeof(AppSelector), true);
        public static readonly BindableProperty LeftTextProperty = BindableProperty.Create("LeftText", typeof(string), typeof(AppSelector), default(string));
        public static readonly BindableProperty RightTextProperty = BindableProperty.Create("RightText", typeof(string), typeof(AppSelector), default(string));
        public static readonly BindableProperty ActiveTextColorProperty = BindableProperty.Create("ActiveTextColor", typeof(Color), typeof(AppSelector), Color.White);
        public static readonly BindableProperty DisactiveTextColorProperty = BindableProperty.Create("DisactiveTextColor", typeof(Color), typeof(AppSelector), Color.FromHex("#9B9B9B"));
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppSelector), (double)17);
        #endregion

        private AppLabel _leftLabel = null;
        private AppLabel _rightLabel = null;

        public AppSelector() : base()
        {
            var rightImage = new Image
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Source = "selector_right"
            };

            var leftImage = new Image
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Source = "selector_left"
            };
            leftImage.SetBinding(Image.IsVisibleProperty, new Binding("IsLeft", BindingMode.OneWay, null, null, null, this));

            _leftLabel = new AppLabel
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                AppFont = AppFonts.Quicksand,
            };
            _leftLabel.SetBinding(AppLabel.TextProperty, new Binding("LeftText", BindingMode.OneWay, null, null, null, this));
            _leftLabel.SetBinding(AppLabel.FontSizeProperty, new Binding("FontSize", BindingMode.OneWay, null, null, null, this));

            _rightLabel = new AppLabel
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                AppFont = AppFonts.Quicksand,
            };
            _rightLabel.SetBinding(AppLabel.TextProperty, new Binding("RightText", BindingMode.OneWay, null, null, null, this));
            _rightLabel.SetBinding(AppLabel.FontSizeProperty, new Binding("FontSize", BindingMode.OneWay, null, null, null, this));

            var leftTouch = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };

            var leftTouchGesture = new TapGestureRecognizer();
            leftTouchGesture.Tapped += (sender, args) => {
                if (!this.IsLeft)
                    this.IsLeft = true;
            };
            leftTouch.GestureRecognizers.Add(leftTouchGesture);

            var rightTouch = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };

            var rightTouchGesture = new TapGestureRecognizer();
            rightTouchGesture.Tapped += (sender, args) => {
                if (this.IsLeft)
                    this.IsLeft = false;
            };
            rightTouch.GestureRecognizers.Add(rightTouchGesture);

            var content = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 0,
                ColumnSpacing = 0,
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };
            content.Children.Add(rightImage, 0, 2, 0, 1);
            content.Children.Add(leftImage, 0, 2, 0, 1);
            content.Children.Add(_leftLabel, 0, 0);
            content.Children.Add(_rightLabel, 1, 0);
            content.Children.Add(leftTouch, 0, 0);
            content.Children.Add(rightTouch, 1, 0);

            this.Content = content;

            this.SetTextColor();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == IsLeftProperty.PropertyName)
                this.SetTextColor();
        }

        private void SetTextColor()
        {
            _leftLabel.TextColor = (this.IsLeft ? this.ActiveTextColor : this.DisactiveTextColor);
            _rightLabel.TextColor = (this.IsLeft ? this.DisactiveTextColor : this.ActiveTextColor);
        }

        public bool IsLeft
        {
            get { return (bool)this.GetValue(IsLeftProperty); }
            set { this.SetValue(IsLeftProperty, value); }
        }

        public string LeftText
        {
            get { return (string)this.GetValue(LeftTextProperty); }
            set { this.SetValue(LeftTextProperty, value); }
        }

        public string RightText
        {
            get { return (string)this.GetValue(RightTextProperty); }
            set { this.SetValue(RightTextProperty, value); }
        }

        public Color ActiveTextColor
        {
            get { return (Color)this.GetValue(ActiveTextColorProperty); }
            set { this.SetValue(ActiveTextColorProperty, value); }
        }

        public Color DisactiveTextColor
        {
            get { return (Color)this.GetValue(DisactiveTextColorProperty); }
            set { this.SetValue(DisactiveTextColorProperty, value); }
        }

        public double FontSize
        {
            get { return (double)this.GetValue(FontSizeProperty); }
            set { this.SetValue(FontSizeProperty, value); }
        }
    }
    #endregion
}
