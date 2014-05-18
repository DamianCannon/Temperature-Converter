using System;
using System.Globalization;
using System.Windows.Data;

namespace TemperatureConverterApp
{
    [ValueConversion(typeof(double), typeof(bool))]
    public class IsLessThanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double actualValue;
            double testValue;
            if (Double.TryParse(value.ToString(), out actualValue) && Double.TryParse(parameter.ToString(), out testValue))
            {
                return actualValue < testValue;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}