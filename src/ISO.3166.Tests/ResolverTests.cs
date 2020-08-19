using System;
using NUnit.Framework;

namespace ISO._3166.Tests
{
    [TestFixture]
    public class ResolverTests
    {
        [TestCase("UA", "Ukraine")]
        [TestCase("GB", "United Kingdom")]
        public void GetByAlpha2CodeTest(string code, string description)
        {
            var cc = CountryCodesResolver.GetByAlpha2Code(code);
            Assert.AreEqual(cc.Name, description);
        }

        [TestCase("UKR", "Ukraine")]
        [TestCase("GBR", "United Kingdom")]
        public void GetByAlpha3CodeTest(string code, string description)
        {
            var cc = CountryCodesResolver.GetByAlpha3Code(code);
            Assert.AreEqual(description, cc.Name);
        }

        [Test]
        public void GetListTest()
        {
            var list = CountryCodesResolver.GetList();
            Assert.Greater(list.Count, 0);
        }
    }
}