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

    public class OnSalesProducts : Transaction
    {

        [JsonProperty(PropertyName = "product_Id")]
        public int Product_Id { get; set; }
        [JsonProperty(PropertyName = "product_Name")]
        public string Product_Name { get; set; }
        [JsonProperty(PropertyName = "category_Name")]
        public string Category_Name { get; set; }
        [JsonProperty(PropertyName = "product_Image")]
        public string Product_Image { get; set; }
        [JsonProperty(PropertyName = "product_Price")]
        public decimal Product_Price { get; set; }

        [JsonProperty(PropertyName = "on_Sale_ProductList")]
        public List<OnSalesProducts> OnSales_ProductList { get; set; }
        public OnSalesProducts()
        {
            OnSales_ProductList = new List<OnSalesProducts>();
        }
    }
}
