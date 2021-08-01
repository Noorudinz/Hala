using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HALA.DTO.RequestResponseWrappers
{
 
    public class GetContentRequest
    {
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }
    }

    public class GetContentResponse : Transaction
    {
        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
    }
}
