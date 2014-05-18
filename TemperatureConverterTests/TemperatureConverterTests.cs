using System;
using NUnit.Framework;
using TemperatureConverterApp;

namespace TemperatureConverterTests
{
    [TestFixture]
    public class TemperatureConverterTests
    {
        private ITemperatureConverter _temperatureConverter;

        [SetUp]
        public void SetUp()
        {
            _temperatureConverter = new TemperatureConverter();
        }

        [Test]
        public void ConvertFarenheitToCelsius_plus32degF_0degC()
        {
            var result = _temperatureConverter.ConvertFarenheitToCelsius(32.0);
            Assert.AreEqual(0.0, Math.Round(result, 3));
        }

        [Test]
        public void ConvertFarenheitToCelsius_0degF_minus17point778degC()
        {
            var result = _temperatureConverter.ConvertFarenheitToCelsius(0.0);
            Assert.AreEqual(-17.778, Math.Round(result, 3));
        }

        [Test]
        public void ConvertFarenheitToCelsius_plus89point6degF_plus32degC()
        {
            var result = _temperatureConverter.ConvertFarenheitToCelsius(89.6);
            Assert.AreEqual(32.0, Math.Round(result, 3));
        }

        [Test]
        public void ConvertCelsiusToFarenheit_0degC_plus32degF()
        {
            var result = _temperatureConverter.ConvertCelsiusToFarenheit(0.0);
            Assert.AreEqual(32.0, Math.Round(result, 3));
        }

        [Test]
        public void ConvertCelsiusToFarenheit_minus17point778degC_0degF()
        {
            var result = _temperatureConverter.ConvertCelsiusToFarenheit(-17.778);
            Assert.AreEqual(0.0, Math.Round(result, 3));
        }
    }
}