using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HALA.DL.BO
{
    public class PageType
    {
        public const string CustomerProfile = "CustomerProfile";
      
    }

    public class DropDownResult : TransactionWrapper
    {
        public DataSet DataSets { get; set; }
    }
}
