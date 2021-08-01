using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace HALA.DTO.RequestResponseWrappers
{
    public class ApiResponse<T>
    {
        [JsonProperty(PropertyName = "version")]
        public string Version { get { return "1.0"; } set { } }

        [JsonProperty(PropertyName = "licensedBy")]
        public string LicensedBy { get { return "HALA | Store"; } set { } }

        [JsonProperty(PropertyName = "statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty(PropertyName = "requestUrl")]
        public Uri RequestUri { get; set; }

        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        [JsonProperty(PropertyName = "errorMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        [JsonProperty(PropertyName = "result", NullValueHandling = NullValueHandling.Ignore)]
        public T Result { get; set; }

   
    }
}
