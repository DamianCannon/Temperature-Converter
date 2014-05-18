using System.Windows.Data;
using NUnit.Framework;
using TemperatureConverterApp;

namespace TemperatureConverterTests
{
    [TestFixture]
    public class IsGreaterThanConverterTests
    {
        private IValueConverter _isGreaterThanConverter;

        [SetUp]
        public void SetUp()
        {
            _isGreaterThanConverter = new IsGreaterThanConverter();
        }

        [Test]
        public void ConvertMoreThenAmount_ReturnTrue()
        {
            object result = _isGreaterThanConverter.Convert(15.0, typeof(double), 10.0, null);
            Assert.AreEqual(true, (bool)result);
        }

        [Test]
        public void ConvertLessThenAmount_ReturnFalse()
        {
            object result = _isGreaterThanConverter.Convert(5.0, typeof(double), 10.0, null);
            Assert.AreEqual(false, (bool)result);
        }

        [Test]
        public void ConvertEqualAmount_ReturnFalse()
        {
            object result = _isGreaterThanConverter.Convert(10.0, typeof(double), 10.0, null);
            Assert.AreEqual(false, (bool)result);
        }
    }
}