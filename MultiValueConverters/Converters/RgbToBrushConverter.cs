using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace MultiValueConverters.Converters
{
    internal class RgbToBrushConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var red = (byte)(double)values[0];
            var green = (byte)(double)values[1];
            var blue = (byte)(double)values[2];

            return new SolidColorBrush(Color.FromRgb(red, green, blue));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
