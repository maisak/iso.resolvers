using ISO._4217.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ISO._4217
{
    public static class CurrencyCodesResolver
    {
        public static long Spent { get; }

        private static List<Currency> Codes { get; set; }
        
        static CurrencyCodesResolver()
        {
            var timer = new Stopwatch();
            timer.Start();

            LoadXml();    

            timer.Stop();
            Spent = timer.ElapsedMilliseconds;
        }

        public static void LoadXml()
        {
            var document = XElement.Load(@"codes.xml");

            Codes = (from node in document.Descendants("CcyNtry")
                select new Currency
                {
                    Country = node.XPathSelectElement("CtryNm")?.Value,
                    Code = node.XPathSelectElement("Ccy")?.Value,
                    Name = node.XPathSelectElement("CcyNm")?.Value,
                    Num = node.XPathSelectElement("CcyNbr")?.Value
                }).ToList();
        }

        #region Get currency data by number
        public static IEnumerable<Currency> GetCurrenciesByNumber(string number)
        {
            return Codes.FindAll(x => x.Num == number);
        }

        public static string GetCodeByNumber(string number)
        {
            return Codes.FirstOrDefault(x => x.Num == number)?.Code;
        }

        public static string GetCurrencyNameByNumber(string number)
        {
            return Codes.FirstOrDefault(x => x.Num == number)?.Name;
        }
        #endregion
    }
}
