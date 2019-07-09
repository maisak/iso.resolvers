using System;
using ISO._18245;
using NUnit.Framework;

namespace Tests
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
            Console.WriteLine($"Spent: {MerchantCategoryCodesResolver.Spent}ms");
        }

        [TestCase("4121", "Taxicabs and Limousines")]
        public void GetByCodeTest(string code, string description)
        {
            var mcc = MerchantCategoryCodesResolver.GetByCode(code);
            Assert.AreEqual(mcc.Description, description);
        }

        [TestCase("0000", null)]
        public void GetByCodeTestFail(string code, string expected)
        {
            var mcc = MerchantCategoryCodesResolver.GetByCode(code);
            Assert.AreEqual(mcc, expected);
        }
    }
}