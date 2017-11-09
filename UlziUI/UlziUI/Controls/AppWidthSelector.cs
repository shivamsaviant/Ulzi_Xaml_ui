using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppWidthSelector
    public class AppWidthSelector : ContentView
    {
        #region Static members
        public static readonly BindableProperty MinValueProperty = BindableProperty.Create("MinValue", typeof(int), typeof(AppWidthSelector), (int)20);
        public static readonly BindableProperty MaxValueProperty = BindableProperty.Create("MaxValue", typeof(int), typeof(AppWidthSelector), (int)900);
        public static readonly BindableProperty ValueProperty = BindableProperty.Create("Value", typeof(int), typeof(AppWidthSelector), (int)50);
        #endregion

        private View _pointer = null;
        private View _background = null;
        private AppPanView _gesture = null;

        private bool _isSelectMode = false;
        private int _startValue = 0;
        private int _value = 0;
        private double _startY = 0;

        public AppWidthSelector() : base()
        {
            _background = new Image
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Source = "width_selector_background"
            };

            var pointerImage = new Image
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Source = "width_selector_pointer"
            };

            _pointer = new ContentView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Content = pointerImage
            };

            _gesture = new AppPanView
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill
            };
            _gesture.OnPanEvent += (sender, args) => {
                if (args.Event == AppPanViewEvent.Start)
                {
                    if (_pointer.Bounds.Contains(new Point(args.X, args.Y)))
                    {
                        _isSelectMode = true;
                        _startValue = _value;
                        _startY = args.Y;
                    }
                }
                else if ((args.Event == AppPanViewEvent.Move) && (_isSelectMode))
                    this.CalcNewValue(args);
                else if ((args.Event == AppPanViewEvent.Complete) && (_isSelectMode))
                {
                    this.CalcNewValue(args);
                    this.Value = _value;
                    _isSelectMode = false;
                }
            };

            var content = new AbsoluteLayout
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
            };
            content.Children.Add(_background);
            content.Children.Add(_pointer);
            content.Children.Add(_gesture);

            this.Content = content;

            this.SizeChanged += (sender, args) => {
                this.ResizeContent();
                this.SetPointer();
            };
        }

        private void CalcNewValue(AppPanViewEventArgs args)
        {
            var deltaY = _startY - args.Y;
            var step = this.GetValueStep();
            var deltaValue = 0;
            if (step != 0)
                deltaValue = (int)(deltaY / step);
            var newValue = _startValue + deltaValue;
            if (newValue < this.MinValue)
                newValue = this.MinValue;
            else if (newValue > this.MaxValue)
                newValue = this.MaxValue;
            _value = newValue;
            this.SetPointer();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if ((propertyName == "MinValue") || (propertyName == "MaxValue") || (propertyName == "Value"))
            {
                _value = this.Value;
                this.SetPointer();
            }
        }

        private void ResizeContent()
        {
            AbsoluteLayout.SetLayoutBounds(_background, new Rectangle(0, 0, this.Width, this.Height));
            AbsoluteLayout.SetLayoutBounds(_gesture, new Rectangle(0, 0, this.Width, this.Height));
        }

        private void SetPointer()
        {
            var step = GetValueStep();
            var top = this.Height - this.Height * 0.0909 - _value * step - this.Width / 2;

            AbsoluteLayout.SetLayoutBounds(_pointer, new Rectangle(0, top, this.Width, this.Width));
        }

        private double GetValueStep()
        {
            var step = (double)0;
            if (this.MaxValue != this.MinValue)
                step = this.Height * 0.75 / (this.MaxValue - this.MinValue);
            return step;
        }

        public int MinValue
        {
            get { return (int)this.GetValue(MinValueProperty); }
            set { this.SetValue(MinValueProperty, value); }
        }

        public int MaxValue
        {
            get { return (int)this.GetValue(MaxValueProperty); }
            set { this.SetValue(MaxValueProperty, value); }
        }

        public int Value
        {
            get { return (int)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }
    }
    #endregion
}
