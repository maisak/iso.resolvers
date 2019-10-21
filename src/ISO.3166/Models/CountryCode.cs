using System.Runtime.Serialization;

namespace ISO._3166.Models
{
    [DataContract]
    public class CountryCode
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "alpha2")]
        public string Alpha2 { get; set; }

        [DataMember(Name = "alpha3")]
        public string Alpha3 { get; set; }

        [DataMember(Name = "country-code")]
        public string NumericCode { get; set; }
    }
}
