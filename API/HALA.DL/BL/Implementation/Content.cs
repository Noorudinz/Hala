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

            //var addString = new GetContentResponse();

            //addString = (from DataRow dr in ds.Tables[0].Rows
            //             select new GetContentResponse()
            //             {
            //                 Content = Convert.ToString(dr["ContentDetails"]),
            //             }).ToString();

            details.Content = ds.Tables[0].Rows[0]["ContentDetails"].ToString();

            return details;

            //try
            //{
            //    SqlParameter[] param = new SqlParameter[] {
            //        new SqlParameter("@ContentType",type)
            //    };

            //    DataSet ds = HALASQL.eds(ContentSP.FetchHomeMainBanner, param);                

            //    var addString = new List<GetContentResponse>();

            //    addString = (from DataRow dr in ds.Tables[0].Rows
            //                 select new GetContentResponse()
            //                 {
            //                     Content = Convert.ToString(dr["ContentDetails"]),
            //                 }).ToList();

            //    details.Content = addString.ToString();

            //    return details;
            //}
            //catch (Exception ex)
            //{
            //    return new GetContentResponse
            //    {
            //        IsTransactionDone = false,
            //        TransactionErrorMessage = ex.Message
            //    };
            //}

            //return details;
        }
    }
}
