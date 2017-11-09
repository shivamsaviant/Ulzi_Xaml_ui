using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace UlziUI.Classes.Converters
{
    #region IndexToImageConverter
    public class IndexToImageConverter : IValueConverter
    {
        private string _trueImage = "";
        private string _falseImage = "";

        public IndexToImageConverter(string trueImage, string falseImage)
        {
            _trueImage = trueImage;
            _falseImage = falseImage;
        }

        #region IValueConverter
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = (int)value;
            var par = (int)parameter;
            return (val == par ? _trueImage : _falseImage);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
    #endregion
}
