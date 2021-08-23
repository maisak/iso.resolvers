using System;
using System.IO;
using System.Xml;

namespace ISO._4217
{
    public static class XmlParser
    {
        public static void ParseCodesFile()
        {
            var path = Directory.GetCurrentDirectory();
            var doc = new XmlDocument();
            doc.Load($"{path}/codes.xml");
            var currencies = doc.GetElementsByTagName("CcyNtry");
            foreach (XmlNode currency in currencies)
            {
                Console.WriteLine($"new Currency {{Num = \"{currency.SelectSingleNode("CcyNbr")?.InnerText}\", " +
                                  $"Code = \"{currency.SelectSingleNode("Ccy")?.InnerText}\", " +
                                  $"Name = \"{currency.SelectSingleNode("CcyNm")?.InnerText}\", " +
                                  $"Country = \"{currency.SelectSingleNode("CtryNm")?.InnerText}\", " +
                                  $"Exponent = \"{currency.SelectSingleNode("CcyMnrUnts")?.InnerText}\"}},");
            }
        }
    }
}