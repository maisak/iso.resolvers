﻿using ISO._4217.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISO._4217
{
    /// <summary>
    /// Source is here https://www.currency-iso.org/dam/downloads/lists/list_one.xml
    /// </summary>
    public static class CurrencyCodesResolver
    {
        public static List<Currency> Codes { get; set; }

        static CurrencyCodesResolver()
        {
            Codes = new List<Currency>
            {
                new Currency {Num = "971", Code = "AFN", Name = "Afghani", Country = "AFGHANISTAN"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "ÅLAND ISLANDS"},
                new Currency {Num = "008", Code = "ALL", Name = "Lek", Country = "ALBANIA"},
                new Currency {Num = "012", Code = "DZD", Name = "Algerian Dinar", Country = "ALGERIA"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "AMERICAN SAMOA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "ANDORRA"},
                new Currency {Num = "973", Code = "AOA", Name = "Kwanza", Country = "ANGOLA"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "ANGUILLA"},
                new Currency {Num = "", Code = "", Name = "No universal currency", Country = "ANTARCTICA"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "ANTIGUA AND BARBUDA"},
                new Currency {Num = "032", Code = "ARS", Name = "Argentine Peso", Country = "ARGENTINA"},
                new Currency {Num = "051", Code = "AMD", Name = "Armenian Dram", Country = "ARMENIA"},
                new Currency {Num = "533", Code = "AWG", Name = "Aruban Florin", Country = "ARUBA"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "AUSTRALIA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "AUSTRIA"},
                new Currency {Num = "944", Code = "AZN", Name = "Azerbaijan Manat", Country = "AZERBAIJAN"},
                new Currency {Num = "044", Code = "BSD", Name = "Bahamian Dollar", Country = "BAHAMAS (THE)"},
                new Currency {Num = "048", Code = "BHD", Name = "Bahraini Dinar", Country = "BAHRAIN"},
                new Currency {Num = "050", Code = "BDT", Name = "Taka", Country = "BANGLADESH"},
                new Currency {Num = "052", Code = "BBD", Name = "Barbados Dollar", Country = "BARBADOS"},
                new Currency {Num = "933", Code = "BYN", Name = "Belarusian Ruble", Country = "BELARUS"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "BELGIUM"},
                new Currency {Num = "084", Code = "BZD", Name = "Belize Dollar", Country = "BELIZE"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "BENIN"},
                new Currency {Num = "060", Code = "BMD", Name = "Bermudian Dollar", Country = "BERMUDA"},
                new Currency {Num = "356", Code = "INR", Name = "Indian Rupee", Country = "BHUTAN"},
                new Currency {Num = "064", Code = "BTN", Name = "Ngultrum", Country = "BHUTAN"},
                new Currency {Num = "068", Code = "BOB", Name = "Boliviano", Country = "BOLIVIA (PLURINATIONAL STATE OF)"},
                new Currency {Num = "984", Code = "BOV", Name = "Mvdol", Country = "BOLIVIA (PLURINATIONAL STATE OF)"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "BONAIRE, SINT EUSTATIUS AND SABA"},
                new Currency {Num = "977", Code = "BAM", Name = "Convertible Mark", Country = "BOSNIA AND HERZEGOVINA"},
                new Currency {Num = "072", Code = "BWP", Name = "Pula", Country = "BOTSWANA"},
                new Currency {Num = "578", Code = "NOK", Name = "Norwegian Krone", Country = "BOUVET ISLAND"},
                new Currency {Num = "986", Code = "BRL", Name = "Brazilian Real", Country = "BRAZIL"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "BRITISH INDIAN OCEAN TERRITORY (THE)"},
                new Currency {Num = "096", Code = "BND", Name = "Brunei Dollar", Country = "BRUNEI DARUSSALAM"},
                new Currency {Num = "975", Code = "BGN", Name = "Bulgarian Lev", Country = "BULGARIA"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "BURKINA FASO"},
                new Currency {Num = "108", Code = "BIF", Name = "Burundi Franc", Country = "BURUNDI"},
                new Currency {Num = "132", Code = "CVE", Name = "Cabo Verde Escudo", Country = "CABO VERDE"},
                new Currency {Num = "116", Code = "KHR", Name = "Riel", Country = "CAMBODIA"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "CAMEROON"},
                new Currency {Num = "124", Code = "CAD", Name = "Canadian Dollar", Country = "CANADA"},
                new Currency {Num = "136", Code = "KYD", Name = "Cayman Islands Dollar", Country = "CAYMAN ISLANDS (THE)"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "CENTRAL AFRICAN REPUBLIC (THE)"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "CHAD"},
                new Currency {Num = "152", Code = "CLP", Name = "Chilean Peso", Country = "CHILE"},
                new Currency {Num = "990", Code = "CLF", Name = "Unidad de Fomento", Country = "CHILE"},
                new Currency {Num = "156", Code = "CNY", Name = "Yuan Renminbi", Country = "CHINA"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "CHRISTMAS ISLAND"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "COCOS (KEELING) ISLANDS (THE)"},
                new Currency {Num = "170", Code = "COP", Name = "Colombian Peso", Country = "COLOMBIA"},
                new Currency {Num = "970", Code = "COU", Name = "Unidad de Valor Real", Country = "COLOMBIA"},
                new Currency {Num = "174", Code = "KMF", Name = "Comorian Franc ", Country = "COMOROS (THE)"},
                new Currency {Num = "976", Code = "CDF", Name = "Congolese Franc", Country = "CONGO (THE DEMOCRATIC REPUBLIC OF THE)"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "CONGO (THE)"},
                new Currency {Num = "554", Code = "NZD", Name = "New Zealand Dollar", Country = "COOK ISLANDS (THE)"},
                new Currency {Num = "188", Code = "CRC", Name = "Costa Rican Colon", Country = "COSTA RICA"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "CÔTE D'IVOIRE"},
                new Currency {Num = "191", Code = "HRK", Name = "Kuna", Country = "CROATIA"},
                new Currency {Num = "192", Code = "CUP", Name = "Cuban Peso", Country = "CUBA"},
                new Currency {Num = "931", Code = "CUC", Name = "Peso Convertible", Country = "CUBA"},
                new Currency {Num = "532", Code = "ANG", Name = "Netherlands Antillean Guilder", Country = "CURAÇAO"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "CYPRUS"},
                new Currency {Num = "203", Code = "CZK", Name = "Czech Koruna", Country = "CZECHIA"},
                new Currency {Num = "208", Code = "DKK", Name = "Danish Krone", Country = "DENMARK"},
                new Currency {Num = "262", Code = "DJF", Name = "Djibouti Franc", Country = "DJIBOUTI"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "DOMINICA"},
                new Currency {Num = "214", Code = "DOP", Name = "Dominican Peso", Country = "DOMINICAN REPUBLIC (THE)"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "ECUADOR"},
                new Currency {Num = "818", Code = "EGP", Name = "Egyptian Pound", Country = "EGYPT"},
                new Currency {Num = "222", Code = "SVC", Name = "El Salvador Colon", Country = "EL SALVADOR"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "EL SALVADOR"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "EQUATORIAL GUINEA"},
                new Currency {Num = "232", Code = "ERN", Name = "Nakfa", Country = "ERITREA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "ESTONIA"},
                new Currency {Num = "230", Code = "ETB", Name = "Ethiopian Birr", Country = "ETHIOPIA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "EUROPEAN UNION"},
                new Currency {Num = "238", Code = "FKP", Name = "Falkland Islands Pound", Country = "FALKLAND ISLANDS (THE) [MALVINAS]"},
                new Currency {Num = "208", Code = "DKK", Name = "Danish Krone", Country = "FAROE ISLANDS (THE)"},
                new Currency {Num = "242", Code = "FJD", Name = "Fiji Dollar", Country = "FIJI"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "FINLAND"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "FRANCE"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "FRENCH GUIANA"},
                new Currency {Num = "953", Code = "XPF", Name = "CFP Franc", Country = "FRENCH POLYNESIA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "FRENCH SOUTHERN TERRITORIES (THE)"},
                new Currency {Num = "950", Code = "XAF", Name = "CFA Franc BEAC", Country = "GABON"},
                new Currency {Num = "270", Code = "GMD", Name = "Dalasi", Country = "GAMBIA (THE)"},
                new Currency {Num = "981", Code = "GEL", Name = "Lari", Country = "GEORGIA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "GERMANY"},
                new Currency {Num = "936", Code = "GHS", Name = "Ghana Cedi", Country = "GHANA"},
                new Currency {Num = "292", Code = "GIP", Name = "Gibraltar Pound", Country = "GIBRALTAR"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "GREECE"},
                new Currency {Num = "208", Code = "DKK", Name = "Danish Krone", Country = "GREENLAND"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "GRENADA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "GUADELOUPE"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "GUAM"},
                new Currency {Num = "320", Code = "GTQ", Name = "Quetzal", Country = "GUATEMALA"},
                new Currency {Num = "826", Code = "GBP", Name = "Pound Sterling", Country = "GUERNSEY"},
                new Currency {Num = "324", Code = "GNF", Name = "Guinean Franc", Country = "GUINEA"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "GUINEA-BISSAU"},
                new Currency {Num = "328", Code = "GYD", Name = "Guyana Dollar", Country = "GUYANA"},
                new Currency {Num = "332", Code = "HTG", Name = "Gourde", Country = "HAITI"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "HAITI"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "HEARD ISLAND AND McDONALD ISLANDS"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "HOLY SEE (THE)"},
                new Currency {Num = "340", Code = "HNL", Name = "Lempira", Country = "HONDURAS"},
                new Currency {Num = "344", Code = "HKD", Name = "Hong Kong Dollar", Country = "HONG KONG"},
                new Currency {Num = "348", Code = "HUF", Name = "Forint", Country = "HUNGARY"},
                new Currency {Num = "352", Code = "ISK", Name = "Iceland Krona", Country = "ICELAND"},
                new Currency {Num = "356", Code = "INR", Name = "Indian Rupee", Country = "INDIA"},
                new Currency {Num = "360", Code = "IDR", Name = "Rupiah", Country = "INDONESIA"},
                new Currency {Num = "960", Code = "XDR", Name = "SDR (Special Drawing Right)", Country = "INTERNATIONAL MONETARY FUND (IMF) "},
                new Currency {Num = "364", Code = "IRR", Name = "Iranian Rial", Country = "IRAN (ISLAMIC REPUBLIC OF)"},
                new Currency {Num = "368", Code = "IQD", Name = "Iraqi Dinar", Country = "IRAQ"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "IRELAND"},
                new Currency {Num = "826", Code = "GBP", Name = "Pound Sterling", Country = "ISLE OF MAN"},
                new Currency {Num = "376", Code = "ILS", Name = "New Israeli Sheqel", Country = "ISRAEL"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "ITALY"},
                new Currency {Num = "388", Code = "JMD", Name = "Jamaican Dollar", Country = "JAMAICA"},
                new Currency {Num = "392", Code = "JPY", Name = "Yen", Country = "JAPAN"},
                new Currency {Num = "826", Code = "GBP", Name = "Pound Sterling", Country = "JERSEY"},
                new Currency {Num = "400", Code = "JOD", Name = "Jordanian Dinar", Country = "JORDAN"},
                new Currency {Num = "398", Code = "KZT", Name = "Tenge", Country = "KAZAKHSTAN"},
                new Currency {Num = "404", Code = "KES", Name = "Kenyan Shilling", Country = "KENYA"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "KIRIBATI"},
                new Currency {Num = "408", Code = "KPW", Name = "North Korean Won", Country = "KOREA (THE DEMOCRATIC PEOPLE’S REPUBLIC OF)"},
                new Currency {Num = "410", Code = "KRW", Name = "Won", Country = "KOREA (THE REPUBLIC OF)"},
                new Currency {Num = "414", Code = "KWD", Name = "Kuwaiti Dinar", Country = "KUWAIT"},
                new Currency {Num = "417", Code = "KGS", Name = "Som", Country = "KYRGYZSTAN"},
                new Currency {Num = "418", Code = "LAK", Name = "Lao Kip", Country = "LAO PEOPLE’S DEMOCRATIC REPUBLIC (THE)"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "LATVIA"},
                new Currency {Num = "422", Code = "LBP", Name = "Lebanese Pound", Country = "LEBANON"},
                new Currency {Num = "426", Code = "LSL", Name = "Loti", Country = "LESOTHO"},
                new Currency {Num = "710", Code = "ZAR", Name = "Rand", Country = "LESOTHO"},
                new Currency {Num = "430", Code = "LRD", Name = "Liberian Dollar", Country = "LIBERIA"},
                new Currency {Num = "434", Code = "LYD", Name = "Libyan Dinar", Country = "LIBYA"},
                new Currency {Num = "756", Code = "CHF", Name = "Swiss Franc", Country = "LIECHTENSTEIN"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "LITHUANIA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "LUXEMBOURG"},
                new Currency {Num = "446", Code = "MOP", Name = "Pataca", Country = "MACAO"},
                new Currency {Num = "807", Code = "MKD", Name = "Denar", Country = "MACEDONIA (THE FORMER YUGOSLAV REPUBLIC OF)"},
                new Currency {Num = "969", Code = "MGA", Name = "Malagasy Ariary", Country = "MADAGASCAR"},
                new Currency {Num = "454", Code = "MWK", Name = "Malawi Kwacha", Country = "MALAWI"},
                new Currency {Num = "458", Code = "MYR", Name = "Malaysian Ringgit", Country = "MALAYSIA"},
                new Currency {Num = "462", Code = "MVR", Name = "Rufiyaa", Country = "MALDIVES"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "MALI"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "MALTA"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "MARSHALL ISLANDS (THE)"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "MARTINIQUE"},
                new Currency {Num = "929", Code = "MRU", Name = "Ouguiya", Country = "MAURITANIA"},
                new Currency {Num = "480", Code = "MUR", Name = "Mauritius Rupee", Country = "MAURITIUS"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "MAYOTTE"},
                new Currency {Num = "965", Code = "XUA", Name = "ADB Unit of Account", Country = "MEMBER COUNTRIES OF THE AFRICAN DEVELOPMENT BANK GROUP"},
                new Currency {Num = "484", Code = "MXN", Name = "Mexican Peso", Country = "MEXICO"},
                new Currency {Num = "979", Code = "MXV", Name = "Mexican Unidad de Inversion (UDI)", Country = "MEXICO"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "MICRONESIA (FEDERATED STATES OF)"},
                new Currency {Num = "498", Code = "MDL", Name = "Moldovan Leu", Country = "MOLDOVA (THE REPUBLIC OF)"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "MONACO"},
                new Currency {Num = "496", Code = "MNT", Name = "Tugrik", Country = "MONGOLIA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "MONTENEGRO"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "MONTSERRAT"},
                new Currency {Num = "504", Code = "MAD", Name = "Moroccan Dirham", Country = "MOROCCO"},
                new Currency {Num = "943", Code = "MZN", Name = "Mozambique Metical", Country = "MOZAMBIQUE"},
                new Currency {Num = "104", Code = "MMK", Name = "Kyat", Country = "MYANMAR"},
                new Currency {Num = "516", Code = "NAD", Name = "Namibia Dollar", Country = "NAMIBIA"},
                new Currency {Num = "710", Code = "ZAR", Name = "Rand", Country = "NAMIBIA"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "NAURU"},
                new Currency {Num = "524", Code = "NPR", Name = "Nepalese Rupee", Country = "NEPAL"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "NETHERLANDS (THE)"},
                new Currency {Num = "953", Code = "XPF", Name = "CFP Franc", Country = "NEW CALEDONIA"},
                new Currency {Num = "554", Code = "NZD", Name = "New Zealand Dollar", Country = "NEW ZEALAND"},
                new Currency {Num = "558", Code = "NIO", Name = "Cordoba Oro", Country = "NICARAGUA"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "NIGER (THE)"},
                new Currency {Num = "566", Code = "NGN", Name = "Naira", Country = "NIGERIA"},
                new Currency {Num = "554", Code = "NZD", Name = "New Zealand Dollar", Country = "NIUE"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "NORFOLK ISLAND"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "NORTHERN MARIANA ISLANDS (THE)"},
                new Currency {Num = "578", Code = "NOK", Name = "Norwegian Krone", Country = "NORWAY"},
                new Currency {Num = "512", Code = "OMR", Name = "Rial Omani", Country = "OMAN"},
                new Currency {Num = "586", Code = "PKR", Name = "Pakistan Rupee", Country = "PAKISTAN"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "PALAU"},
                new Currency {Num = "", Code = "", Name = "No universal currency", Country = "PALESTINE, STATE OF"},
                new Currency {Num = "590", Code = "PAB", Name = "Balboa", Country = "PANAMA"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "PANAMA"},
                new Currency {Num = "598", Code = "PGK", Name = "Kina", Country = "PAPUA NEW GUINEA"},
                new Currency {Num = "600", Code = "PYG", Name = "Guarani", Country = "PARAGUAY"},
                new Currency {Num = "604", Code = "PEN", Name = "Sol", Country = "PERU"},
                new Currency {Num = "608", Code = "PHP", Name = "Philippine Peso", Country = "PHILIPPINES (THE)"},
                new Currency {Num = "554", Code = "NZD", Name = "New Zealand Dollar", Country = "PITCAIRN"},
                new Currency {Num = "985", Code = "PLN", Name = "Zloty", Country = "POLAND"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "PORTUGAL"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "PUERTO RICO"},
                new Currency {Num = "634", Code = "QAR", Name = "Qatari Rial", Country = "QATAR"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "RÉUNION"},
                new Currency {Num = "946", Code = "RON", Name = "Romanian Leu", Country = "ROMANIA"},
                new Currency {Num = "643", Code = "RUB", Name = "Russian Ruble", Country = "RUSSIAN FEDERATION (THE)"},
                new Currency {Num = "646", Code = "RWF", Name = "Rwanda Franc", Country = "RWANDA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SAINT BARTHÉLEMY"},
                new Currency {Num = "654", Code = "SHP", Name = "Saint Helena Pound", Country = "SAINT HELENA, ASCENSION AND TRISTAN DA CUNHA"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "SAINT KITTS AND NEVIS"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "SAINT LUCIA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SAINT MARTIN (FRENCH PART)"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SAINT PIERRE AND MIQUELON"},
                new Currency {Num = "951", Code = "XCD", Name = "East Caribbean Dollar", Country = "SAINT VINCENT AND THE GRENADINES"},
                new Currency {Num = "882", Code = "WST", Name = "Tala", Country = "SAMOA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SAN MARINO"},
                new Currency {Num = "930", Code = "STN", Name = "Dobra", Country = "SAO TOME AND PRINCIPE"},
                new Currency {Num = "682", Code = "SAR", Name = "Saudi Riyal", Country = "SAUDI ARABIA"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "SENEGAL"},
                new Currency {Num = "941", Code = "RSD", Name = "Serbian Dinar", Country = "SERBIA"},
                new Currency {Num = "690", Code = "SCR", Name = "Seychelles Rupee", Country = "SEYCHELLES"},
                new Currency {Num = "694", Code = "SLL", Name = "Leone", Country = "SIERRA LEONE"},
                new Currency {Num = "702", Code = "SGD", Name = "Singapore Dollar", Country = "SINGAPORE"},
                new Currency {Num = "532", Code = "ANG", Name = "Netherlands Antillean Guilder", Country = "SINT MAARTEN (DUTCH PART)"},
                new Currency {Num = "994", Code = "XSU", Name = "Sucre", Country = "SISTEMA UNITARIO DE COMPENSACION REGIONAL DE PAGOS 'SUCRE'"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SLOVAKIA"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SLOVENIA"},
                new Currency {Num = "090", Code = "SBD", Name = "Solomon Islands Dollar", Country = "SOLOMON ISLANDS"},
                new Currency {Num = "706", Code = "SOS", Name = "Somali Shilling", Country = "SOMALIA"},
                new Currency {Num = "710", Code = "ZAR", Name = "Rand", Country = "SOUTH AFRICA"},
                new Currency {Num = "", Code = "", Name = "No universal currency", Country = "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS"},
                new Currency {Num = "728", Code = "SSP", Name = "South Sudanese Pound", Country = "SOUTH SUDAN"},
                new Currency {Num = "978", Code = "EUR", Name = "Euro", Country = "SPAIN"},
                new Currency {Num = "144", Code = "LKR", Name = "Sri Lanka Rupee", Country = "SRI LANKA"},
                new Currency {Num = "938", Code = "SDG", Name = "Sudanese Pound", Country = "SUDAN (THE)"},
                new Currency {Num = "968", Code = "SRD", Name = "Surinam Dollar", Country = "SURINAME"},
                new Currency {Num = "578", Code = "NOK", Name = "Norwegian Krone", Country = "SVALBARD AND JAN MAYEN"},
                new Currency {Num = "748", Code = "SZL", Name = "Lilangeni", Country = "ESWATINI"},
                new Currency {Num = "752", Code = "SEK", Name = "Swedish Krona", Country = "SWEDEN"},
                new Currency {Num = "756", Code = "CHF", Name = "Swiss Franc", Country = "SWITZERLAND"},
                new Currency {Num = "947", Code = "CHE", Name = "WIR Euro", Country = "SWITZERLAND"},
                new Currency {Num = "948", Code = "CHW", Name = "WIR Franc", Country = "SWITZERLAND"},
                new Currency {Num = "760", Code = "SYP", Name = "Syrian Pound", Country = "SYRIAN ARAB REPUBLIC"},
                new Currency {Num = "901", Code = "TWD", Name = "New Taiwan Dollar", Country = "TAIWAN (PROVINCE OF CHINA)"},
                new Currency {Num = "972", Code = "TJS", Name = "Somoni", Country = "TAJIKISTAN"},
                new Currency {Num = "834", Code = "TZS", Name = "Tanzanian Shilling", Country = "TANZANIA, UNITED REPUBLIC OF"},
                new Currency {Num = "764", Code = "THB", Name = "Baht", Country = "THAILAND"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "TIMOR-LESTE"},
                new Currency {Num = "952", Code = "XOF", Name = "CFA Franc BCEAO", Country = "TOGO"},
                new Currency {Num = "554", Code = "NZD", Name = "New Zealand Dollar", Country = "TOKELAU"},
                new Currency {Num = "776", Code = "TOP", Name = "Pa’anga", Country = "TONGA"},
                new Currency {Num = "780", Code = "TTD", Name = "Trinidad and Tobago Dollar", Country = "TRINIDAD AND TOBAGO"},
                new Currency {Num = "788", Code = "TND", Name = "Tunisian Dinar", Country = "TUNISIA"},
                new Currency {Num = "949", Code = "TRY", Name = "Turkish Lira", Country = "TURKEY"},
                new Currency {Num = "934", Code = "TMT", Name = "Turkmenistan New Manat", Country = "TURKMENISTAN"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "TURKS AND CAICOS ISLANDS (THE)"},
                new Currency {Num = "036", Code = "AUD", Name = "Australian Dollar", Country = "TUVALU"},
                new Currency {Num = "800", Code = "UGX", Name = "Uganda Shilling", Country = "UGANDA"},
                new Currency {Num = "980", Code = "UAH", Name = "Hryvnia", Country = "UKRAINE"},
                new Currency {Num = "784", Code = "AED", Name = "UAE Dirham", Country = "UNITED ARAB EMIRATES (THE)"},
                new Currency {Num = "826", Code = "GBP", Name = "Pound Sterling", Country = "UNITED KINGDOM OF GREAT BRITAIN AND NORTHERN IRELAND (THE)"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "UNITED STATES MINOR OUTLYING ISLANDS (THE)"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "UNITED STATES OF AMERICA (THE)"},
                new Currency {Num = "997", Code = "USN", Name = "US Dollar (Next day)", Country = "UNITED STATES OF AMERICA (THE)"},
                new Currency {Num = "858", Code = "UYU", Name = "Peso Uruguayo", Country = "URUGUAY"},
                new Currency {Num = "940", Code = "UYI", Name = "Uruguay Peso en Unidades Indexadas (UI)", Country = "URUGUAY"},
                new Currency {Num = "927", Code = "UYW", Name = "Unidad Previsional", Country = "URUGUAY"},
                new Currency {Num = "860", Code = "UZS", Name = "Uzbekistan Sum", Country = "UZBEKISTAN"},
                new Currency {Num = "548", Code = "VUV", Name = "Vatu", Country = "VANUATU"},
                new Currency {Num = "928", Code = "VES", Name = "Bolívar Soberano", Country = "VENEZUELA (BOLIVARIAN REPUBLIC OF)"},
                new Currency {Num = "704", Code = "VND", Name = "Dong", Country = "VIET NAM"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "VIRGIN ISLANDS (BRITISH)"},
                new Currency {Num = "840", Code = "USD", Name = "US Dollar", Country = "VIRGIN ISLANDS (U.S.)"},
                new Currency {Num = "953", Code = "XPF", Name = "CFP Franc", Country = "WALLIS AND FUTUNA"},
                new Currency {Num = "504", Code = "MAD", Name = "Moroccan Dirham", Country = "WESTERN SAHARA"},
                new Currency {Num = "886", Code = "YER", Name = "Yemeni Rial", Country = "YEMEN"},
                new Currency {Num = "967", Code = "ZMW", Name = "Zambian Kwacha", Country = "ZAMBIA"},
                new Currency {Num = "932", Code = "ZWL", Name = "Zimbabwe Dollar", Country = "ZIMBABWE"},
                new Currency {Num = "955", Code = "XBA", Name = "Bond Markets Unit European Composite Unit (EURCO)", Country = "ZZ01_Bond Markets Unit European_EURCO"},
                new Currency {Num = "956", Code = "XBB", Name = "Bond Markets Unit European Monetary Unit (E.M.U.-6)", Country = "ZZ02_Bond Markets Unit European_EMU-6"},
                new Currency {Num = "957", Code = "XBC", Name = "Bond Markets Unit European Unit of Account 9 (E.U.A.-9)", Country = "ZZ03_Bond Markets Unit European_EUA-9"},
                new Currency {Num = "958", Code = "XBD", Name = "Bond Markets Unit European Unit of Account 17 (E.U.A.-17)", Country = "ZZ04_Bond Markets Unit European_EUA-17"},
                new Currency {Num = "963", Code = "XTS", Name = "Codes specifically reserved for testing purposes", Country = "ZZ06_Testing_Code"},
                new Currency {Num = "999", Code = "XXX", Name = "The codes assigned for transactions where no currency is involved", Country = "ZZ07_No_Currency"},
                new Currency {Num = "959", Code = "XAU", Name = "Gold", Country = "ZZ08_Gold"},
                new Currency {Num = "964", Code = "XPD", Name = "Palladium", Country = "ZZ09_Palladium"},
                new Currency {Num = "962", Code = "XPT", Name = "Platinum", Country = "ZZ10_Platinum"},
                new Currency {Num = "961", Code = "XAG", Name = "Silver", Country = "ZZ11_Silver"}
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
            return GetCodeByNumber(number.ToString());
        }

        public static string GetCurrencyNameByNumber(string number)
        {
            return Codes.FirstOrDefault(x => x.Num == number)?.Name;
        }

        public static string GetCurrencyNameByNumber(int number)
        {
            return GetCurrencyNameByNumber(number.ToString());
        }
        #endregion

        #region Get currency data by code
        /// <summary>
        /// Get currency by its international code.
        /// This operation is case insensitive.
        /// </summary>
        /// <param name="code">Code of a currency, like USD</param>
        /// <returns><see cref="Currency"/> object or <see cref="null"/> if nothing is found</returns>
        public static Currency GetCurrencyByCode(string code)
        {
            return Codes.FirstOrDefault(currency =>
                currency.Code.Equals(code, System.StringComparison.InvariantCultureIgnoreCase));
        }
        #endregion
    }
}
