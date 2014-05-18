namespace TemperatureConverterApp
{
    public class TemperatureConverter : ITemperatureConverter
    {
        public double ConvertFarenheitToCelsius(double farenheitValue)
        {
            return (farenheitValue - 32.0)*5.0/9.0;
        }

        public double ConvertCelsiusToFarenheit(double celsiusValue)
        {
            return (celsiusValue*9.0/5.0) + 32.0;
        }
    }
}