using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppCommand
    public class AppCommand : ContentView
    {
        #region Static members
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(AppCommand), default(string));
        public static readonly BindableProperty FlatTextProperty = BindableProperty.Create("FlatText", typeof(string), typeof(AppCommand), default(string));
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(AppCommand), Color.White);
        public static readonly BindableProperty DisableTextColorProperty = BindableProperty.Create("DisableTextColor", typeof(Color), typeof(AppCommand), Color.FromHex("#555555"));
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppCommand), AppFonts.Quicksand);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppCommand), Label.FontSizeProperty.DefaultValue);
        public static readonly BindableProperty FontAttributesProperty = BindableProperty.Create("FontAttributes", typeof(FontAttributes), typeof(AppCommand), Label.FontAttributesProperty.DefaultValue);
        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create("ImageSource", typeof(string), typeof(AppCommand), default(string));
        public static readonly BindableProperty ImageSizeProperty = BindableProperty.Create("ImageSize", typeof(double), typeof(AppCommand), default(double));
        public static readonly BindableProperty CommandProperty = BindableProperty.Create("Command", typeof(ICommand), typeof(AppCommand), null);
        public static readonly BindableProperty CommandParameterProperty = BindableProperty.Create("CommandParameter", typeof(object), typeof(AppCommand), null);
        public static readonly BindableProperty LongTapCommandProperty = BindableProperty.Create("LongTapCommand", typeof(ICommand), typeof(AppCommand), null);
        public static readonly BindableProperty OrientationProperty = BindableProperty.Create("Orientation", typeof(StackOrientation), typeof(AppCommand), StackOrientation.Horizontal);
        public static readonly BindableProperty SpacingProperty = BindableProperty.Create("Spacing", typeof(double), typeof(AppCommand), default(double));
        public static readonly BindableProperty ContentHorizontalOptionsProperty = BindableProperty.Create("ContentHorizontalOptions", typeof(LayoutOptions), typeof(AppCommand), LayoutOptions.Center);
        public static readonly BindableProperty ContentVerticalOptionsProperty = BindableProperty.Create("ContentVerticalOptions", typeof(LayoutOptions), typeof(AppCommand), LayoutOptions.Center);
        public static readonly BindableProperty IsUnderlineProperty = BindableProperty.Create("IsUnderline", typeof(bool), typeof(AppCommand), default(bool));
        public static readonly BindableProperty CommandPaddingProperty = BindableProperty.Create("CommandPadding", typeof(Thickness), typeof(AppCommand), new Thickness(0));
        public static readonly BindableProperty CountProperty = BindableProperty.Create("Count", typeof(int), typeof(AppCommand), 0);
        public static readonly BindableProperty IsCountVisibleProperty = BindableProperty.Create("IsCountVisible", typeof(bool), typeof(AppCommand), false);
        #endregion

        private Image _image = null;
        private AppLabel _label = null;
        private StackLayout _content = null;

        public AppCommand() : base()
        {
            _image = new Image
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            _image.SetBinding(Image.SourceProperty, new Binding(ImageSourceProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _image.SetBinding(Image.HeightRequestProperty, new Binding(ImageSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _image.SetBinding(Image.WidthRequestProperty, new Binding(ImageSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var backgroundColor = Color.FromHex("#FE3824");
            var textColor = Color.White;

            var count = new AppLabel
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                AppFont = AppFonts.Quicksand,
                FontSize = 7,
                TextColor = textColor
            };
            count.SetBinding(AppLabel.TextProperty, new Binding(CountProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var countFrame = new Frame
            {
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = 14,
                WidthRequest = 14,
                CornerRadius = 7,
                Padding = new Thickness(0),
                BackgroundColor = backgroundColor,
                OutlineColor = backgroundColor,
                HasShadow = false,
                Content = count
            };
            countFrame.SetBinding(Frame.IsVisibleProperty, new Binding(IsCountVisibleProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var countContent = new Grid
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                RowSpacing = 0,
                ColumnSpacing = 0,
            };
            countContent.SetBinding(Grid.HeightRequestProperty, new Binding(ImageSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            countContent.SetBinding(Grid.WidthRequestProperty, new Binding(ImageSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            countContent.Children.Add(_image);
            countContent.Children.Add(countFrame);

            _label = new AppLabel
            {
                HorizontalOptions = (this.Orientation == StackOrientation.Horizontal ? LayoutOptions.Start : LayoutOptions.Fill),
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
            };
            _label.SetBinding(AppLabel.HtmlTextProperty, new Binding(TextProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _label.SetBinding(AppLabel.TextProperty, new Binding(FlatTextProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _label.SetBinding(AppLabel.AppFontProperty, new Binding(AppFontProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _label.SetBinding(AppLabel.FontSizeProperty, new Binding(FontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _label.SetBinding(AppLabel.IsUnderlineProperty, new Binding(IsUnderlineProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _label.SetBinding(AppLabel.FontAttributesProperty, new Binding(FontAttributesProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            _content = new StackLayout
            {
            };
            _content.SetBinding(StackLayout.HorizontalOptionsProperty, new Binding(ContentHorizontalOptionsProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _content.SetBinding(StackLayout.VerticalOptionsProperty, new Binding(ContentVerticalOptionsProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _content.SetBinding(StackLayout.OrientationProperty, new Binding(OrientationProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _content.SetBinding(StackLayout.SpacingProperty, new Binding(SpacingProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _content.SetBinding(StackLayout.PaddingProperty, new Binding(CommandPaddingProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            _content.Children.Add(countContent);
            _content.Children.Add(_label);

            var touch = new AppLongTapView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };
            touch.SetBinding(AppLongTapView.CommandProperty, new Binding("LongTapCommand", BindingMode.OneWay, null, null, null, this));
            touch.SetBinding(AppLongTapView.CommandParameterProperty, new Binding("CommandParameter", BindingMode.OneWay, null, null, null, this));

            var touchGesture = new TapGestureRecognizer();
            touchGesture.Tapped += (sender, args) => {
                if ((this.Command != null) && (this.Command.CanExecute(this.CommandParameter)))
                {
                    this.FadeTo(0.6);
                    this.FadeTo(1);
                    this.Command.Execute(CommandParameter);
                }
            };

            touch.GestureRecognizers.Add(touchGesture);

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 0,
                ColumnSpacing = 0
            };
            grid.Children.Add(_content);
            grid.Children.Add(touch);

            this.SetTextColor();

            this.Content = grid;
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if ((propertyName == OrientationProperty.PropertyName) && (_label != null))
            {
                _label.HorizontalOptions = (this.Orientation == StackOrientation.Horizontal ? LayoutOptions.Start : LayoutOptions.Fill);
                _label.HorizontalTextAlignment = (this.Orientation == StackOrientation.Horizontal ? TextAlignment.Start : TextAlignment.Center);
                //                _content.HorizontalOptions = (this.Orientation == StackOrientation.Horizontal ? LayoutOptions.Center : LayoutOptions.Fill);
            }
            else if ((propertyName == CommandProperty.PropertyName) && (this.Command != null))
            {
                this.Command.CanExecuteChanged += (sender, args) => {
                    if (_label != null)
                        this.SetTextColor();
                };
                this.SetTextColor();
            }
            else if (propertyName == TextColorProperty.PropertyName)
                this.SetTextColor();
        }

        private void SetTextColor()
        {
            Device.BeginInvokeOnMainThread(() => {
                var color = this.DisableTextColor;
                if ((this.Command != null) && (this.Command.CanExecute(this.CommandParameter)))
                    color = this.TextColor;

                _label.TextColor = color;
            });
        }

        public string Text
        {
            get { return (string)this.GetValue(TextProperty); }
            set { this.SetValue(TextProperty, value); }
        }

        public string FlatText
        {
            get { return (string)this.GetValue(FlatTextProperty); }
            set { this.SetValue(FlatTextProperty, value); }
        }

        public Color TextColor
        {
            get { return (Color)this.GetValue(TextColorProperty); }
            set { this.SetValue(TextColorProperty, value); }
        }

        public Color DisableTextColor
        {
            get { return (Color)this.GetValue(DisableTextColorProperty); }
            set { this.SetValue(DisableTextColorProperty, value); }
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

        public FontAttributes FontAttributes
        {
            get { return (FontAttributes)this.GetValue(FontAttributesProperty); }
            set { this.SetValue(FontAttributesProperty, value); }
        }

        public string ImageSource
        {
            get { return (string)this.GetValue(ImageSourceProperty); }
            set { this.SetValue(ImageSourceProperty, value); }
        }

        public double ImageSize
        {
            get { return (double)this.GetValue(ImageSizeProperty); }
            set { this.SetValue(ImageSizeProperty, value); }
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

        public ICommand LongTapCommand
        {
            get { return (ICommand)this.GetValue(LongTapCommandProperty); }
            set { this.SetValue(LongTapCommandProperty, value); }
        }

        public StackOrientation Orientation
        {
            get { return (StackOrientation)this.GetValue(OrientationProperty); }
            set { this.SetValue(OrientationProperty, value); }
        }

        public double Spacing
        {
            get { return (double)this.GetValue(SpacingProperty); }
            set { this.SetValue(SpacingProperty, value); }
        }

        public LayoutOptions ContentHorizontalOptions
        {
            get { return (LayoutOptions)this.GetValue(ContentHorizontalOptionsProperty); }
            set { this.SetValue(ContentHorizontalOptionsProperty, value); }
        }

        public LayoutOptions ContentVerticalOptions
        {
            get { return (LayoutOptions)this.GetValue(ContentVerticalOptionsProperty); }
            set { this.SetValue(ContentVerticalOptionsProperty, value); }
        }

        public bool IsUnderline
        {
            get { return (bool)this.GetValue(IsUnderlineProperty); }
            set { this.SetValue(IsUnderlineProperty, value); }
        }

        public Thickness CommandPadding
        {
            get { return (Thickness)this.GetValue(CommandPaddingProperty); }
            set { this.SetValue(CommandPaddingProperty, value); }
        }

        public int Count
        {
            get { return (int)this.GetValue(CountProperty); }
            set { this.SetValue(CountProperty, value); }
        }

        public bool IsCountVisible
        {
            get { return (bool)this.GetValue(IsCountVisibleProperty); }
            set { this.SetValue(IsCountVisibleProperty, value); }
        }
    }
    #endregion
}
