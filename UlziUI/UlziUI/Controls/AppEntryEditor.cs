using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppEntryEditor
    public class AppEntryEditor : ContentView
    {
        #region Static members
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Text", typeof(string), typeof(AppEntryEditor), null);
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(AppEntryEditor), Color.Black);
        public static readonly BindableProperty ErrorTextColorProperty = BindableProperty.Create("ErrorTextColor", typeof(Color), typeof(AppEntryEditor), Color.Red);
        public static readonly BindableProperty KeyboardProperty = BindableProperty.Create("Keyboard", typeof(Keyboard), typeof(AppEntryEditor), Keyboard.Text);
        public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create("IsPassword", typeof(bool), typeof(AppEntryEditor), default(bool));
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppEntryEditor), AppFonts.Quicksand);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppEntryEditor), Entry.FontSizeProperty.DefaultValue);
        public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create("Placeholder", typeof(string), typeof(AppEntryEditor), default(string));
        public static readonly BindableProperty PlaceholderColorProperty = BindableProperty.Create("PlaceholderColor", typeof(Color), typeof(AppEntryEditor), Entry.PlaceholderColorProperty.DefaultValue);
        public static readonly BindableProperty LineColorProperty = BindableProperty.Create("LineColor", typeof(Color), typeof(AppEntryEditor), Color.White);
        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create("ImageSource", typeof(string), typeof(AppEntryEditor), default(string));
        public static readonly BindableProperty ErrorImageSourceProperty = BindableProperty.Create("ErrorImageSource", typeof(string), typeof(AppEntryEditor), default(string));
        public static readonly BindableProperty IsErrorProperty = BindableProperty.Create("IsError", typeof(bool), typeof(AppEntryEditor), default(bool));
        public static readonly BindableProperty ImageSizeProperty = BindableProperty.Create("ImageSize", typeof(double), typeof(AppEntryEditor), default(double));
        public static readonly BindableProperty ImageOffsetProperty = BindableProperty.Create("ImageOffset", typeof(double), typeof(AppEntryEditor), default(double));
        #endregion

        private AppEntry _entry = null;
        private Image _image = null;
        private ContentView _imageContent = null;

        /// <summary>  
        ///  Capitalize the first character of every word.
        /// </summary>  
        public AppEntryEditor(bool capitalized) : base()
        {
            if (capitalized)
            {
                _entry = new AppEntryCapitalization
                {
                    HorizontalOptions = LayoutOptions.Fill,
                    VerticalOptions = LayoutOptions.End
                };
            }
            else
            {
                _entry = new AppEntry
                {
                    HorizontalOptions = LayoutOptions.Fill,
                    VerticalOptions = LayoutOptions.End
                };
            }

            yourMethod(_entry);
        }

        public AppEntryEditor() : base()
        {
            _entry = new AppEntry
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.End
            };

            yourMethod(_entry);
        }

        private void yourMethod(AppEntry _entry)
        {
            _image = new Image
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End,
            };
            _image.SetBinding(Image.HeightRequestProperty, new Binding("ImageSize", BindingMode.OneWay, null, null, null, this));
            _image.SetBinding(Image.WidthRequestProperty, new Binding("ImageSize", BindingMode.OneWay, null, null, null, this));

            _imageContent = new ContentView
            {
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Fill,
                Content = _image
            };

            //Cakesoft Fixed SB-5
            //Removed repeate initialization of _entry, which is done in contructor.
            _entry.SetBinding(AppEntry.TextProperty, new Binding(TextProperty.PropertyName, BindingMode.TwoWay, null, null, null, this));
            _entry.SetBinding(AppEntry.TextColorProperty, new Binding(TextColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _entry.SetBinding(AppEntry.KeyboardProperty, new Binding(KeyboardProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _entry.SetBinding(AppEntry.IsPasswordProperty, new Binding(IsPasswordProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _entry.SetBinding(AppEntry.PlaceholderProperty, new Binding(PlaceholderProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _entry.SetBinding(AppEntry.PlaceholderColorProperty, new Binding(PlaceholderColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _entry.SetBinding(AppEntry.AppFontProperty, new Binding(AppFontProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _entry.SetBinding(AppEntry.FontSizeProperty, new Binding(FontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            _entry.Completed += (sender, args) => {
                this.DoCompleted();
            };
            _entry.Focused += (sender, args) => {
                this.DoFocused();
            };

            _entry.TextChanged += (sender, args) =>
            {
                this.DoTextChanged(sender, args);
            };

            var entryContent = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Padding = new Thickness(0, 0, 0, 10),
                Content = _entry
            };

            var line = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };
            line.SetBinding(ContentView.BackgroundColorProperty, new Binding(LineColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 0,
                ColumnSpacing = 0,
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                },
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Absolute) }
                }
            };
            grid.Children.Add(_imageContent, 0, 0);
            grid.Children.Add(entryContent, 1, 0);
            grid.Children.Add(line, 0, 2, 1, 2);

            var touchGesture = new TapGestureRecognizer();
            touchGesture.Tapped += (sender, args) => {
                _entry.Focus();
            };
            this.GestureRecognizers.Add(touchGesture);

            this.SetColor();
            this.SetImageOffset();
            this.SetImageVisible();

            this.Content = grid;
        }


        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == ImageSourceProperty.PropertyName)
            {
                this.SetColor();
                this.SetImageVisible();
            }
            else if (propertyName == ErrorImageSourceProperty.PropertyName)
            {
                this.SetColor();
                this.SetImageVisible();
            }
            else if (propertyName == IsErrorProperty.PropertyName)
            {
                this.SetColor();
                this.SetImageVisible();
            }
            else if (propertyName == ImageOffsetProperty.PropertyName)
                this.SetImageOffset();
        }

        public bool SetFocus()
        {
            return _entry.Focus();
        }

        private void SetColor()
        {
            _entry.TextColor = (this.IsError ? this.ErrorTextColor : this.TextColor);
            _image.Source = (this.IsError ? this.ErrorImageSource : this.ImageSource);
        }

        private void SetImageOffset()
        {
            _imageContent.Padding = new Thickness(this.ImageOffset, 0, this.ImageOffset, 10);
        }

        public void SetImageVisible()
        {
            bool isVisible = false;
            if ((this.IsError) && (!String.IsNullOrEmpty(this.ErrorImageSource)))
                isVisible = true;
            else if ((!this.IsError) && (!String.IsNullOrEmpty(this.ImageSource)))
                isVisible = true;
            _imageContent.IsVisible = isVisible;
        }

        private void DoCompleted()
        {
            if (this.Completed != null)
                this.Completed(this, EventArgs.Empty);
        }

        private void DoFocused()
        {
            if (this.Focused != null)
                this.Focused(this, EventArgs.Empty);
        }

        private void DoTextChanged(object sender, TextChangedEventArgs ergs)
        {
            if (this.TextChanged != null)
                this.TextChanged(sender, ergs);
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

        public Color ErrorTextColor
        {
            get { return (Color)this.GetValue(ErrorTextColorProperty); }
            set { this.SetValue(ErrorTextColorProperty, value); }
        }

        public Keyboard Keyboard
        {
            get { return (Keyboard)this.GetValue(KeyboardProperty); }
            set { this.SetValue(KeyboardProperty, value); }
        }

        public bool IsPassword
        {
            get { return (bool)this.GetValue(IsPasswordProperty); }
            set { this.SetValue(IsPasswordProperty, value); }
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

        public string Placeholder
        {
            get { return (string)this.GetValue(PlaceholderProperty); }
            set { this.SetValue(PlaceholderProperty, value); }
        }

        public Color PlaceholderColor
        {
            get { return (Color)this.GetValue(PlaceholderColorProperty); }
            set { this.SetValue(PlaceholderColorProperty, value); }
        }

        public Color LineColor
        {
            get { return (Color)this.GetValue(LineColorProperty); }
            set { this.SetValue(LineColorProperty, value); }
        }

        public string ImageSource
        {
            get { return (string)this.GetValue(ImageSourceProperty); }
            set { this.SetValue(ImageSourceProperty, value); }
        }

        public string ErrorImageSource
        {
            get { return (string)this.GetValue(ErrorImageSourceProperty); }
            set { this.SetValue(ErrorImageSourceProperty, value); }
        }

        public bool IsError
        {
            get { return (bool)this.GetValue(IsErrorProperty); }
            set { this.SetValue(IsErrorProperty, value); }
        }

        public double ImageSize
        {
            get { return (double)this.GetValue(ImageSizeProperty); }
            set { this.SetValue(ImageSizeProperty, value); }
        }

        public double ImageOffset
        {
            get { return (double)this.GetValue(ImageOffsetProperty); }
            set { this.SetValue(ImageOffsetProperty, value); }
        }

        public event EventHandler Completed;

        public new event EventHandler Focused;

        public event EventHandler<TextChangedEventArgs> TextChanged;
    }
    #endregion
}
