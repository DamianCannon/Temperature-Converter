using System;
using System.Windows;
using System.Windows.Data;
using NUnit.Framework;
using TemperatureConverterApp;

namespace TemperatureConverterTests
{
    [TestFixture]
    public class FahrenheitToCelsiusConverterTests
    {
        private IValueConverter _fahrenheitToCelsiusConverter;

        [SetUp]
        public void SetUp()
        {
            _fahrenheitToCelsiusConverter = new FahrenheitToCelsiusConverter();
        }

        [Test]
        public void ConvertFahrenheitToCelsius()
        {
            var result = _fahrenheitToCelsiusConverter.Convert(32.0, typeof(double), null, null);
            Assert.AreEqual(0.00, (double)result);
        }

        [Test]
        public void ConvertCelsiusToFahrenheit()
        {
            var result = _fahrenheitToCelsiusConverter.ConvertBack(0.0, typeof(double), null, null);
            Assert.AreEqual(32.00, (double)result);
        }

        [Test]
        public void ConvertFahrenheitToCelsiusPassingNullValue()
        {
            var result = _fahrenheitToCelsiusConverter.Convert(null, typeof(double), null, null);
            Assert.AreEqual(result, DependencyProperty.UnsetValue);
        }

        [Test]
        public void ConvertCelsiusToFahrenheitPassingNullValue()
        {
            var result = _fahrenheitToCelsiusConverter.ConvertBack(null, typeof(double), null, null);
            Assert.AreEqual(result, DependencyProperty.UnsetValue);
        }

        [Test]
        public void ConvertFahrenheitToCelsiusPassingNonNumericValue()
        {
            var result = _fahrenheitToCelsiusConverter.Convert("test", typeof(double), null, null);
            Assert.AreEqual(result, DependencyProperty.UnsetValue);
        }

        [Test]
        public void ConvertCelsiusToFahrenheitPassingNonNumericValue()
        {
            var result = _fahrenheitToCelsiusConverter.ConvertBack("test", typeof(double), null, null);
            Assert.AreEqual(result, DependencyProperty.UnsetValue);
        }
    }
}