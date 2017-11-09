using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppSwitch
    public class AppSwitch : ContentView
    {
        #region Static members
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create("IsChecked", typeof(bool), typeof(AppSwitch), default(bool));
        public static readonly BindableProperty ClickCommandProperty = BindableProperty.Create("ClickCommand", typeof(ICommand), typeof(AppSwitch), null);
        public static readonly BindableProperty ClickCommandParameterProperty = BindableProperty.Create("ClickCommandParameter", typeof(object), typeof(AppSwitch), null);
        #endregion

        public AppSwitch() : base()
        {
            var off = new Image
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Source = "switch_off"
            };

            var on = new Image
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Source = "switch_on"
            };
            on.SetBinding(Image.IsVisibleProperty, new Binding("IsChecked", BindingMode.OneWay, null, null, null, this));

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
            grid.Children.Add(off);
            grid.Children.Add(on);
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
