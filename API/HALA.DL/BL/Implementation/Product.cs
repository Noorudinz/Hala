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
    public class Product : IProduct
    {
        public Product()
        {

        }

        public ProductDetailsResult FetchProductInformation(int productId)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[] {
                    new SqlParameter("@ProductId",productId)
                };

                DataSet ds = HALASQL.eds(ProductSP.FetchProductDetails, param);
                ProductDetailsResult prodDetails = new ProductDetailsResult();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        prodDetails.ProductId = Convert.ToInt32(dr["Product_Id"]);
                        prodDetails.ProductName = Convert.ToString(dr["Product_Name"]);
                        prodDetails.CategoryName = Convert.ToString(dr["Category_Name"]);
                        prodDetails.SubCategoryName = Convert.ToString(dr["SubCategory_Name"]);
                        prodDetails.SKU = Convert.ToString(dr["SKU"]);
                        prodDetails.ShortDesc = Convert.ToString(dr["Short_Desc"]);
                     }
                    prodDetails.IsTransactionDone = true;
                }
                else
                    prodDetails.IsTransactionDone = false;

                return prodDetails;
            }
            catch (Exception ex)
            {
                return new ProductDetailsResult
                {
                    IsTransactionDone = false,
                    TransactionErrorMessage = ex.Message
                };
            }
        }
    }
}
