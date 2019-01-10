namespace MC.TD.Upload.Domain.DataMatch
{
public class RequestDetails
  {

        [Required(AllowEmptyStrings = false)]
        public string orderid { get; set; }

  [Required(AllowEmptyStrings = false)]
        public string ordertype { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string businessid { get; set; }

        public string matchtype { get; set; }

        public string noofrecords { get; set; }

        public string email { get; set; }  

  }
}
