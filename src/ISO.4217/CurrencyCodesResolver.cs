using ISO._4217.Models;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ISO._4217
{
    /// <summary>
    /// Source is here https://www.currency-iso.org/dam/downloads/lists/list_one.xml
    /// </summary>
    public sealed class CurrencyCodesResolver
    {
        private static CurrencyCodesResolver _instance;
        private List<Currency> _codes;

        public static CurrencyCodesResolver Load()
        {
            if (_instance != null) return _instance;

            _instance = new CurrencyCodesResolver();
                
            var document = XElement.Load(@"codes.xml");

            _instance._codes = (from node in document.Descendants("CcyNtry")
                select new Currency
                {
                    Country = node.XPathSelectElement("CtryNm")?.Value,
                    Code = node.XPathSelectElement("Ccy")?.Value,
                    Name = node.XPathSelectElement("CcyNm")?.Value,
                    Num = node.XPathSelectElement("CcyNbr")?.Value
                }).ToList();

            return _instance;
        }

        public IEnumerable<Currency> GetCurrenciesByNumber(string number)
        {
            return _codes.FindAll(x => x.Num == number);
        }

        public string GetCodeByNumber(string number)
        {
            return _codes.FirstOrDefault(x => x.Num == number)?.Code;
        }
    }
}
