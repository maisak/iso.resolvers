using ISO._4217.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ISO._4217
{
    /// <summary>
    /// Source is here https://www.currency-iso.org/dam/downloads/lists/list_one.xml
    /// </summary>
    public static class CurrencyCodesResolver
    {
        public static List<Currency> Codes { get; }

        static CurrencyCodesResolver()
        {
            Codes = new List<Currency>
            {
                new Currency {Num = "971", Code = "AFN", Name = "Afghani", Country = "AFGHANISTAN", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "ÅLAND ISLANDS", Exponent = "2"},
                new Currency {Num = "008", Code = "ALL", Name = "Lek", Country = "ALBANIA", Exponent = "2"},
                new Currency {Num = "012", Code = "DZD", Name = "Algerian Dinar", Country = "ALGERIA", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "AMERICAN SAMOA", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "ANDORRA", Exponent = "2"},
                new Currency {Num = "973", Code = "AOA", Name = "Kwanza", Country = "ANGOLA", Exponent = "2"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "ANGUILLA", Exponent = "2"},
                new Currency {Num = "", Code = "", Name = "No universal currency", Country = "ANTARCTICA", Exponent = ""},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "ANTIGUA AND BARBUDA", Exponent = "2"},
                new Currency {Num = "032", Code = "ARS", Name = "Argentine Peso", Country = "ARGENTINA", Exponent = "2"},
                new Currency {Num = "051", Code = "AMD", Name = "Armenian Dram", Country = "ARMENIA", Exponent = "2"},
                new Currency {Num = "533", Code = "AWG", Name = "Aruban Florin", Country = "ARUBA", Exponent = "2"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "AUSTRALIA", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "AUSTRIA", Exponent = "2"},
                new Currency {Num = "944", Code = "AZN", Name = "Azerbaijan Manat", Country = "AZERBAIJAN", Exponent = "2"},
                new Currency {Num = "044", Code = "BSD", Name = "Bahamian Dollar", Country = "BAHAMAS (THE)", Exponent = "2"},
                new Currency {Num = "048", Code = "BHD", Name = "Bahraini Dinar", Country = "BAHRAIN", Exponent = "3"},
                new Currency {Num = "050", Code = "BDT", Name = "Taka", Country = "BANGLADESH", Exponent = "2"},
                new Currency {Num = "052", Code = "BBD", Name = "Barbados Dollar", Country = "BARBADOS", Exponent = "2"},
                new Currency {Num = "933", Code = "BYN", Name = "Belarusian Ruble", Country = "BELARUS", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "BELGIUM", Exponent = "2"},
                new Currency {Num = "084", Code = "BZD", Name = "Belize Dollar", Country = "BELIZE", Exponent = "2"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "BENIN", Exponent = "0"},
                new Currency {Num = "060", Code = "BMD", Name = "Bermudian Dollar", Country = "BERMUDA", Exponent = "2"},
                new Currency {Num = "356", Code = "INR", Name = "Indian Rupee", Country = "BHUTAN", Exponent = "2"},
                new Currency {Num = "064", Code = "BTN", Name = "Ngultrum", Country = "BHUTAN", Exponent = "2"},
                new Currency {Num = "068", Code = "BOB", Name = "Boliviano", Country = "BOLIVIA (PLURINATIONAL STATE OF)", Exponent = "2"},
                new Currency {Num = "984", Code = "BOV", Name = "Mvdol", Country = "BOLIVIA (PLURINATIONAL STATE OF)", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "BONAIRE, SINT EUSTATIUS AND SABA", Exponent = "2"},
                new Currency {Num = "977", Code = "BAM", Name = "Convertible Mark", Country = "BOSNIA AND HERZEGOVINA", Exponent = "2"},
                new Currency {Num = "072", Code = "BWP", Name = "Pula", Country = "BOTSWANA", Exponent = "2"},
                new Currency {Num = "578", Code = "NOK", Name = "Norwegian Krone", Country = "BOUVET ISLAND", Exponent = "2"},
                new Currency {Num = "986", Code = "BRL", Name = "Brazilian Real", Country = "BRAZIL", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "BRITISH INDIAN OCEAN TERRITORY (THE)", Exponent = "2"},
                new Currency {Num = "096", Code = "BND", Name = "Brunei Dollar", Country = "BRUNEI DARUSSALAM", Exponent = "2"},
                new Currency {Num = "975", Code = "BGN", Name = "Bulgarian Lev", Country = "BULGARIA", Exponent = "2"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "BURKINA FASO", Exponent = "0"},
                new Currency {Num = "108", Code = "BIF", Name = "Burundi Franc", Country = "BURUNDI", Exponent = "0"},
                new Currency {Num = "132", Code = "CVE", Name = "Cabo Verde Escudo", Country = "CABO VERDE", Exponent = "2"},
                new Currency {Num = "116", Code = "KHR", Name = "Riel", Country = "CAMBODIA", Exponent = "2"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "CAMEROON", Exponent = "0"},
                new Currency {Num = "124", Code = "CAD", Name = "Canadian Dollar", Country = "CANADA", Exponent = "2"},
                new Currency {Num = "136", Code = "KYD", Name = "Cayman Islands Dollar", Country = "CAYMAN ISLANDS (THE)", Exponent = "2"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "CENTRAL AFRICAN REPUBLIC (THE)", Exponent = "0"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "CHAD", Exponent = "0"},
                new Currency {Num = "152", Code = "CLP", Name = "Chilean Peso", Country = "CHILE", Exponent = "0"},
                new Currency {Num = "990", Code = "CLF", Name = "Unidad de Fomento", Country = "CHILE", Exponent = "4"},
                new Currency {Num = "156", Code = "CNY", Name = "Yuan Renminbi", Country = "CHINA", Exponent = "2"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "CHRISTMAS ISLAND", Exponent = "2"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "COCOS (KEELING) ISLANDS (THE)", Exponent = "2"},
                new Currency {Num = "170", Code = "COP", Name = "Colombian Peso", Country = "COLOMBIA", Exponent = "2"},
                new Currency {Num = "970", Code = "COU", Name = "Unidad de Valor Real", Country = "COLOMBIA", Exponent = "2"},
                new Currency {Num = "174", Code = "KMF", Name = "Comorian Franc ", Country = "COMOROS (THE)", Exponent = "0"},
                new Currency {Num = "976", Code = "CDF", Name = "Congolese Franc", Country = "CONGO (THE DEMOCRATIC REPUBLIC OF THE)", Exponent = "2"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "CONGO (THE)", Exponent = "0"},
                new Currency {Num = "554", Code = "NZD", Name = "New Zealand Dollar", Country = "COOK ISLANDS (THE)", Exponent = "2"},
                new Currency {Num = "188", Code = "CRC", Name = "Costa Rican Colon", Country = "COSTA RICA", Exponent = "2"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "CÔTE D'IVOIRE", Exponent = "0"},
                new Currency {Num = "191", Code = "HRK", Name = "Kuna", Country = "CROATIA", Exponent = "2"},
                new Currency {Num = "192", Code = "CUP", Name = "Cuban Peso", Country = "CUBA", Exponent = "2"},
                new Currency {Num = "931", Code = "CUC", Name = "Peso Convertible", Country = "CUBA", Exponent = "2"},
                new Currency {Num = "532", Code = "ANG", Name = "Netherlands Antillean Guilder", Country = "CURAÇAO", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "CYPRUS", Exponent = "2"},
                new Currency {Num = "203", Code = "CZK", Name = "Czech Koruna", Country = "CZECHIA", Exponent = "2"},
                new Currency {Num = "208", Code = "DKK", Name = "Danish Krone", Country = "DENMARK", Exponent = "2"},
                new Currency {Num = "262", Code = "DJF", Name = "Djibouti Franc", Country = "DJIBOUTI", Exponent = "0"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "DOMINICA", Exponent = "2"},
                new Currency {Num = "214", Code = "DOP", Name = "Dominican Peso", Country = "DOMINICAN REPUBLIC (THE)", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "ECUADOR", Exponent = "2"},
                new Currency {Num = "818", Code = "EGP", Name = "Egyptian Pound", Country = "EGYPT", Exponent = "2"},
                new Currency {Num = "222", Code = "SVC", Name = "El Salvador Colon", Country = "EL SALVADOR", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "EL SALVADOR", Exponent = "2"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "EQUATORIAL GUINEA", Exponent = "0"},
                new Currency {Num = "232", Code = "ERN", Name = "Nakfa", Country = "ERITREA", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "ESTONIA", Exponent = "2"},
                new Currency {Num = "230", Code = "ETB", Name = "Ethiopian Birr", Country = "ETHIOPIA", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "EUROPEAN UNION", Exponent = "2"},
                new Currency {Num = "238", Code = "FKP", Name = "Falkland Islands Pound", Country = "FALKLAND ISLANDS (THE) [MALVINAS]", Exponent = "2"},
                new Currency {Num = "208", Code = "DKK", Name = "Danish Krone", Country = "FAROE ISLANDS (THE)", Exponent = "2"},
                new Currency {Num = "242", Code = "FJD", Name = "Fiji Dollar", Country = "FIJI", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "FINLAND", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "FRANCE", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "FRENCH GUIANA", Exponent = "2"},
                new Currency {Num = "953", Code = "XPF", Name = "CFP Franc", Country = "FRENCH POLYNESIA", Exponent = "0"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "FRENCH SOUTHERN TERRITORIES (THE)", Exponent = "2"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "GABON", Exponent = "0"},
                new Currency {Num = "270", Code = "GMD", Name = "Dalasi", Country = "GAMBIA (THE)", Exponent = "2"},
                new Currency {Num = "981", Code = "GEL", Name = "Lari", Country = "GEORGIA", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "GERMANY", Exponent = "2"},
                new Currency {Num = "936", Code = "GHS", Name = "Ghana Cedi", Country = "GHANA", Exponent = "2"},
                new Currency {Num = "292", Code = "GIP", Name = "Gibraltar Pound", Country = "GIBRALTAR", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "GREECE", Exponent = "2"},
                new Currency {Num = "208", Code = "DKK", Name = "Danish Krone", Country = "GREENLAND", Exponent = "2"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "GRENADA", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "GUADELOUPE", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "GUAM", Exponent = "2"},
                new Currency {Num = "320", Code = "GTQ", Name = "Quetzal", Country = "GUATEMALA", Exponent = "2"},
                new Currency {Num = "826", Code = "GBP", Name = "Pound Sterling", Country = "GUERNSEY", Exponent = "2"},
                new Currency {Num = "324", Code = "GNF", Name = "Guinean Franc", Country = "GUINEA", Exponent = "0"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "GUINEA-BISSAU", Exponent = "0"},
                new Currency {Num = "328", Code = "GYD", Name = "Guyana Dollar", Country = "GUYANA", Exponent = "2"},
                new Currency {Num = "332", Code = "HTG", Name = "Gourde", Country = "HAITI", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "HAITI", Exponent = "2"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "HEARD ISLAND AND McDONALD ISLANDS", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "HOLY SEE (THE)", Exponent = "2"},
                new Currency {Num = "340", Code = "HNL", Name = "Lempira", Country = "HONDURAS", Exponent = "2"},
                new Currency {Num = "344", Code = "HKD", Name = "Hong Kong Dollar", Country = "HONG KONG", Exponent = "2"},
                new Currency {Num = "348", Code = "HUF", Name = "Forint", Country = "HUNGARY", Exponent = "2"},
                new Currency {Num = "352", Code = "ISK", Name = "Iceland Krona", Country = "ICELAND", Exponent = "0"},
                new Currency {Num = "356", Code = "INR", Name = "Indian Rupee", Country = "INDIA", Exponent = "2"},
                new Currency {Num = "360", Code = "IDR", Name = "Rupiah", Country = "INDONESIA", Exponent = "2"},
                new Currency {Num = "960", Code = "XDR", Name = "SDR (Special Drawing Right)", Country = "INTERNATIONAL MONETARY FUND (IMF) ", Exponent = "N.A."},
                new Currency {Num = "364", Code = "IRR", Name = "Iranian Rial", Country = "IRAN (ISLAMIC REPUBLIC OF)", Exponent = "2"},
                new Currency {Num = "368", Code = "IQD", Name = "Iraqi Dinar", Country = "IRAQ", Exponent = "3"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "IRELAND", Exponent = "2"},
                new Currency {Num = "826", Code = "GBP", Name = "Pound Sterling", Country = "ISLE OF MAN", Exponent = "2"},
                new Currency {Num = "376", Code = "ILS", Name = "New Israeli Sheqel", Country = "ISRAEL", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "ITALY", Exponent = "2"},
                new Currency {Num = "388", Code = "JMD", Name = "Jamaican Dollar", Country = "JAMAICA", Exponent = "2"},
                new Currency {Num = "392", Code = "JPY", Name = "Yen", Country = "JAPAN", Exponent = "0"},
                new Currency {Num = "826", Code = "GBP", Name = "Pound Sterling", Country = "JERSEY", Exponent = "2"},
                new Currency {Num = "400", Code = "JOD", Name = "Jordanian Dinar", Country = "JORDAN", Exponent = "3"},
                new Currency {Num = "398", Code = "KZT", Name = "Tenge", Country = "KAZAKHSTAN", Exponent = "2"},
                new Currency {Num = "404", Code = "KES", Name = "Kenyan Shilling", Country = "KENYA", Exponent = "2"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "KIRIBATI", Exponent = "2"},
                new Currency {Num = "408", Code = "KPW", Name = "North Korean Won", Country = "KOREA (THE DEMOCRATIC PEOPLE’S REPUBLIC OF)", Exponent = "2"},
                new Currency {Num = "410", Code = "KRW", Name = "Won", Country = "KOREA (THE REPUBLIC OF)", Exponent = "0"},
                new Currency {Num = "414", Code = "KWD", Name = "Kuwaiti Dinar", Country = "KUWAIT", Exponent = "3"},
                new Currency {Num = "417", Code = "KGS", Name = "Som", Country = "KYRGYZSTAN", Exponent = "2"},
                new Currency {Num = "418", Code = "LAK", Name = "Lao Kip", Country = "LAO PEOPLE’S DEMOCRATIC REPUBLIC (THE)", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "LATVIA", Exponent = "2"},
                new Currency {Num = "422", Code = "LBP", Name = "Lebanese Pound", Country = "LEBANON", Exponent = "2"},
                new Currency {Num = "426", Code = "LSL", Name = "Loti", Country = "LESOTHO", Exponent = "2"},
                new Currency {Num = "710", Code = "ZAR", Name = "Rand", Country = "LESOTHO", Exponent = "2"},
                new Currency {Num = "430", Code = "LRD", Name = "Liberian Dollar", Country = "LIBERIA", Exponent = "2"},
                new Currency {Num = "434", Code = "LYD", Name = "Libyan Dinar", Country = "LIBYA", Exponent = "3"},
                new Currency {Num = "756", Code = "CHF", Name = "Swiss Franc", Country = "LIECHTENSTEIN", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "LITHUANIA", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "LUXEMBOURG", Exponent = "2"},
                new Currency {Num = "446", Code = "MOP", Name = "Pataca", Country = "MACAO", Exponent = "2"},
                new Currency {Num = "807", Code = "MKD", Name = "Denar", Country = "MACEDONIA (THE FORMER YUGOSLAV REPUBLIC OF)", Exponent = "2"},
                new Currency {Num = "969", Code = "MGA", Name = "Malagasy Ariary", Country = "MADAGASCAR", Exponent = "2"},
                new Currency {Num = "454", Code = "MWK", Name = "Malawi Kwacha", Country = "MALAWI", Exponent = "2"},
                new Currency {Num = "458", Code = "MYR", Name = "Malaysian Ringgit", Country = "MALAYSIA", Exponent = "2"},
                new Currency {Num = "462", Code = "MVR", Name = "Rufiyaa", Country = "MALDIVES", Exponent = "2"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "MALI", Exponent = "0"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "MALTA", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "MARSHALL ISLANDS (THE)", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "MARTINIQUE", Exponent = "2"},
                new Currency {Num = "929", Code = "MRU", Name = "Ouguiya", Country = "MAURITANIA", Exponent = "2"},
                new Currency {Num = "480", Code = "MUR", Name = "Mauritius Rupee", Country = "MAURITIUS", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "MAYOTTE", Exponent = "2"},
                new Currency {Num = "965", Code = "XUA", Name = "ADB Unit of Account", Country = "MEMBER COUNTRIES OF THE AFRICAN DEVELOPMENT BANK GROUP", Exponent = "N.A."},
                new Currency {Num = "484", Code = "MXN", Name = "Mexican Peso", Country = "MEXICO", Exponent = "2"},
                new Currency {Num = "979", Code = "MXV", Name = "Mexican Unidad de Inversion (UDI)", Country = "MEXICO", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "MICRONESIA (FEDERATED STATES OF)", Exponent = "2"},
                new Currency {Num = "498", Code = "MDL", Name = "Moldovan Leu", Country = "MOLDOVA (THE REPUBLIC OF)", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "MONACO", Exponent = "2"},
                new Currency {Num = "496", Code = "MNT", Name = "Tugrik", Country = "MONGOLIA", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "MONTENEGRO", Exponent = "2"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "MONTSERRAT", Exponent = "2"},
                new Currency {Num = "504", Code = "MAD", Name = "Moroccan Dirham", Country = "MOROCCO", Exponent = "2"},
                new Currency {Num = "943", Code = "MZN", Name = "Mozambique Metical", Country = "MOZAMBIQUE", Exponent = "2"},
                new Currency {Num = "104", Code = "MMK", Name = "Kyat", Country = "MYANMAR", Exponent = "2"},
                new Currency {Num = "516", Code = "NAD", Name = "Namibia Dollar", Country = "NAMIBIA", Exponent = "2"},
                new Currency {Num = "710", Code = "ZAR", Name = "Rand", Country = "NAMIBIA", Exponent = "2"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "NAURU", Exponent = "2"},
                new Currency {Num = "524", Code = "NPR", Name = "Nepalese Rupee", Country = "NEPAL", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "NETHERLANDS (THE)", Exponent = "2"},
                new Currency {Num = "953", Code = "XPF", Name = "CFP Franc", Country = "NEW CALEDONIA", Exponent = "0"},
                new Currency {Num = "554", Code = "NZD", Name = "New Zealand Dollar", Country = "NEW ZEALAND", Exponent = "2"},
                new Currency {Num = "558", Code = "NIO", Name = "Cordoba Oro", Country = "NICARAGUA", Exponent = "2"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "NIGER (THE)", Exponent = "0"},
                new Currency {Num = "566", Code = "NGN", Name = "Naira", Country = "NIGERIA", Exponent = "2"},
                new Currency {Num = "554", Code = "NZD", Name = "New Zealand Dollar", Country = "NIUE", Exponent = "2"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "NORFOLK ISLAND", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "NORTHERN MARIANA ISLANDS (THE)", Exponent = "2"},
                new Currency {Num = "578", Code = "NOK", Name = "Norwegian Krone", Country = "NORWAY", Exponent = "2"},
                new Currency {Num = "512", Code = "OMR", Name = "Rial Omani", Country = "OMAN", Exponent = "3"},
                new Currency {Num = "586", Code = "PKR", Name = "Pakistan Rupee", Country = "PAKISTAN", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "PALAU", Exponent = "2"},
                new Currency {Num = "", Code = "", Name = "No universal currency", Country = "PALESTINE, STATE OF", Exponent = ""},
                new Currency {Num = "590", Code = "PAB", Name = "Balboa", Country = "PANAMA", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "PANAMA", Exponent = "2"},
                new Currency {Num = "598", Code = "PGK", Name = "Kina", Country = "PAPUA NEW GUINEA", Exponent = "2"},
                new Currency {Num = "600", Code = "PYG", Name = "Guarani", Country = "PARAGUAY", Exponent = "0"},
                new Currency {Num = "604", Code = "PEN", Name = "Sol", Country = "PERU", Exponent = "2"},
                new Currency {Num = "608", Code = "PHP", Name = "Philippine Peso", Country = "PHILIPPINES (THE)", Exponent = "2"},
                new Currency {Num = "554", Code = "NZD", Name = "New Zealand Dollar", Country = "PITCAIRN", Exponent = "2"},
                new Currency {Num = "985", Code = "PLN", Name = "Zloty", Country = "POLAND", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "PORTUGAL", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "PUERTO RICO", Exponent = "2"},
                new Currency {Num = "634", Code = "QAR", Name = "Qatari Rial", Country = "QATAR", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "RÉUNION", Exponent = "2"},
                new Currency {Num = "946", Code = "RON", Name = "Romanian Leu", Country = "ROMANIA", Exponent = "2"},
                new Currency {Num = "643", Code = "RUB", Name = "Russian Ruble", Country = "RUSSIAN FEDERATION (THE)", Exponent = "2"},
                new Currency {Num = "646", Code = "RWF", Name = "Rwanda Franc", Country = "RWANDA", Exponent = "0"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SAINT BARTHÉLEMY", Exponent = "2"},
                new Currency {Num = "654", Code = "SHP", Name = "Saint Helena Pound", Country = "SAINT HELENA, ASCENSION AND TRISTAN DA CUNHA", Exponent = "2"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "SAINT KITTS AND NEVIS", Exponent = "2"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "SAINT LUCIA", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SAINT MARTIN (FRENCH PART)", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SAINT PIERRE AND MIQUELON", Exponent = "2"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "SAINT VINCENT AND THE GRENADINES", Exponent = "2"},
                new Currency {Num = "882", Code = "WST", Name = "Tala", Country = "SAMOA", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SAN MARINO", Exponent = "2"},
                new Currency {Num = "930", Code = "STN", Name = "Dobra", Country = "SAO TOME AND PRINCIPE", Exponent = "2"},
                new Currency {Num = "682", Code = "SAR", Name = "Saudi Riyal", Country = "SAUDI ARABIA", Exponent = "2"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "SENEGAL", Exponent = "0"},
                new Currency {Num = "941", Code = "RSD", Name = "Serbian Dinar", Country = "SERBIA", Exponent = "2"},
                new Currency {Num = "690", Code = "SCR", Name = "Seychelles Rupee", Country = "SEYCHELLES", Exponent = "2"},
                new Currency {Num = "694", Code = "SLL", Name = "Leone", Country = "SIERRA LEONE", Exponent = "2"},
                new Currency {Num = "702", Code = "SGD", Name = "Singapore Dollar", Country = "SINGAPORE", Exponent = "2"},
                new Currency {Num = "532", Code = "ANG", Name = "Netherlands Antillean Guilder", Country = "SINT MAARTEN (DUTCH PART)", Exponent = "2"},
                new Currency {Num = "994", Code = "XSU", Name = "Sucre", Country = "SISTEMA UNITARIO DE COMPENSACION REGIONAL DE PAGOS SUCRE", Exponent = "N.A."},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SLOVAKIA", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SLOVENIA", Exponent = "2"},
                new Currency {Num = "090", Code = "SBD", Name = "Solomon Islands Dollar", Country = "SOLOMON ISLANDS", Exponent = "2"},
                new Currency {Num = "706", Code = "SOS", Name = "Somali Shilling", Country = "SOMALIA", Exponent = "2"},
                new Currency {Num = "710", Code = "ZAR", Name = "Rand", Country = "SOUTH AFRICA", Exponent = "2"},
                new Currency {Num = "", Code = "", Name = "No universal currency", Country = "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", Exponent = ""},
                new Currency {Num = "728", Code = "SSP", Name = "South Sudanese Pound", Country = "SOUTH SUDAN", Exponent = "2"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SPAIN", Exponent = "2"},
                new Currency {Num = "144", Code = "LKR", Name = "Sri Lanka Rupee", Country = "SRI LANKA", Exponent = "2"},
                new Currency {Num = "938", Code = "SDG", Name = "Sudanese Pound", Country = "SUDAN (THE)", Exponent = "2"},
                new Currency {Num = "968", Code = "SRD", Name = "Surinam Dollar", Country = "SURINAME", Exponent = "2"},
                new Currency {Num = "578", Code = "NOK", Name = "Norwegian Krone", Country = "SVALBARD AND JAN MAYEN", Exponent = "2"},
                new Currency {Num = "748", Code = "SZL", Name = "Lilangeni", Country = "ESWATINI", Exponent = "2"},
                new Currency {Num = "752", Code = "SEK", Name = "Swedish Krona", Country = "SWEDEN", Exponent = "2"},
                new Currency {Num = "756", Code = "CHF", Name = "Swiss Franc", Country = "SWITZERLAND", Exponent = "2"},
                new Currency {Num = "947", Code = "CHE", Name = "WIR Euro", Country = "SWITZERLAND", Exponent = "2"},
                new Currency {Num = "948", Code = "CHW", Name = "WIR Franc", Country = "SWITZERLAND", Exponent = "2"},
                new Currency {Num = "760", Code = "SYP", Name = "Syrian Pound", Country = "SYRIAN ARAB REPUBLIC", Exponent = "2"},
                new Currency {Num = "901", Code = "TWD", Name = "New Taiwan Dollar", Country = "TAIWAN (PROVINCE OF CHINA)", Exponent = "2"},
                new Currency {Num = "972", Code = "TJS", Name = "Somoni", Country = "TAJIKISTAN", Exponent = "2"},
                new Currency {Num = "834", Code = "TZS", Name = "Tanzanian Shilling", Country = "TANZANIA, UNITED REPUBLIC OF", Exponent = "2"},
                new Currency {Num = "764", Code = "THB", Name = "Baht", Country = "THAILAND", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "TIMOR-LESTE", Exponent = "2"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "TOGO", Exponent = "0"},
                new Currency {Num = "554", Code = "NZD", Name = "New Zealand Dollar", Country = "TOKELAU", Exponent = "2"},
                new Currency {Num = "776", Code = "TOP", Name = "Pa’anga", Country = "TONGA", Exponent = "2"},
                new Currency {Num = "780", Code = "TTD", Name = "Trinidad and Tobago Dollar", Country = "TRINIDAD AND TOBAGO", Exponent = "2"},
                new Currency {Num = "788", Code = "TND", Name = "Tunisian Dinar", Country = "TUNISIA", Exponent = "3"},
                new Currency {Num = "949", Code = "TRY", Name = "Turkish Lira", Country = "TURKEY", Exponent = "2"},
                new Currency {Num = "934", Code = "TMT", Name = "Turkmenistan New Manat", Country = "TURKMENISTAN", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "TURKS AND CAICOS ISLANDS (THE)", Exponent = "2"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "TUVALU", Exponent = "2"},
                new Currency {Num = "800", Code = "UGX", Name = "Uganda Shilling", Country = "UGANDA", Exponent = "0"},
                new Currency {Num = "980", Code = "UAH", Name = "Hryvnia", Country = "UKRAINE", Exponent = "2"},
                new Currency {Num = "784", Code = "AED", Name = "UAE Dirham", Country = "UNITED ARAB EMIRATES (THE)", Exponent = "2"},
                new Currency {Num = "826", Code = "GBP", Name = "Pound Sterling", Country = "UNITED KINGDOM OF GREAT BRITAIN AND NORTHERN IRELAND (THE)", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "UNITED STATES MINOR OUTLYING ISLANDS (THE)", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "UNITED STATES OF AMERICA (THE)", Exponent = "2"},
                new Currency {Num = "997", Code = "USN", Name = "US Dollar (Next day)", Country = "UNITED STATES OF AMERICA (THE)", Exponent = "2"},
                new Currency {Num = "858", Code = "UYU", Name = "Peso Uruguayo", Country = "URUGUAY", Exponent = "2"},
                new Currency {Num = "940", Code = "UYI", Name = "Uruguay Peso en Unidades Indexadas (UI)", Country = "URUGUAY", Exponent = "0"},
                new Currency {Num = "927", Code = "UYW", Name = "Unidad Previsional", Country = "URUGUAY", Exponent = "4"},
                new Currency {Num = "860", Code = "UZS", Name = "Uzbekistan Sum", Country = "UZBEKISTAN", Exponent = "2"},
                new Currency {Num = "548", Code = "VUV", Name = "Vatu", Country = "VANUATU", Exponent = "0"},
                new Currency {Num = "928", Code = "VES", Name = "Bolívar Soberano", Country = "VENEZUELA (BOLIVARIAN REPUBLIC OF)", Exponent = "2"},
                new Currency {Num = "704", Code = "VND", Name = "Dong", Country = "VIET NAM", Exponent = "0"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "VIRGIN ISLANDS (BRITISH)", Exponent = "2"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "VIRGIN ISLANDS (U.S.)", Exponent = "2"},
                new Currency {Num = "953", Code = "XPF", Name = "CFP Franc", Country = "WALLIS AND FUTUNA", Exponent = "0"},
                new Currency {Num = "504", Code = "MAD", Name = "Moroccan Dirham", Country = "WESTERN SAHARA", Exponent = "2"},
                new Currency {Num = "886", Code = "YER", Name = "Yemeni Rial", Country = "YEMEN", Exponent = "2"},
                new Currency {Num = "967", Code = "ZMW", Name = "Zambian Kwacha", Country = "ZAMBIA", Exponent = "2"},
                new Currency {Num = "932", Code = "ZWL", Name = "Zimbabwe Dollar", Country = "ZIMBABWE", Exponent = "2"},
                new Currency {Num = "955", Code = "XBA", Name = "Bond Markets Unit European Composite Unit (EURCO)", Country = "ZZ01_Bond Markets Unit European_EURCO", Exponent = "N.A."},
                new Currency {Num = "956", Code = "XBB", Name = "Bond Markets Unit European Monetary Unit (E.M.U.-6)", Country = "ZZ02_Bond Markets Unit European_EMU-6", Exponent = "N.A."},
                new Currency {Num = "957", Code = "XBC", Name = "Bond Markets Unit European Unit of Account 9 (E.U.A.-9)", Country = "ZZ03_Bond Markets Unit European_EUA-9", Exponent = "N.A."},
                new Currency {Num = "958", Code = "XBD", Name = "Bond Markets Unit European Unit of Account 17 (E.U.A.-17)", Country = "ZZ04_Bond Markets Unit European_EUA-17", Exponent = "N.A."},
                new Currency {Num = "963", Code = "XTS", Name = "Codes specifically reserved for testing purposes", Country = "ZZ06_Testing_Code", Exponent = "N.A."},
                new Currency {Num = "999", Code = "XXX", Name = "The codes assigned for transactions where no currency is involved", Country = "ZZ07_No_Currency", Exponent = "N.A."},
                new Currency {Num = "959", Code = "XAU", Name = "Gold", Country = "ZZ08_Gold", Exponent = "N.A."},
                new Currency {Num = "964", Code = "XPD", Name = "Palladium", Country = "ZZ09_Palladium", Exponent = "N.A."},
                new Currency {Num = "962", Code = "XPT", Name = "Platinum", Country = "ZZ10_Platinum", Exponent = "N.A."},
                new Currency {Num = "961", Code = "XAG", Name = "Silver", Country = "ZZ11_Silver", Exponent = "N.A."}
            };
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

        public static string GetCodeByNumber(int number)
        {
            return GetCodeByNumber(number.ToString("D3"));
        }

        public static string GetCurrencyNameByNumber(string number)
        {
            return Codes.FirstOrDefault(x => x.Num == number)?.Name;
        }

        public static string GetCurrencyNameByNumber(int number)
        {
            return GetCurrencyNameByNumber(number.ToString("D3"));
        }

        /// <summary>
        /// Get currency exponent by the number.
        /// </summary>
        /// <param name="number">3-sign number of a currency, like 978 for Euro.</param>
        /// <returns>Exponent value or 0, if not found.</returns>
        public static int GetExponentByNumber(int number)
        {
            var currency = Codes.FirstOrDefault(x => x.Num == number.ToString("D3"));
            int.TryParse(currency?.Exponent, out var exponent);
            
            return exponent;
        }
        #endregion

        #region Get currency data by code
        /// <summary>
        /// Get a list of currencies by the international code.
        /// This operation is case insensitive.
        /// </summary>
        /// <param name="code">Code of a currency, like USD.</param>
        /// <returns><see cref="List{Currency}"/> or <see langword="null"/> if nothing is found.</returns>
        public static IEnumerable<Currency> GetCurrenciesByCode(string code)
        {
            return Codes.Where(currency =>
                currency.Code.Equals(code, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// Get currency exponent by the code.
        /// </summary>
        /// <param name="code">3-letter code of a currency, like EUR for Euro.</param>
        /// <returns>Exponent value or 0, if not found.</returns>
        public static int GetExponentByCode(string code)
        {
            var currency = Codes.FirstOrDefault(x => x.Code == code);
            int.TryParse(currency?.Exponent, out var exponent);
            
            return exponent;
        }
        #endregion
    }
}
