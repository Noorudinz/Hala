using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HALA.DL.BO
{
    public class GetContentRequest 
    {
        public string ContentType{ get; set; }
    }
  
    public class GetContentResponse : TransactionWrapper
    {
        public string Content { get; set; }      
    }
 
}
