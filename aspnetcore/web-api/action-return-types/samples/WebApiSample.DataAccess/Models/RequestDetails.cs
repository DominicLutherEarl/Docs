using System.ComponentModel.Annotations;


namespace Mc.TD.Upload.Domain.DataMatch
{
    public class Requestdetail
    {
        public string id { get; set; }
        public string requesttype { get; set; }
        public string trackid { get; set; }
        public string companyname { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string url { get; set; }
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
