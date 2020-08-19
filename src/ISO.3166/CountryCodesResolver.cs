using ISO._3166.Models;
using System.Collections.Generic;
using System.Linq;

namespace ISO._3166
{
    public static class CountryCodesResolver
    {
        private static List<CountryCode> Codes { get; set; }

        static CountryCodesResolver()
        {
            Codes = new List<CountryCode>
            {
                new CountryCode {Alpha2 = "AF", Alpha3 = "AFG", Name = "Afghanistan", NumericCode = "004"},
                new CountryCode {Alpha2 = "AX", Alpha3 = "ALA", Name = "Åland Islands", NumericCode = "248"},
                new CountryCode {Alpha2 = "AL", Alpha3 = "ALB", Name = "Albania", NumericCode = "008"},
                new CountryCode {Alpha2 = "DZ", Alpha3 = "DZA", Name = "Algeria", NumericCode = "012"},
                new CountryCode {Alpha2 = "AS", Alpha3 = "ASM", Name = "American Samoa", NumericCode = "016"},
                new CountryCode {Alpha2 = "AD", Alpha3 = "AND", Name = "Andorra", NumericCode = "020"},
                new CountryCode {Alpha2 = "AO", Alpha3 = "AGO", Name = "Angola", NumericCode = "024"},
                new CountryCode {Alpha2 = "AI", Alpha3 = "AIA", Name = "Anguilla", NumericCode = "660"},
                new CountryCode {Alpha2 = "AQ", Alpha3 = "ATA", Name = "Antarctica", NumericCode = "010"},
                new CountryCode {Alpha2 = "AG", Alpha3 = "ATG", Name = "Antigua and Barbuda", NumericCode = "028"},
                new CountryCode {Alpha2 = "AR", Alpha3 = "ARG", Name = "Argentina", NumericCode = "032"},
                new CountryCode {Alpha2 = "AM", Alpha3 = "ARM", Name = "Armenia", NumericCode = "051"},
                new CountryCode {Alpha2 = "AW", Alpha3 = "ABW", Name = "Aruba", NumericCode = "533"},
                new CountryCode {Alpha2 = "AU", Alpha3 = "AUS", Name = "Australia", NumericCode = "036"},
                new CountryCode {Alpha2 = "AT", Alpha3 = "AUT", Name = "Austria", NumericCode = "040"},
                new CountryCode {Alpha2 = "AZ", Alpha3 = "AZE", Name = "Azerbaijan", NumericCode = "031"},
                new CountryCode {Alpha2 = "BS", Alpha3 = "BHS", Name = "Bahamas", NumericCode = "044"},
                new CountryCode {Alpha2 = "BH", Alpha3 = "BHR", Name = "Bahrain", NumericCode = "048"},
                new CountryCode {Alpha2 = "BD", Alpha3 = "BGD", Name = "Bangladesh", NumericCode = "050"},
                new CountryCode {Alpha2 = "BB", Alpha3 = "BRB", Name = "Barbados", NumericCode = "052"},
                new CountryCode {Alpha2 = "BY", Alpha3 = "BLR", Name = "Belarus", NumericCode = "112"},
                new CountryCode {Alpha2 = "BE", Alpha3 = "BEL", Name = "Belgium", NumericCode = "056"},
                new CountryCode {Alpha2 = "BZ", Alpha3 = "BLZ", Name = "Belize", NumericCode = "084"},
                new CountryCode {Alpha2 = "BJ", Alpha3 = "BEN", Name = "Benin", NumericCode = "204"},
                new CountryCode {Alpha2 = "BM", Alpha3 = "BMU", Name = "Bermuda", NumericCode = "060"},
                new CountryCode {Alpha2 = "BT", Alpha3 = "BTN", Name = "Bhutan", NumericCode = "064"},
                new CountryCode
                    {Alpha2 = "BO", Alpha3 = "BOL", Name = "Bolivia (Plurinational State of)", NumericCode = "068"},
                new CountryCode
                    {Alpha2 = "BQ", Alpha3 = "BES", Name = "Bonaire, Sint Eustatius and Saba", NumericCode = "535"},
                new CountryCode {Alpha2 = "BA", Alpha3 = "BIH", Name = "Bosnia and Herzegovina", NumericCode = "070"},
                new CountryCode {Alpha2 = "BW", Alpha3 = "BWA", Name = "Botswana", NumericCode = "072"},
                new CountryCode {Alpha2 = "BV", Alpha3 = "BVT", Name = "Bouvet Island", NumericCode = "074"},
                new CountryCode {Alpha2 = "BR", Alpha3 = "BRA", Name = "Brazil", NumericCode = "076"},
                new CountryCode
                    {Alpha2 = "IO", Alpha3 = "IOT", Name = "British Indian Ocean Territory", NumericCode = "086"},
                new CountryCode {Alpha2 = "BN", Alpha3 = "BRN", Name = "Brunei Darussalam", NumericCode = "096"},
                new CountryCode {Alpha2 = "BG", Alpha3 = "BGR", Name = "Bulgaria", NumericCode = "100"},
                new CountryCode {Alpha2 = "BF", Alpha3 = "BFA", Name = "Burkina Faso", NumericCode = "854"},
                new CountryCode {Alpha2 = "BI", Alpha3 = "BDI", Name = "Burundi", NumericCode = "108"},
                new CountryCode {Alpha2 = "CV", Alpha3 = "CPV", Name = "Cabo Verde", NumericCode = "132"},
                new CountryCode {Alpha2 = "KH", Alpha3 = "KHM", Name = "Cambodia", NumericCode = "116"},
                new CountryCode {Alpha2 = "CM", Alpha3 = "CMR", Name = "Cameroon", NumericCode = "120"},
                new CountryCode {Alpha2 = "CA", Alpha3 = "CAN", Name = "Canada", NumericCode = "124"},
                new CountryCode {Alpha2 = "KY", Alpha3 = "CYM", Name = "Cayman Islands", NumericCode = "136"},
                new CountryCode {Alpha2 = "CF", Alpha3 = "CAF", Name = "Central African Republic", NumericCode = "140"},
                new CountryCode {Alpha2 = "TD", Alpha3 = "TCD", Name = "Chad", NumericCode = "148"},
                new CountryCode {Alpha2 = "CL", Alpha3 = "CHL", Name = "Chile", NumericCode = "152"},
                new CountryCode {Alpha2 = "CN", Alpha3 = "CHN", Name = "China", NumericCode = "156"},
                new CountryCode {Alpha2 = "CX", Alpha3 = "CXR", Name = "Christmas Island", NumericCode = "162"},
                new CountryCode {Alpha2 = "CC", Alpha3 = "CCK", Name = "Cocos (Keeling) Islands", NumericCode = "166"},
                new CountryCode {Alpha2 = "CO", Alpha3 = "COL", Name = "Colombia", NumericCode = "170"},
                new CountryCode {Alpha2 = "KM", Alpha3 = "COM", Name = "Comoros", NumericCode = "174"},
                new CountryCode {Alpha2 = "CG", Alpha3 = "COG", Name = "Congo", NumericCode = "178"},
                new CountryCode
                    {Alpha2 = "CD", Alpha3 = "COD", Name = "Congo, Democratic Republic of the", NumericCode = "180"},
                new CountryCode {Alpha2 = "CK", Alpha3 = "COK", Name = "Cook Islands", NumericCode = "184"},
                new CountryCode {Alpha2 = "CR", Alpha3 = "CRI", Name = "Costa Rica", NumericCode = "188"},
                new CountryCode {Alpha2 = "CI", Alpha3 = "CIV", Name = "Côte d'Ivoire", NumericCode = "384"},
                new CountryCode {Alpha2 = "HR", Alpha3 = "HRV", Name = "Croatia", NumericCode = "191"},
                new CountryCode {Alpha2 = "CU", Alpha3 = "CUB", Name = "Cuba", NumericCode = "192"},
                new CountryCode {Alpha2 = "CW", Alpha3 = "CUW", Name = "Curaçao", NumericCode = "531"},
                new CountryCode {Alpha2 = "CY", Alpha3 = "CYP", Name = "Cyprus", NumericCode = "196"},
                new CountryCode {Alpha2 = "CZ", Alpha3 = "CZE", Name = "Czechia", NumericCode = "203"},
                new CountryCode {Alpha2 = "DK", Alpha3 = "DNK", Name = "Denmark", NumericCode = "208"},
                new CountryCode {Alpha2 = "DJ", Alpha3 = "DJI", Name = "Djibouti", NumericCode = "262"},
                new CountryCode {Alpha2 = "DM", Alpha3 = "DMA", Name = "Dominica", NumericCode = "212"},
                new CountryCode {Alpha2 = "DO", Alpha3 = "DOM", Name = "Dominican Republic", NumericCode = "214"},
                new CountryCode {Alpha2 = "EC", Alpha3 = "ECU", Name = "Ecuador", NumericCode = "218"},
                new CountryCode {Alpha2 = "EG", Alpha3 = "EGY", Name = "Egypt", NumericCode = "818"},
                new CountryCode {Alpha2 = "SV", Alpha3 = "SLV", Name = "El Salvador", NumericCode = "222"},
                new CountryCode {Alpha2 = "GQ", Alpha3 = "GNQ", Name = "Equatorial Guinea", NumericCode = "226"},
                new CountryCode {Alpha2 = "ER", Alpha3 = "ERI", Name = "Eritrea", NumericCode = "232"},
                new CountryCode {Alpha2 = "EE", Alpha3 = "EST", Name = "Estonia", NumericCode = "233"},
                new CountryCode {Alpha2 = "SZ", Alpha3 = "SWZ", Name = "Eswatini", NumericCode = "748"},
                new CountryCode {Alpha2 = "ET", Alpha3 = "ETH", Name = "Ethiopia", NumericCode = "231"},
                new CountryCode
                    {Alpha2 = "FK", Alpha3 = "FLK", Name = "Falkland Islands (Malvinas)", NumericCode = "238"},
                new CountryCode {Alpha2 = "FO", Alpha3 = "FRO", Name = "Faroe Islands", NumericCode = "234"},
                new CountryCode {Alpha2 = "FJ", Alpha3 = "FJI", Name = "Fiji", NumericCode = "242"},
                new CountryCode {Alpha2 = "FI", Alpha3 = "FIN", Name = "Finland", NumericCode = "246"},
                new CountryCode {Alpha2 = "FR", Alpha3 = "FRA", Name = "France", NumericCode = "250"},
                new CountryCode {Alpha2 = "GF", Alpha3 = "GUF", Name = "French Guiana", NumericCode = "254"},
                new CountryCode {Alpha2 = "PF", Alpha3 = "PYF", Name = "French Polynesia", NumericCode = "258"},
                new CountryCode
                    {Alpha2 = "TF", Alpha3 = "ATF", Name = "French Southern Territories", NumericCode = "260"},
                new CountryCode {Alpha2 = "GA", Alpha3 = "GAB", Name = "Gabon", NumericCode = "266"},
                new CountryCode {Alpha2 = "GM", Alpha3 = "GMB", Name = "Gambia", NumericCode = "270"},
                new CountryCode {Alpha2 = "GE", Alpha3 = "GEO", Name = "Georgia", NumericCode = "268"},
                new CountryCode {Alpha2 = "DE", Alpha3 = "DEU", Name = "Germany", NumericCode = "276"},
                new CountryCode {Alpha2 = "GH", Alpha3 = "GHA", Name = "Ghana", NumericCode = "288"},
                new CountryCode {Alpha2 = "GI", Alpha3 = "GIB", Name = "Gibraltar", NumericCode = "292"},
                new CountryCode {Alpha2 = "GR", Alpha3 = "GRC", Name = "Greece", NumericCode = "300"},
                new CountryCode {Alpha2 = "GL", Alpha3 = "GRL", Name = "Greenland", NumericCode = "304"},
                new CountryCode {Alpha2 = "GD", Alpha3 = "GRD", Name = "Grenada", NumericCode = "308"},
                new CountryCode {Alpha2 = "GP", Alpha3 = "GLP", Name = "Guadeloupe", NumericCode = "312"},
                new CountryCode {Alpha2 = "GU", Alpha3 = "GUM", Name = "Guam", NumericCode = "316"},
                new CountryCode {Alpha2 = "GT", Alpha3 = "GTM", Name = "Guatemala", NumericCode = "320"},
                new CountryCode {Alpha2 = "GG", Alpha3 = "GGY", Name = "Guernsey", NumericCode = "831"},
                new CountryCode {Alpha2 = "GN", Alpha3 = "GIN", Name = "Guinea", NumericCode = "324"},
                new CountryCode {Alpha2 = "GW", Alpha3 = "GNB", Name = "Guinea-Bissau", NumericCode = "624"},
                new CountryCode {Alpha2 = "GY", Alpha3 = "GUY", Name = "Guyana", NumericCode = "328"},
                new CountryCode {Alpha2 = "HT", Alpha3 = "HTI", Name = "Haiti", NumericCode = "332"},
                new CountryCode
                    {Alpha2 = "HM", Alpha3 = "HMD", Name = "Heard Island and McDonald Islands", NumericCode = "334"},
                new CountryCode {Alpha2 = "VA", Alpha3 = "VAT", Name = "Holy See", NumericCode = "336"},
                new CountryCode {Alpha2 = "HN", Alpha3 = "HND", Name = "Honduras", NumericCode = "340"},
                new CountryCode {Alpha2 = "HK", Alpha3 = "HKG", Name = "Hong Kong", NumericCode = "344"},
                new CountryCode {Alpha2 = "HU", Alpha3 = "HUN", Name = "Hungary", NumericCode = "348"},
                new CountryCode {Alpha2 = "IS", Alpha3 = "ISL", Name = "Iceland", NumericCode = "352"},
                new CountryCode {Alpha2 = "IN", Alpha3 = "IND", Name = "India", NumericCode = "356"},
                new CountryCode {Alpha2 = "ID", Alpha3 = "IDN", Name = "Indonesia", NumericCode = "360"},
                new CountryCode
                    {Alpha2 = "IR", Alpha3 = "IRN", Name = "Iran (Islamic Republic of)", NumericCode = "364"},
                new CountryCode {Alpha2 = "IQ", Alpha3 = "IRQ", Name = "Iraq", NumericCode = "368"},
                new CountryCode {Alpha2 = "IE", Alpha3 = "IRL", Name = "Ireland", NumericCode = "372"},
                new CountryCode {Alpha2 = "IM", Alpha3 = "IMN", Name = "Isle of Man", NumericCode = "833"},
                new CountryCode {Alpha2 = "IL", Alpha3 = "ISR", Name = "Israel", NumericCode = "376"},
                new CountryCode {Alpha2 = "IT", Alpha3 = "ITA", Name = "Italy", NumericCode = "380"},
                new CountryCode {Alpha2 = "JM", Alpha3 = "JAM", Name = "Jamaica", NumericCode = "388"},
                new CountryCode {Alpha2 = "JP", Alpha3 = "JPN", Name = "Japan", NumericCode = "392"},
                new CountryCode {Alpha2 = "JE", Alpha3 = "JEY", Name = "Jersey", NumericCode = "832"},
                new CountryCode {Alpha2 = "JO", Alpha3 = "JOR", Name = "Jordan", NumericCode = "400"},
                new CountryCode {Alpha2 = "KZ", Alpha3 = "KAZ", Name = "Kazakhstan", NumericCode = "398"},
                new CountryCode {Alpha2 = "KE", Alpha3 = "KEN", Name = "Kenya", NumericCode = "404"},
                new CountryCode {Alpha2 = "KI", Alpha3 = "KIR", Name = "Kiribati", NumericCode = "296"},
                new CountryCode
                {
                    Alpha2 = "KP", Alpha3 = "PRK", Name = "Korea (Democratic People's Republic of)", NumericCode = "408"
                },
                new CountryCode {Alpha2 = "KR", Alpha3 = "KOR", Name = "Korea, Republic of", NumericCode = "410"},
                new CountryCode {Alpha2 = "KW", Alpha3 = "KWT", Name = "Kuwait", NumericCode = "414"},
                new CountryCode {Alpha2 = "KG", Alpha3 = "KGZ", Name = "Kyrgyzstan", NumericCode = "417"},
                new CountryCode
                    {Alpha2 = "LA", Alpha3 = "LAO", Name = "Lao People's Democratic Republic", NumericCode = "418"},
                new CountryCode {Alpha2 = "LV", Alpha3 = "LVA", Name = "Latvia", NumericCode = "428"},
                new CountryCode {Alpha2 = "LB", Alpha3 = "LBN", Name = "Lebanon", NumericCode = "422"},
                new CountryCode {Alpha2 = "LS", Alpha3 = "LSO", Name = "Lesotho", NumericCode = "426"},
                new CountryCode {Alpha2 = "LR", Alpha3 = "LBR", Name = "Liberia", NumericCode = "430"},
                new CountryCode {Alpha2 = "LY", Alpha3 = "LBY", Name = "Libya", NumericCode = "434"},
                new CountryCode {Alpha2 = "LI", Alpha3 = "LIE", Name = "Liechtenstein", NumericCode = "438"},
                new CountryCode {Alpha2 = "LT", Alpha3 = "LTU", Name = "Lithuania", NumericCode = "440"},
                new CountryCode {Alpha2 = "LU", Alpha3 = "LUX", Name = "Luxembourg", NumericCode = "442"},
                new CountryCode {Alpha2 = "MO", Alpha3 = "MAC", Name = "Macao", NumericCode = "446"},
                new CountryCode {Alpha2 = "MG", Alpha3 = "MDG", Name = "Madagascar", NumericCode = "450"},
                new CountryCode {Alpha2 = "MW", Alpha3 = "MWI", Name = "Malawi", NumericCode = "454"},
                new CountryCode {Alpha2 = "MY", Alpha3 = "MYS", Name = "Malaysia", NumericCode = "458"},
                new CountryCode {Alpha2 = "MV", Alpha3 = "MDV", Name = "Maldives", NumericCode = "462"},
                new CountryCode {Alpha2 = "ML", Alpha3 = "MLI", Name = "Mali", NumericCode = "466"},
                new CountryCode {Alpha2 = "MT", Alpha3 = "MLT", Name = "Malta", NumericCode = "470"},
                new CountryCode {Alpha2 = "MH", Alpha3 = "MHL", Name = "Marshall Islands", NumericCode = "584"},
                new CountryCode {Alpha2 = "MQ", Alpha3 = "MTQ", Name = "Martinique", NumericCode = "474"},
                new CountryCode {Alpha2 = "MR", Alpha3 = "MRT", Name = "Mauritania", NumericCode = "478"},
                new CountryCode {Alpha2 = "MU", Alpha3 = "MUS", Name = "Mauritius", NumericCode = "480"},
                new CountryCode {Alpha2 = "YT", Alpha3 = "MYT", Name = "Mayotte", NumericCode = "175"},
                new CountryCode {Alpha2 = "MX", Alpha3 = "MEX", Name = "Mexico", NumericCode = "484"},
                new CountryCode
                    {Alpha2 = "FM", Alpha3 = "FSM", Name = "Micronesia (Federated States of)", NumericCode = "583"},
                new CountryCode {Alpha2 = "MD", Alpha3 = "MDA", Name = "Moldova, Republic of", NumericCode = "498"},
                new CountryCode {Alpha2 = "MC", Alpha3 = "MCO", Name = "Monaco", NumericCode = "492"},
                new CountryCode {Alpha2 = "MN", Alpha3 = "MNG", Name = "Mongolia", NumericCode = "496"},
                new CountryCode {Alpha2 = "ME", Alpha3 = "MNE", Name = "Montenegro", NumericCode = "499"},
                new CountryCode {Alpha2 = "MS", Alpha3 = "MSR", Name = "Montserrat", NumericCode = "500"},
                new CountryCode {Alpha2 = "MA", Alpha3 = "MAR", Name = "Morocco", NumericCode = "504"},
                new CountryCode {Alpha2 = "MZ", Alpha3 = "MOZ", Name = "Mozambique", NumericCode = "508"},
                new CountryCode {Alpha2 = "MM", Alpha3 = "MMR", Name = "Myanmar", NumericCode = "104"},
                new CountryCode {Alpha2 = "NA", Alpha3 = "NAM", Name = "Namibia", NumericCode = "516"},
                new CountryCode {Alpha2 = "NR", Alpha3 = "NRU", Name = "Nauru", NumericCode = "520"},
                new CountryCode {Alpha2 = "NP", Alpha3 = "NPL", Name = "Nepal", NumericCode = "524"},
                new CountryCode {Alpha2 = "NL", Alpha3 = "NLD", Name = "Netherlands", NumericCode = "528"},
                new CountryCode {Alpha2 = "NC", Alpha3 = "NCL", Name = "New Caledonia", NumericCode = "540"},
                new CountryCode {Alpha2 = "NZ", Alpha3 = "NZL", Name = "New Zealand", NumericCode = "554"},
                new CountryCode {Alpha2 = "NI", Alpha3 = "NIC", Name = "Nicaragua", NumericCode = "558"},
                new CountryCode {Alpha2 = "NE", Alpha3 = "NER", Name = "Niger", NumericCode = "562"},
                new CountryCode {Alpha2 = "NG", Alpha3 = "NGA", Name = "Nigeria", NumericCode = "566"},
                new CountryCode {Alpha2 = "NU", Alpha3 = "NIU", Name = "Niue", NumericCode = "570"},
                new CountryCode {Alpha2 = "NF", Alpha3 = "NFK", Name = "Norfolk Island", NumericCode = "574"},
                new CountryCode {Alpha2 = "MK", Alpha3 = "MKD", Name = "North Macedonia", NumericCode = "807"},
                new CountryCode {Alpha2 = "MP", Alpha3 = "MNP", Name = "Northern Mariana Islands", NumericCode = "580"},
                new CountryCode {Alpha2 = "NO", Alpha3 = "NOR", Name = "Norway", NumericCode = "578"},
                new CountryCode {Alpha2 = "OM", Alpha3 = "OMN", Name = "Oman", NumericCode = "512"},
                new CountryCode {Alpha2 = "PK", Alpha3 = "PAK", Name = "Pakistan", NumericCode = "586"},
                new CountryCode {Alpha2 = "PW", Alpha3 = "PLW", Name = "Palau", NumericCode = "585"},
                new CountryCode {Alpha2 = "PS", Alpha3 = "PSE", Name = "Palestine, State of", NumericCode = "275"},
                new CountryCode {Alpha2 = "PA", Alpha3 = "PAN", Name = "Panama", NumericCode = "591"},
                new CountryCode {Alpha2 = "PG", Alpha3 = "PNG", Name = "Papua New Guinea", NumericCode = "598"},
                new CountryCode {Alpha2 = "PY", Alpha3 = "PRY", Name = "Paraguay", NumericCode = "600"},
                new CountryCode {Alpha2 = "PE", Alpha3 = "PER", Name = "Peru", NumericCode = "604"},
                new CountryCode {Alpha2 = "PH", Alpha3 = "PHL", Name = "Philippines", NumericCode = "608"},
                new CountryCode {Alpha2 = "PN", Alpha3 = "PCN", Name = "Pitcairn", NumericCode = "612"},
                new CountryCode {Alpha2 = "PL", Alpha3 = "POL", Name = "Poland", NumericCode = "616"},
                new CountryCode {Alpha2 = "PT", Alpha3 = "PRT", Name = "Portugal", NumericCode = "620"},
                new CountryCode {Alpha2 = "PR", Alpha3 = "PRI", Name = "Puerto Rico", NumericCode = "630"},
                new CountryCode {Alpha2 = "QA", Alpha3 = "QAT", Name = "Qatar", NumericCode = "634"},
                new CountryCode {Alpha2 = "RE", Alpha3 = "REU", Name = "Réunion", NumericCode = "638"},
                new CountryCode {Alpha2 = "RO", Alpha3 = "ROU", Name = "Romania", NumericCode = "642"},
                new CountryCode {Alpha2 = "RU", Alpha3 = "RUS", Name = "Russian Federation", NumericCode = "643"},
                new CountryCode {Alpha2 = "RW", Alpha3 = "RWA", Name = "Rwanda", NumericCode = "646"},
                new CountryCode {Alpha2 = "BL", Alpha3 = "BLM", Name = "Saint Barthélemy", NumericCode = "652"},
                new CountryCode
                {
                    Alpha2 = "SH", Alpha3 = "SHN", Name = "Saint Helena, Ascension and Tristan da Cunha",
                    NumericCode = "654"
                },
                new CountryCode {Alpha2 = "KN", Alpha3 = "KNA", Name = "Saint Kitts and Nevis", NumericCode = "659"},
                new CountryCode {Alpha2 = "LC", Alpha3 = "LCA", Name = "Saint Lucia", NumericCode = "662"},
                new CountryCode
                    {Alpha2 = "MF", Alpha3 = "MAF", Name = "Saint Martin (French part)", NumericCode = "663"},
                new CountryCode
                    {Alpha2 = "PM", Alpha3 = "SPM", Name = "Saint Pierre and Miquelon", NumericCode = "666"},
                new CountryCode
                    {Alpha2 = "VC", Alpha3 = "VCT", Name = "Saint Vincent and the Grenadines", NumericCode = "670"},
                new CountryCode {Alpha2 = "WS", Alpha3 = "WSM", Name = "Samoa", NumericCode = "882"},
                new CountryCode {Alpha2 = "SM", Alpha3 = "SMR", Name = "San Marino", NumericCode = "674"},
                new CountryCode {Alpha2 = "ST", Alpha3 = "STP", Name = "Sao Tome and Principe", NumericCode = "678"},
                new CountryCode {Alpha2 = "SA", Alpha3 = "SAU", Name = "Saudi Arabia", NumericCode = "682"},
                new CountryCode {Alpha2 = "SN", Alpha3 = "SEN", Name = "Senegal", NumericCode = "686"},
                new CountryCode {Alpha2 = "RS", Alpha3 = "SRB", Name = "Serbia", NumericCode = "688"},
                new CountryCode {Alpha2 = "SC", Alpha3 = "SYC", Name = "Seychelles", NumericCode = "690"},
                new CountryCode {Alpha2 = "SL", Alpha3 = "SLE", Name = "Sierra Leone", NumericCode = "694"},
                new CountryCode {Alpha2 = "SG", Alpha3 = "SGP", Name = "Singapore", NumericCode = "702"},
                new CountryCode
                    {Alpha2 = "SX", Alpha3 = "SXM", Name = "Sint Maarten (Dutch part)", NumericCode = "534"},
                new CountryCode {Alpha2 = "SK", Alpha3 = "SVK", Name = "Slovakia", NumericCode = "703"},
                new CountryCode {Alpha2 = "SI", Alpha3 = "SVN", Name = "Slovenia", NumericCode = "705"},
                new CountryCode {Alpha2 = "SB", Alpha3 = "SLB", Name = "Solomon Islands", NumericCode = "090"},
                new CountryCode {Alpha2 = "SO", Alpha3 = "SOM", Name = "Somalia", NumericCode = "706"},
                new CountryCode {Alpha2 = "ZA", Alpha3 = "ZAF", Name = "South Africa", NumericCode = "710"},
                new CountryCode
                {
                    Alpha2 = "GS", Alpha3 = "SGS", Name = "South Georgia and the South Sandwich Islands",
                    NumericCode = "239"
                },
                new CountryCode {Alpha2 = "SS", Alpha3 = "SSD", Name = "South Sudan", NumericCode = "728"},
                new CountryCode {Alpha2 = "ES", Alpha3 = "ESP", Name = "Spain", NumericCode = "724"},
                new CountryCode {Alpha2 = "LK", Alpha3 = "LKA", Name = "Sri Lanka", NumericCode = "144"},
                new CountryCode {Alpha2 = "SD", Alpha3 = "SDN", Name = "Sudan", NumericCode = "729"},
                new CountryCode {Alpha2 = "SR", Alpha3 = "SUR", Name = "Suriname", NumericCode = "740"},
                new CountryCode {Alpha2 = "SJ", Alpha3 = "SJM", Name = "Svalbard and Jan Mayen", NumericCode = "744"},
                new CountryCode {Alpha2 = "SE", Alpha3 = "SWE", Name = "Sweden", NumericCode = "752"},
                new CountryCode {Alpha2 = "CH", Alpha3 = "CHE", Name = "Switzerland", NumericCode = "756"},
                new CountryCode {Alpha2 = "SY", Alpha3 = "SYR", Name = "Syrian Arab Republic", NumericCode = "760"},
                new CountryCode
                    {Alpha2 = "TW", Alpha3 = "TWN", Name = "Taiwan, Province of China", NumericCode = "158"},
                new CountryCode {Alpha2 = "TJ", Alpha3 = "TJK", Name = "Tajikistan", NumericCode = "762"},
                new CountryCode
                    {Alpha2 = "TZ", Alpha3 = "TZA", Name = "Tanzania", NumericCode = "834"},
                new CountryCode {Alpha2 = "TH", Alpha3 = "THA", Name = "Thailand", NumericCode = "764"},
                new CountryCode {Alpha2 = "TL", Alpha3 = "TLS", Name = "Timor-Leste", NumericCode = "626"},
                new CountryCode {Alpha2 = "TG", Alpha3 = "TGO", Name = "Togo", NumericCode = "768"},
                new CountryCode {Alpha2 = "TK", Alpha3 = "TKL", Name = "Tokelau", NumericCode = "772"},
                new CountryCode {Alpha2 = "TO", Alpha3 = "TON", Name = "Tonga", NumericCode = "776"},
                new CountryCode {Alpha2 = "TT", Alpha3 = "TTO", Name = "Trinidad and Tobago", NumericCode = "780"},
                new CountryCode {Alpha2 = "TN", Alpha3 = "TUN", Name = "Tunisia", NumericCode = "788"},
                new CountryCode {Alpha2 = "TR", Alpha3 = "TUR", Name = "Turkey", NumericCode = "792"},
                new CountryCode {Alpha2 = "TM", Alpha3 = "TKM", Name = "Turkmenistan", NumericCode = "795"},
                new CountryCode {Alpha2 = "TC", Alpha3 = "TCA", Name = "Turks and Caicos Islands", NumericCode = "796"},
                new CountryCode {Alpha2 = "TV", Alpha3 = "TUV", Name = "Tuvalu", NumericCode = "798"},
                new CountryCode {Alpha2 = "UG", Alpha3 = "UGA", Name = "Uganda", NumericCode = "800"},
                new CountryCode {Alpha2 = "UA", Alpha3 = "UKR", Name = "Ukraine", NumericCode = "804"},
                new CountryCode {Alpha2 = "AE", Alpha3 = "ARE", Name = "United Arab Emirates", NumericCode = "784"},
                new CountryCode {Alpha2 = "GB", Alpha3 = "GBR", Name = "United Kingdom", NumericCode = "826"},
                new CountryCode {Alpha2 = "US", Alpha3 = "USA", Name = "United States", NumericCode = "840"},
                new CountryCode
                    {Alpha2 = "UM", Alpha3 = "UMI", Name = "United States Minor Outlying Islands", NumericCode = "581"},
                new CountryCode {Alpha2 = "UY", Alpha3 = "URY", Name = "Uruguay", NumericCode = "858"},
                new CountryCode {Alpha2 = "UZ", Alpha3 = "UZB", Name = "Uzbekistan", NumericCode = "860"},
                new CountryCode {Alpha2 = "VU", Alpha3 = "VUT", Name = "Vanuatu", NumericCode = "548"},
                new CountryCode
                    {Alpha2 = "VE", Alpha3 = "VEN", Name = "Venezuela (Bolivarian Republic of)", NumericCode = "862"},
                new CountryCode {Alpha2 = "VN", Alpha3 = "VNM", Name = "Viet Nam", NumericCode = "704"},
                new CountryCode {Alpha2 = "VG", Alpha3 = "VGB", Name = "Virgin Islands (British)", NumericCode = "092"},
                new CountryCode {Alpha2 = "VI", Alpha3 = "VIR", Name = "Virgin Islands (U.S.)", NumericCode = "850"},
                new CountryCode {Alpha2 = "WF", Alpha3 = "WLF", Name = "Wallis and Futuna", NumericCode = "876"},
                new CountryCode {Alpha2 = "EH", Alpha3 = "ESH", Name = "Western Sahara", NumericCode = "732"},
                new CountryCode {Alpha2 = "YE", Alpha3 = "YEM", Name = "Yemen", NumericCode = "887"},
                new CountryCode {Alpha2 = "ZM", Alpha3 = "ZMB", Name = "Zambia", NumericCode = "894"},
                new CountryCode {Alpha2 = "ZW", Alpha3 = "ZWE", Name = "Zimbabwe", NumericCode = "716"}
            };
        }

        #region Get data by code
        public static CountryCode GetByAlpha2Code(string code)
        {
            return Codes.FirstOrDefault(x => x.Alpha2 == code);
        }

        public static CountryCode GetByAlpha3Code(string code)
        {
            return Codes.FirstOrDefault(x => x.Alpha3 == code);
        }

        public static List<CountryCode> GetList()
        {
            return Codes;
        }
        #endregion
    }
}
