using System.ComponentModel.Annotations;


namespace Mc.TD.Upload.Domain.DataMatch
{
    public class Requestdetail
    {
        [Required(AllowEmptyStrings = false, ErrorMessage="orderId field is not present")]
        public string id { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage="orderId field is not present")]
        public string requesttype { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage="orderId field is not present")]
        public string trackid { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage="orderId field is not present")]
        public string companyname { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage="orderId field is not present")]
        public Address address { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage="orderId field is not present")]
        public string phone { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage="orderId field is not present")]
        public string url { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage="orderId field is not present")]
        public string contact { get; set; }
        
        
        public string ein { get; set; }
        public string tin { get; set; }
        public string vat { get; set; }
        public string registrationnumber { get; set; }
        public string updatetype { get; set; }
        public Linking linking { get; set; }
        public CustomFields customfields { get; set; }
}
}
