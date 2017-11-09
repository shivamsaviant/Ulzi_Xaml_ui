using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UlziUI.Classes.Enums;
using Xamarin.Forms;

namespace UlziUI.Controls
{
    #region AppEnumSelector
    public class AppEnumSelector : View
    {
        #region Static members
        public static readonly BindableProperty ItemsProperty = BindableProperty.Create("Items", typeof(IList), typeof(AppEnumSelector), null);
        public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create("SelectedItem", typeof(object), typeof(AppEnumSelector), null);
        public static readonly BindableProperty AppFontProperty = BindableProperty.Create("AppFont", typeof(AppFonts), typeof(AppEnumSelector), AppFonts.Quicksand);
        public static readonly BindableProperty FontSizeProperty = BindableProperty.Create("FontSize", typeof(double), typeof(AppEnumSelector), (double)17);
        public static readonly BindableProperty ValueTextColorProperty = BindableProperty.Create("ValueTextColor", typeof(Color), typeof(AppEnumSelector), Color.Black);
        public static readonly BindableProperty TextAlignmentProperty = BindableProperty.Create("TextAlignment", typeof(TextAlignment), typeof(AppEnumSelector), TextAlignment.Center);
        #endregion

        public AppEnumSelector() : base()
        {
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == SelectedItemProperty.PropertyName)
            {
                Console.WriteLine(this.SelectedItem);
            }
        }

        public IList Items
        {
            get { return (IList)this.GetValue(ItemsProperty); }
            set { this.SetValue(ItemsProperty, value); }
        }

        public object SelectedItem
        {
            get { return (object)this.GetValue(SelectedItemProperty); }
            set { this.SetValue(SelectedItemProperty, value); }
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

        public Color ValueTextColor
        {
            get { return (Color)this.GetValue(ValueTextColorProperty); }
            set { this.SetValue(ValueTextColorProperty, value); }
        }

        public TextAlignment TextAlignment
        {
            get { return (TextAlignment)this.GetValue(TextAlignmentProperty); }
            set { this.SetValue(TextAlignmentProperty, value); }
        }
    }
    #endregion
}
