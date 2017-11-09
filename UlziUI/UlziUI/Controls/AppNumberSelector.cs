using System;
using System.Collections.Generic;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppNumberSelector
    public class AppNumberSelector : View
    {
        #region Static members
        public static readonly BindableProperty MinValueProperty = BindableProperty.Create("MinValue", typeof(int), typeof(AppNumberSelector), (int)0);
        public static readonly BindableProperty MaxValueProperty = BindableProperty.Create("MaxValue", typeof(int), typeof(AppNumberSelector), (int)10);
        public static readonly BindableProperty ValueProperty = BindableProperty.Create("Value", typeof(int), typeof(AppNumberSelector), (int)0);
        public static readonly BindableProperty NumberColorProperty = BindableProperty.Create("NumberColor", typeof(Color), typeof(AppNumberSelector), Color.Gray);
        public static readonly BindableProperty ValueColorProperty = BindableProperty.Create("ValueColor", typeof(Color), typeof(AppNumberSelector), Color.Black);
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppNumberSelector), AppFonts.Quicksand);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppNumberSelector), Device.GetNamedSize(NamedSize.Medium, typeof(Label)));
        public static readonly BindableProperty CellHeightProperty = BindableProperty.Create("CellHeight", typeof(double), typeof(AppNumberSelector), (double)24);
        #endregion

        public AppNumberSelector() : base()
        {
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

        public Color NumberColor
        {
            get { return (Color)this.GetValue(NumberColorProperty); }
            set { this.SetValue(NumberColorProperty, value); }
        }

        public Color ValueColor
        {
            get { return (Color)this.GetValue(ValueColorProperty); }
            set { this.SetValue(ValueColorProperty, value); }
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

        public double CellHeight
        {
            get { return (double)this.GetValue(CellHeightProperty); }
            set { this.SetValue(CellHeightProperty, value); }
        }
    }
    #endregion
}
