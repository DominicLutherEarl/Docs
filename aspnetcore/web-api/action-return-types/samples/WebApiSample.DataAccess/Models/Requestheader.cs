using System.ComponentModel.Annotations;

namespace MC.TD.Upload.Domain.DataMatch
{
public class RequestDetails
  {

        [Required(AllowEmptyStrings = false, ErrorMessage="orderId field is not present")]
        public string orderid { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage="ordertype field is not present")]
        public string ordertype { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage="businessId field is not present")]
        public string businessid { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage="matchtype field is not present")]
        public string matchtype { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage="noofrecords field is not present")]
        public string noofrecords { get; set; }
 

        public string email { get; set; }  

  }
}
