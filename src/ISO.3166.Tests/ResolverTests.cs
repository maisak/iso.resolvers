using System;
using NUnit.Framework;

namespace ISO._3166.Tests
{
    [TestFixture]
    public class ResolverTests
    {
        /// <summary>
        /// Not actually a test, shows time needed to load json file
        /// </summary>
        [Test]
        public void XmlLoadPerformance()
        {
            Console.WriteLine($"Spent: {CountryCodesResolver.Spent}ms");
        }

        [TestCase("UA", "Ukraine")]
        public void GetByCodeTest(string code, string description)
        {
            var cc = CountryCodesResolver.GetByCode(code);
            Assert.AreEqual(cc.Name, description);
        }
    }
}