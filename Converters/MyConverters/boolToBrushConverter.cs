using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Converters.MyConverters
{
    internal class BoolToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //var isChecked = (bool)value;

            //if (isChecked)
            //    return Brushes.Green;

            //return Brushes.Red;
            
            return (bool)value ? Brushes.Green : Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
