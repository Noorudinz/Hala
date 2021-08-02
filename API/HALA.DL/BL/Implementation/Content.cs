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
            try
            {
                SqlParameter[] param = new SqlParameter[] {
                    new SqlParameter("@ContentType",type)
                };

                DataSet ds = HALASQL.eds(ContentSP.FetchHomeMainBanner , param);
                GetContentResponse details = new GetContentResponse();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        details.Content = Convert.ToString(dr["ContentDetails"]);
                 
                    }
                    details.IsTransactionDone = true;
                }
                else
                    details.IsTransactionDone = false;

                return details;
            }
            catch (Exception ex)
            {
                return new GetContentResponse
                {
                    IsTransactionDone = false,
                    TransactionErrorMessage = ex.Message
                };
            }
        }
    }
}
