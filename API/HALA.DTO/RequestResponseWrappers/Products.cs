using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HALA.DTO.RequestResponseWrappers
{
    public class ProductDetails : Transaction
    {
        [JsonProperty(PropertyName = "product_Id")]
        public int ProductId { get; set; }
        [JsonProperty(PropertyName = "category_Name")]
        public string CategoryName { get; set; }
        [JsonProperty(PropertyName = "subCategory_Name")]
        public string SubCategoryName { get; set; }
        [JsonProperty(PropertyName = "product_Name")]
        public string ProductName { get; set; }
        [JsonProperty(PropertyName = "short_Desc")]
        public string ShortDesc { get; set; }
        [JsonProperty(PropertyName = "sKU")]
        public string SKU { get; set; }
    }
}
