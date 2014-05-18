namespace TemperatureConverterApp
{
    public interface ITemperatureConverter
    {
        double ConvertFarenheitToCelsius(double farenheitValue);
        double ConvertCelsiusToFarenheit(double celsiusValue);
    }
}