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

    public class OnSalesProducts : TransactionWrapper
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public string Category_Name { get; set; }
        public string Product_Image { get; set; }
        public decimal Product_Price { get; set; }
        public List<OnSalesProducts> OnSales_ProductList { get; set; }
        public OnSalesProducts()
        {
            OnSales_ProductList = new List<OnSalesProducts>();
        }
    }

}
