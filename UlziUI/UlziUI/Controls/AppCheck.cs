using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppCheck
    public class AppCheck : ContentView
    {
        #region Static members
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create("IsChecked", typeof(bool), typeof(AppCheck), default(bool));
        public static readonly BindableProperty ClickCommandProperty = BindableProperty.Create("ClickCommand", typeof(ICommand), typeof(AppCheck), null);
        public static readonly BindableProperty ClickCommandParameterProperty = BindableProperty.Create("ClickCommandParameter", typeof(object), typeof(AppCheck), null);
        #endregion

        public AppCheck() : base()
        {
            var empty = new Image
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Source = "unchecked"
            };

            var check = new Image
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Source = "checked_green"
            };
            check.SetBinding(Image.IsVisibleProperty, new Binding("IsChecked", BindingMode.OneWay, null, null, null, this));

            var touch = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };

            var touchGesture = new TapGestureRecognizer();
            touchGesture.Tapped += (sender, args) => {
                if ((this.ClickCommand != null) && (this.ClickCommand.CanExecute(this.ClickCommandParameter)))
                    this.ClickCommand.Execute(this.ClickCommandParameter);
            };
            touch.GestureRecognizers.Add(touchGesture);

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 0,
                ColumnSpacing = 0
            };
            grid.Children.Add(empty);
            grid.Children.Add(check);
            grid.Children.Add(touch);

            this.Content = grid;
        }

        public bool IsChecked
        {
            get { return (bool)this.GetValue(IsCheckedProperty); }
            set { this.SetValue(IsCheckedProperty, value); }
        }

        public ICommand ClickCommand
        {
            get { return (ICommand)this.GetValue(ClickCommandProperty); }
            set { this.SetValue(ClickCommandProperty, value); }
        }

        public object ClickCommandParameter
        {
            get { return this.GetValue(ClickCommandParameterProperty); }
            set { this.SetValue(ClickCommandParameterProperty, value); }
        }
    }
    #endregion
}
