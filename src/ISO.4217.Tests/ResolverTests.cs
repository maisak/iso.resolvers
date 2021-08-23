using System.Linq;
using ISO._4217;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ResolverTests
    {
        #region By number
        [TestCase("978", "EUR")]
        [TestCase("980", "UAH")]
        [TestCase("840", "USD")]
        [TestCase("000", null)]
        public void GetCodeByNumberTest(string number, string expected)
        {
            var code = CurrencyCodesResolver.GetCodeByNumber(number);
            Assert.AreEqual(expected, code);
        }

        [TestCase(978, "EUR")]
        [TestCase(980, "UAH")]
        [TestCase(032, "ARS")]
        [TestCase(0, null)]
        public void GetCodeByNumberTest(int number, string expected)
        {
            var code = CurrencyCodesResolver.GetCodeByNumber(number);
            Assert.AreEqual(expected, code);
        }

        [TestCase("980")]
        [TestCase("978")]
        [TestCase("840")]
        public void GetCurrenciesByNumberTest(string number)
        {
            var currencies = CurrencyCodesResolver.GetCurrenciesByNumber(number);
            Assert.IsNotEmpty(currencies);
        }

        [TestCase("000")]
        public void GetCurrenciesByNumberTestFail(string number)
        {
            var currencies = CurrencyCodesResolver.GetCurrenciesByNumber(number);
            Assert.IsEmpty(currencies);
        }

        [TestCase("978", "Euro")]
        [TestCase("980", "Hryvnia")]
        [TestCase("840", "US Dollar")]
        [TestCase("000", null)]
        public void GetCurrencyNameByNumberTest(string number, string expected)
        {
            var code = CurrencyCodesResolver.GetCurrencyNameByNumber(number);
            Assert.AreEqual(expected, code);
        }

        [TestCase(978, "Euro")]
        [TestCase(980, "Hryvnia")]
        [TestCase(840, "US Dollar")]
        [TestCase(0, null)]
        public void GetCurrencyNameByNumberTest(int number, string expected)
        {
            var code = CurrencyCodesResolver.GetCurrencyNameByNumber(number);
            Assert.AreEqual(expected, code);
        }
        #endregion

        #region By code
        [TestCase("EUR", 35)]
        [TestCase("UAH", 1)]
        [TestCase("USD", 19)]
        [TestCase("usd", 19)]
        [TestCase(null, 0)]
        [TestCase("ZUZ", 0)]
        [TestCase("just text", 0)]
        public void GetCurrenciesByCodeTest(string code, int expectedAmountOfCurrencies)
        {
            var currencies = CurrencyCodesResolver.GetCurrenciesByCode(code);
            
            Assert.AreEqual(expectedAmountOfCurrencies, currencies.Count());
        }

        [TestCase(978, 2)]  // normal execution
        [TestCase(952, 0)]  // normal execution
        [TestCase(48, 3)]   // short number 
        [TestCase(959, 0)]  // minor unit not available
        public void GetCurrencyMinorUnitsByNumber(int number, int minorUnits)
        {
            var exponent = CurrencyCodesResolver.GetExponentByNumber(number);
            
            Assert.AreEqual(minorUnits, exponent);
        }
        #endregion
    }
}