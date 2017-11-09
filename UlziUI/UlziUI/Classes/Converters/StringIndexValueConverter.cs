using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace UlziUI.Classes.Converters
{
    #region StringIndexValueConverter
    public class StringIndexValueConverter : IValueConverter
    {
        #region IValueConverter
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var index = (int)parameter;
            var str = (string)value;
            if (str == null)
                str = "";
            return (str.Length > index ? str.Substring(index, 1) : " ");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    #endregion
}
