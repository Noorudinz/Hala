using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HALA.DTO.RequestResponseWrappers
{
    public class Transaction
    {
        [JsonProperty(PropertyName = "isTransactionDone")]
        public bool IsTransactionDone { get; set; }
        [JsonProperty(PropertyName = "transactionErrorMessage")]
        public string TransactionErrorMessage { get; set; }
    }
}
