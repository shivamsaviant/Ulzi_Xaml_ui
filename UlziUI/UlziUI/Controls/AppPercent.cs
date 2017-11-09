using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppPercent
    public class AppPercent : ContentView
    {
        #region Static members
        public static readonly BindableProperty PercentProperty = BindableProperty.Create("Percent", typeof(int), typeof(AppPercent), default(int));
        public static readonly BindableProperty CompletedColorProperty = BindableProperty.Create("CompletedColor", typeof(Color), typeof(AppPercent), Color.White);
        public static readonly BindableProperty NotCompletedColorProperty = BindableProperty.Create("NotCompletedColor", typeof(Color), typeof(AppPercent), Color.Gray);
        public static readonly BindableProperty FormatTextProperty = BindableProperty.Create("FormatText", typeof(string), typeof(AppPercent), "{0}");
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(AppPercent), Color.Gray);
        public static readonly BindableProperty TextFontSizeProperty = BindableProperty.Create("TextFontSize", typeof(double), typeof(AppPercent), Device.GetNamedSize(NamedSize.Small, typeof(Label)));
        public static readonly BindableProperty SpacingProperty = BindableProperty.Create("Spacing", typeof(double), typeof(AppPercent), default(double));
        public static readonly BindableProperty BarHeightProperty = BindableProperty.Create("BarHeight", typeof(double), typeof(AppPercent), (double)10);
        #endregion

        private ContentView _completed = null;
        private AppLabel _text = null;

        public AppPercent() : base()
        {
            this.SizeChanged += (sender, args) => {
                this.CalcCompletedWidth();
            };

            _completed = new ContentView
            {
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Fill
            };
            _completed.SetBinding(ContentView.BackgroundColorProperty, new Binding(CompletedColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var notCompleted = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                Content = _completed
            };
            notCompleted.SetBinding(ContentView.HeightRequestProperty, new Binding(BarHeightProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            notCompleted.SetBinding(ContentView.BackgroundColorProperty, new Binding(NotCompletedColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            _text = new AppLabel
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                AppFont = AppFonts.Quicksand
            };
            _text.SetBinding(AppLabel.TextColorProperty, new Binding(TextColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _text.SetBinding(AppLabel.FontSizeProperty, new Binding(TextFontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                Orientation = StackOrientation.Vertical
            };
            content.SetBinding(StackLayout.SpacingProperty, new Binding(SpacingProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            content.Children.Add(notCompleted);
            content.Children.Add(_text);

            this.SetText();

            this.Content = content;
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName == PercentProperty.PropertyName)
                this.CalcCompletedWidth();
            else if (propertyName == FormatTextProperty.PropertyName)
                this.SetText();

            base.OnPropertyChanged(propertyName);
        }

        private void CalcCompletedWidth()
        {
            var width = this.Width;
            if (this.Percent < 0)
                width = 0;
            else
                width = this.Width / 100 * this.Percent;
            _completed.WidthRequest = width;

            this.SetText();
        }

        private void SetText()
        {
            _text.Text = String.Format(this.FormatText, this.Percent);
        }

        public int Percent
        {
            get { return (int)this.GetValue(PercentProperty); }
            set { this.SetValue(PercentProperty, value); }
        }

        public Color CompletedColor
        {
            get { return (Color)this.GetValue(CompletedColorProperty); }
            set { this.SetValue(CompletedColorProperty, value); }
        }

        public Color NotCompletedColor
        {
            get { return (Color)this.GetValue(NotCompletedColorProperty); }
            set { this.SetValue(NotCompletedColorProperty, value); }
        }

        public string FormatText
        {
            get { return (string)this.GetValue(FormatTextProperty); }
            set { this.SetValue(FormatTextProperty, value); }
        }

        public Color TextColor
        {
            get { return (Color)this.GetValue(TextColorProperty); }
            set { this.SetValue(TextColorProperty, value); }
        }

        public double TextFontSize
        {
            get { return (double)this.GetValue(TextFontSizeProperty); }
            set { this.SetValue(TextFontSizeProperty, value); }
        }

        public double Spacing
        {
            get { return (double)this.GetValue(SpacingProperty); }
            set { this.SetValue(SpacingProperty, value); }
        }

        public double BarHeight
        {
            get { return (double)this.GetValue(BarHeightProperty); }
            set { this.SetValue(BarHeightProperty, value); }
        }
    }
    #endregion
}
