using HALA.DL.BL.Repositories;
using HALA.DL.BO;
using HALA.DL.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HALA.DL.BL.Implementation
{
    public class Content : IContent
    {
        public Content()
        {

        }

        public GetContentResponse FetchHomeMainBanner(string type)
        {

            GetContentResponse details = new GetContentResponse();

            SqlParameter[] param = new SqlParameter[] {
                    new SqlParameter("@ContentType",type)
                };

            DataSet ds = HALASQL.eds(ContentSP.FetchHomeMainBanner, param);

            details.Content = ds.Tables[0].Rows[0]["ContentDetails"].ToString();

            return details;

        }

        public ListOfOnSalesProducts FetchOnSalesProduct(string type)
        {
            var onSaleProducts = new ListOfOnSalesProducts();

            SqlParameter[] param = new SqlParameter[] {
                    new SqlParameter("@ContentType",type)
                };

            DataSet ds = HALASQL.eds(ContentSP.FetchHomeMainBanner, param);

            var lstSalesProducts = ds.Tables[0].AsEnumerable()
                                  .Select(x => new OnSalesProducts()
                                  {
                                      Product_Id = x.Field<int>("Product_Id"),
                                      Category_Name = x.Field<string>("CategoryName"),
                                      Product_Name = x.Field<string>("Product_Name"),
                                      Product_Image = x.Field<string>("MainImage"),
                                      Product_Price = x.Field<decimal>("Price")
                                  }).ToList();

           onSaleProducts.OnSales_ProductList = lstSalesProducts;

            return onSaleProducts;

        }
    }
}
