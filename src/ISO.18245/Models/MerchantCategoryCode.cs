using System.Runtime.Serialization;

namespace ISO._18245.Models
{
    [DataContract]
    public class MerchantCategoryCode
    {
        [DataMember(Name = "mcc")]
        public string Mcc { get; set; }
        [DataMember(Name = "edited_description")]
        public string Description { get; set; }
    }
}
