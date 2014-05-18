using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TemperatureConverterApp
{
    [ValueConversion(typeof(double), typeof(double))]
    public class FahrenheitToCelsiusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;

            var converter = new TemperatureConverter();

            double degreeValue;
            if (double.TryParse(value.ToString(), out degreeValue))
            {
                return converter.ConvertFarenheitToCelsius(degreeValue);
            }
            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;

            var converter = new TemperatureConverter();

            double degreeValue;
            if (double.TryParse(value.ToString(), out degreeValue))
            {
                return converter.ConvertCelsiusToFarenheit(degreeValue);
            }
            return DependencyProperty.UnsetValue;
        }
    }
}