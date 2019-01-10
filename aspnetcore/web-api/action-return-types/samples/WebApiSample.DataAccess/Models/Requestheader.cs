namespace MC.TD.Upload.Domain.DataMatch
{
public class RequestDetails
  {

        [Required(AllowEmptyStrings = false, ErrorMessage="orderId field is not present")]
        public string orderid { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string ordertype { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string businessid { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string matchtype { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string noofrecords { get; set; }
 
        [Required(AllowEmptyStrings = false)]
        public string email { get; set; }  

  }
}
