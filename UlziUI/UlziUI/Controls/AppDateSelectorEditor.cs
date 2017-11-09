using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppDateSelectorEditor
    public class AppDateSelectorEditor : ContentView
    {
        #region Static members
        public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(AppDateSelectorEditor), default(string));
        public static readonly BindableProperty TextColorProperty = BindableProperty.Create("TextColor", typeof(Color), typeof(AppDateSelectorEditor), Color.Black);
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppDateSelectorEditor), AppFonts.Quicksand);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppDateSelectorEditor), Entry.FontSizeProperty.DefaultValue);
        public static readonly BindableProperty LineColorProperty = BindableProperty.Create("LineColor", typeof(Color), typeof(AppDateSelectorEditor), Color.White);
        public static readonly BindableProperty HorizontalTextAlignmentProperty = BindableProperty.Create("HorizontalTextAlignment", typeof(TextAlignment), typeof(AppDateSelectorEditor), TextAlignment.Start, BindingMode.OneWay);
        public static readonly BindableProperty DateProperty = BindableProperty.Create("Date", typeof(DateTime), typeof(AppDateSelectorEditor), DateTime.Today.AddYears(15));
        #endregion

        private AppEntry _editor = null;

        private readonly Guid _id = Guid.NewGuid();

        public AppDateSelectorEditor() : base()
        {
            _editor = new AppEntry
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.End
            };
            _editor.SetBinding(AppEntry.TextColorProperty, new Binding(TextColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _editor.SetBinding(AppEntry.AppFontProperty, new Binding(AppFontProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _editor.SetBinding(AppEntry.FontSizeProperty, new Binding(FontSizeProperty.PropertyName, BindingMode.OneWay, null, null, null, this));
            _editor.SetBinding(AppEntry.HorizontalTextAlignmentProperty, new Binding(HorizontalTextAlignmentProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var line = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };
            line.SetBinding(ContentView.BackgroundColorProperty, new Binding(LineColorProperty.PropertyName, BindingMode.OneWay, null, null, null, this));

            var touchContent = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
            };

            var touchGesture = new TapGestureRecognizer();
            touchGesture.Tapped += (sender, args) => {
                this.SetFocus();
            };
            this.GestureRecognizers.Add(touchGesture);

            touchContent.GestureRecognizers.Add(touchGesture);

            var grid = new Grid
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                RowSpacing = 10,
                ColumnSpacing = 0,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Absolute) }
                }
            };
            grid.Children.Add(_editor, 0, 0);
            grid.Children.Add(touchContent, 0, 0);
            grid.Children.Add(line, 0, 1);

            this.Content = grid;
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == DateProperty.PropertyName)
                _editor.Text = this.Date.ToShortDateString();
        }

        public bool SetFocus()
        {
            //SelectDateResponseMessage.Subscribe(this, this.SelectDate);

            //SelectDateRequestMessage.Send(_id, this.Date, this.Title);

            this.IsFocused = true;
            this.DoFocused();

            return this.IsFocused;
        }

        public bool LeaveFocus()
        {
            if (this.IsFocused)
            {
                //SelectDateCancelMessage.Send(_id);

                this.IsFocused = false;
            }

            return !this.IsFocused;
        }

        //private void SelectDate(SelectDateResponseMessage response)
        //{
        //    this.Date = response.SelectedDate;
        //    if (response.IsDone)
        //    {
        //        SelectDateResponseMessage.Unsubscribe(this);
        //        this.IsFocused = false;
        //        this.DoCompleted();
        //    }
        //}

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

        public string Title
        {
            get { return (string)this.GetValue(TitleProperty); }
            set { this.SetValue(TitleProperty, value); }
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

        public Color LineColor
        {
            get { return (Color)this.GetValue(LineColorProperty); }
            set { this.SetValue(LineColorProperty, value); }
        }

        public TextAlignment HorizontalTextAlignment
        {
            get { return (TextAlignment)this.GetValue(HorizontalTextAlignmentProperty); }
            set { this.SetValue(HorizontalTextAlignmentProperty, value); }
        }

        public DateTime Date
        {
            get { return (DateTime)this.GetValue(DateProperty); }
            set { this.SetValue(DateProperty, value); }
        }

        public new bool IsFocused { get; private set; }

        public event EventHandler Completed;
        public new event EventHandler Focused;
    }
    #endregion
}
