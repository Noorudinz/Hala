using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HALA.DL.BO
{
    public class CustomerMasterReq
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }     
        public string Email { get; set; }      
        public string Password { get; set; }
        public string Type { get; set; }
    }

    public class CustomerMasterRes : TransactionWrapper
    {       
        public string InsuredCode { get; set; }   
        public string InsuredName { get; set; }
        public bool IsUserAlreadyExists { get; set; }
        public bool PasswordStrength { get; set; }
    }

    public class CustomerDetailsResult : TransactionWrapper
    {
        public string CustomerName { get; set; }
        public int CustomerID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
