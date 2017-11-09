using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UlziUI.Classes.Enums;
using UlziUI.Views.Pages;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppEnumSelectorView
    public class AppEnumSelectorView : ContentView
    {
        #region Static members
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(AppEnumSelectorView), default(string));
        public static readonly BindableProperty TitleTextColorProperty = BindableProperty.Create("TitleTextColor", typeof(Color), typeof(AppEnumSelectorView), Color.Black);
        public static readonly BindableProperty LineColorProperty = BindableProperty.Create("LineColor", typeof(Color), typeof(AppEnumSelectorView), Color.FromHex("#9C9DA1"));
        public static readonly BindableProperty TitleBackgroundProperty = BindableProperty.Create("TitleBackground", typeof(Color), typeof(AppEnumSelectorView), Color.FromHex("#F0F0F0"));
        public static readonly BindableProperty DoneCommandProperty = BindableProperty.Create("DoneCommand", typeof(ICommand), typeof(AppEnumSelectorView), null);
        public static readonly BindableProperty DoneCommandTextProperty = BindableProperty.Create("DoneCommandText", typeof(string), typeof(AppEnumSelectorView), default(string));
        public static readonly BindableProperty DoneCommandTextColorProperty = BindableProperty.Create("DoneCommandTextColor", typeof(Color), typeof(AppEnumSelectorView), Color.FromHex("#2F92FD"));
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppEnumSelectorView), (double)17);
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppEnumSelectorView), AppFonts.Quicksand);
        public static readonly BindableProperty ItemsProperty = BindableProperty.Create("Items", typeof(IList), typeof(AppEnumSelectorView), null);
        public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create("SelectedItem", typeof(object), typeof(AppEnumSelectorView), null);
        #endregion

        public AppEnumSelectorView() : base()
        {
            this.HorizontalOptions = LayoutOptions.Fill;
            this.VerticalOptions = LayoutOptions.End;

            this.BackgroundColor = Color.FromHex("#D2D5DB");

            this.Content = this.CreateContent();
        }

        private View CreateContent()
        {
            var content = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
                }
            };
            content.Children.Add(this.CreateLine(), 0, 0);
            content.Children.Add(this.CreateTitle(), 0, 1);
            content.Children.Add(this.CreateLine(), 0, 2);
            content.Children.Add(this.CreateSelector(), 0, 3);
            content.Children.Add(this.CreateIndicator(), 0, 3);

            return content;
        }

        private View CreateLine()
        {
            var line = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = 1
            };
            line.SetBinding(ContentView.BackgroundColorProperty, new Binding(LineColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            return line;
        }

        private View CreateTitle()
        {
            var height = MainPage.PageHeight * 0.0660;

            var content = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = height,
                ColumnSpacing = 0,
                RowSpacing = 0,
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) }
                }
            };
            content.SetBinding(Grid.BackgroundColorProperty, new Binding(TitleBackgroundProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            content.Children.Add(this.CreateTitleText(), 0, 0);
            content.Children.Add(this.CreateDoneCommand(), 1, 0);

            return content;
        }

        private View CreateSelector()
        {
            var height = MainPage.PageHeight * 0.3240;

            var selector = new AppEnumSelector
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };
            selector.SetBinding(AppEnumSelector.ItemsProperty, new Binding(ItemsProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            selector.SetBinding(AppEnumSelector.SelectedItemProperty, new Binding(SelectedItemProperty.PropertyName, BindingMode.TwoWay, null, null, null, this));

            var content = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = height,
                ColumnSpacing = 0,
                RowSpacing = 0
            };

            content.Children.Add(selector);

            return content;
        }

        private View CreateIndicator()
        {
            var height = 36;
            var indicator = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Center,
                HeightRequest = height,
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
                }
            };
            indicator.Children.Add(this.CreateLine(), 0, 0);
            indicator.Children.Add(this.CreateLine(), 0, 2);

            return indicator;
        }

        private View CreateDoneCommand()
        {
            var doneCommand = new AppCommand
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Fill,
                Padding = new Thickness(10, 0, 10, 0),
                FontAttributes = FontAttributes.Bold
            };
            doneCommand.SetBinding(AppCommand.TextProperty, new Binding(DoneCommandTextProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            doneCommand.SetBinding(AppCommand.AppFontProperty, new Binding(AppFontProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            doneCommand.SetBinding(AppCommand.FontSizeProperty, new Binding(FontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            doneCommand.SetBinding(AppCommand.TextColorProperty, new Binding(DoneCommandTextColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            doneCommand.SetBinding(AppCommand.CommandProperty, new Binding(DoneCommandProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            return doneCommand;
        }

        private View CreateTitleText()
        {
            var label = new AppLabel
            {
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center,
            };
            label.SetBinding(AppLabel.TextProperty, new Binding(TitleProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            label.SetBinding(AppLabel.AppFontProperty, new Binding(AppFontProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            label.SetBinding(AppLabel.FontSizeProperty, new Binding(FontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            label.SetBinding(AppLabel.TextColorProperty, new Binding(TitleTextColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var content = new ContentView
            {
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Fill,
                Padding = new Thickness(10, 0, 0, 0),
                Content = label
            };

            return content;
        }

        public string Title
        {
            get { return (string)this.GetValue(TitleProperty); }
            set { this.SetValue(TitleProperty, value); }
        }

        public Color TitleTextColor
        {
            get { return (Color)this.GetValue(TitleTextColorProperty); }
            set { this.SetValue(TitleTextColorProperty, value); }
        }

        public Color LineColor
        {
            get { return (Color)this.GetValue(LineColorProperty); }
            set { this.SetValue(LineColorProperty, value); }
        }

        public Color TitleBackground
        {
            get { return (Color)this.GetValue(TitleBackgroundProperty); }
            set { this.SetValue(TitleBackgroundProperty, value); }
        }

        public ICommand DoneCommand
        {
            get { return (ICommand)this.GetValue(DoneCommandProperty); }
            set { this.SetValue(DoneCommandProperty, value); }
        }

        public string DoneCommandText
        {
            get { return (string)this.GetValue(DoneCommandTextProperty); }
            set { this.SetValue(DoneCommandTextProperty, value); }
        }

        public Color DoneCommandTextColor
        {
            get { return (Color)this.GetValue(DoneCommandTextColorProperty); }
            set { this.SetValue(DoneCommandTextColorProperty, value); }
        }

        public double FontSize
        {
            get { return (double)this.GetValue(FontSizeProperty); }
            set { this.SetValue(FontSizeProperty, value); }
        }

        public AppFonts AppFont
        {
            get { return (AppFonts)this.GetValue(AppFontProperty); }
            set { this.SetValue(AppFontProperty, value); }
        }

        public IList Items
        {
            get { return (IList)this.GetValue(ItemsProperty); }
            set { this.SetValue(ItemsProperty, value); }
        }

        public object SelectedItem
        {
            get { return this.GetValue(SelectedItemProperty); }
            set { this.SetValue(SelectedItemProperty, value); }
        }
    }
    #endregion
}
