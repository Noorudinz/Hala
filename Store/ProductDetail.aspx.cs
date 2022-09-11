using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Newtonsoft.Json;
using System.Web.UI.HtmlControls;

namespace Store
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        private GeneralMaster master;
      
        public ProductDetail()
        {
            master = Master as GeneralMaster;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string productID = Request.QueryString["productId"].ToString();
            if (!string.IsNullOrEmpty(productID))
                GetProductDetials(productID);
        }

        public void GetProductDetials(string productID)
        {
            var service = CommonMethods.GetLogedInService();

            var url = HALA.DTO.Constants
                         .ProductURI.GetProductDetailsByProductId
                         .Replace("{productId}", productID);

            var productDetails = service.GetData<HALA.DTO.RequestResponseWrappers.ApiResponse
                              <HALA.DTO.RequestResponseWrappers.ProductDetails>>(url);

            if (productDetails.Result.IsTransactionDone)
            {
                cat.InnerText = productDetails.Result.CategoryName;
                subcat.InnerText = productDetails.Result.SubCategoryName;
                productName.InnerText = productDetails.Result.ProductName;
            }

            //return JsonConvert.SerializeObject(result);
        }
        public class AddToCart
        {
            public decimal amt { get; set; }
            public int qty { get; set; }
        }

        [WebMethod]
        public static string GetReport(string skuId, int qty)
        {
            var chk = new AddToCart
            {
                amt = Convert.ToDecimal(450.20),
                qty = qty
            };

            return JsonConvert.SerializeObject(chk);
        }


    }
}