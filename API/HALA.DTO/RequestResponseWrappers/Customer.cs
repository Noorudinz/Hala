using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HALA.DTO.RequestResponseWrappers
{
    public class CustomerMasterReq
    {
        [JsonProperty(PropertyName = "customerId")]
        public int CustomerId { get; set; }
        [JsonProperty(PropertyName = "customerName")]       
        public string CustomerName { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "password")]        
        public string Password { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }

    public class CustomerMasterRes : Transaction
    {
        [JsonProperty(PropertyName = "insuredCode")]
        public string InsuredCode { get; set; }
        [JsonProperty(PropertyName = "insuredName")]
        public string InsuredName { get; set; }
        [JsonProperty(PropertyName = "isUserAlreadyExists")]
        public bool IsUserAlreadyExists { get; set; }
        [JsonProperty(PropertyName = "passwordStrength")]
        public bool PasswordStrength { get; set; }
    }

    public class CustomerDetailsResult : Transaction
    {
        [JsonProperty(PropertyName = "customerName")]
        public string CustomerName { get; set; }
        [JsonProperty(PropertyName = "customerID")]
        public int CustomerID { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }
}
