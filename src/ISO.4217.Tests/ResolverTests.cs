using ISO._4217;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ResolverTests
    {
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
        [TestCase(840, "USD")]
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
    }
}