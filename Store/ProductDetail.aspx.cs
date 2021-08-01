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