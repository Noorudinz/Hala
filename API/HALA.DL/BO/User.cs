using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HALA.DL.BO
{

    public class AuthenticationResult : TransactionWrapper
    {
        public bool IsValidUser { get; set; }
    }

    public class LoginAudit
    {
        public string UserName { get; set; }
        public string IPAddress { get; set; }
        public DateTime LoginDate { get; set; }
        public string LoginStatus { get; set; }
    }  
}
