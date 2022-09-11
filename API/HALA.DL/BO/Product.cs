using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HALA.DL.BO
{
    public class ProductDetailsResult : TransactionWrapper
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string ProductName { get; set; }
        public string ShortDesc { get; set; }
        public string SKU { get; set; }
    }
}
