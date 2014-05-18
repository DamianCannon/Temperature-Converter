using System.Windows.Data;
using NUnit.Framework;
using TemperatureConverterApp;

namespace TemperatureConverterTests
{
    [TestFixture]
    public class IsLessThanConverterTests
    {
        private IValueConverter _isLessThanConverter;

        [SetUp]
        public void SetUp()
        {
            _isLessThanConverter = new IsLessThanConverter();
        }

        [Test]
        public void ConvertLessThenAmount_ReturnTrue()
        {
            object result =_isLessThanConverter.Convert(5.0, typeof(double), 10.0, null);
            Assert.AreEqual(true, (bool)result);
        }

        [Test]
        public void ConvertMoreThenAmount_ReturnFalse()
        {
            object result = _isLessThanConverter.Convert(15.0, typeof(double), 10.0, null);
            Assert.AreEqual(false, (bool)result);
        }

        [Test]
        public void ConvertEqualAmount_ReturnFalse()
        {
            object result = _isLessThanConverter.Convert(10.0, typeof(double), 10.0, null);
            Assert.AreEqual(false, (bool)result);
        }
    }
}