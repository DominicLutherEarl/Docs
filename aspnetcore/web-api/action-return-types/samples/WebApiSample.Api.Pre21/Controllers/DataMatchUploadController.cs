using Mc.TD.Upload.Base.Interfaces.DataMatch;
using Mc.TD.Upload.Domain.DataMatch;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.ComponentModel.DataAnnotations;

namespace Mc.TD.Upload.Api.Controllers
{
    public class DataMatchUploadController : ApiController
    {
        private readonly IDataMatchUploadService _dataMatchUploadResponse;

        public DataMatchUploadController(IDataMatchUploadService dataMatchUploadResponse)
        {
            _dataMatchUploadResponse = dataMatchUploadResponse;
        }
        [HttpPost]
        [ResponseType(typeof(DataMatchUploadResponse))]UploadedFile
        public async Task<HttpResponseMessage> PostMatchedDataFiles([FromBody] DataMatchUploadRequestBody UploadedFile)
        {
        var result = new List<validationresult>();
        var context = new ValidationContext( UploadedFile,null,null);
        if(!(!Validator.ValidateProperty(UploadedFile, new ValidationContext(UploadedFile, null, null), result) 
            || !Validator.ValidateProperty(UploadedFile.Requestheader, new ValidationContext(UploadedFile.Requestheader, null, null), result)
             || !Validator.ValidateProperty(UploadedFile.RequestDetails, new ValidationContext(UploadedFile.RequestDetails, null, null), result)
             ))
        {
        DataMatchUploadResponse _response = new DataMatchUploadResponse();
        _response.statuscode = 500;
        return GenerateResponse(_response);
        }

            System.Net.Http.Headers.HttpRequestHeaders headers = this.Request.Headers;
            string businessId = string.Empty;
            string fileId = string.Empty;
            if(headers.Contains("businessId"))
            {
                businessId = headers.GetValues("businessId").FirstOrDefault();
            }
            if (headers.Contains("businessId"))
            {
                fileId = headers.GetValues("fileId").FirstOrDefault();
            }
            return GenerateResponse( await _dataMatchUploadResponse.UploadDataMatchFile(UploadedFile, businessId, fileId));
        }

        private HttpResponseMessage GenerateResponse(DataMatchUploadResponse response )
        {
            var result = new HttpResponseMessage();
            if (response.statusCode == 400)
                result =  Request.CreateResponse(HttpStatusCode.BadRequest, response);

            if (response.statusCode == 409)
                result = Request.CreateResponse(HttpStatusCode.Conflict, response);

            if (response.statusCode == 202)
                result = Request.CreateResponse(HttpStatusCode.Accepted, response);

            if (response.statusCode == 500)
                result = Request.CreateResponse(HttpStatusCode.InternalServerError, response);


            return result;
        }

    }
}
