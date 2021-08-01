using HALA.DL.BL.Repositories;
using HALA.DL.BO;
using HALA.DL.StoredProcedures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Web.Security;

namespace HALA.DL.BL.Implementation
{
    public class Customer : ICustomer
    {
        public Customer()
        {

        }

        public CustomerMasterRes InsertCustomerMasterDetails(CustomerMasterReq details)
        {
            try
            {
                bool isExist = false;
              
                SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@EmailId",details.Email)
                };
                List<SPOut> outParams = new List<SPOut>() {
                new SPOut() { OutPutType = SqlDbType.Bit, ParameterName= "@IsEmailExists" },
                };
                object[] dataSet = HALASQL.GetValues(CustomerSP.EmailPrecheck, param, outParams);
                isExist = dataSet[0].ToString() == "True" ? true : false;
              

                if (!isExist)
                {
                    SqlParameter[] para = new SqlParameter[] {
                    new SqlParameter("@CustomerId",details.CustomerId),
                    new SqlParameter("@CustomerName",string.IsNullOrEmpty(details.CustomerName)?"":details.CustomerName),
                    new SqlParameter("@Email", details.Email??string.Empty),
                    new SqlParameter("@Password", details.Password??string.Empty),
                    new SqlParameter("@Type", details.Type??string.Empty)
                    };

                    if (details.Type == "insert")
                    {                     
                        MembershipUser newUser = Membership.CreateUser(details.CustomerName, details.Password, details.Email);
                        Roles.AddUserToRole(newUser.UserName, "Customer");
                    }
                    //else if (details.Type == "edit")
                    //{
                    //    var memUser = Membership.GetUser(details.CustomerName);
                    //    memUser.Email = details.Email; 
                    //    memUser.ChangePassword(memUser.ResetPassword(), details.Password);                      
                    //    Membership.UpdateUser(memUser);
                    //}
                    HALASQL.enq(CustomerSP.PostCustomerMaster, para);

                    return new CustomerMasterRes
                    {
                        IsTransactionDone = true
                    };
                }
                else
                {
                    return new CustomerMasterRes
                    {
                        IsUserAlreadyExists = true
                    };
                }
            }
            catch (Exception ex)
            {
                return new CustomerMasterRes
                {
                    IsTransactionDone = false,
                    TransactionErrorMessage = ex.Message
                };
            }
        }

        public CustomerDetailsResult FetchUserInformation(string userName)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[] {
                    new SqlParameter("@UserName",userName)
                };

                DataSet ds = HALASQL.eds(CustomerSP.FetchCustomerDetails, param);
                CustomerDetailsResult userdetails = new CustomerDetailsResult();
                if (ds.Tables[0].Rows.Count > 0)
                {                    
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        userdetails.CustomerName = Convert.ToString(dr["CustomerName"]);
                        userdetails.CustomerID = Convert.ToInt32(dr["CustomerId"]);
                        userdetails.Email = Convert.ToString(dr["Email"]);
                        userdetails.Password = Convert.ToString(dr["Password"]);
                    }
                    userdetails.IsTransactionDone = true;                   
                }
                else
                    userdetails.IsTransactionDone = false;

                return userdetails;
            }
            catch (Exception ex)
            {
                return new CustomerDetailsResult
                {
                    IsTransactionDone = false,
                    TransactionErrorMessage = ex.Message
                };
            }
        }
    }
}
