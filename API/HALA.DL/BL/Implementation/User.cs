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
    public class User : IUser
    {
        public User()
        {
           
        }

        public string[] GetUserRoles(string userName)
        {
            string name = Membership.GetUserNameByEmail(userName);

            return Roles.GetRolesForUser(name);
        }

        public AuthenticationResult IsUserValid(string userName, string password)
        {
            var userValidation = new AuthenticationResult();
            userValidation.IsValidUser = false;
            userValidation.IsTransactionDone = true;

            try
            {
                string name = Membership.GetUserNameByEmail(userName);

                if (Membership.ValidateUser(name, password))
                {
                    userValidation.IsValidUser = true;                  
                }
            }
            catch (Exception exc)
            {
                userValidation.IsTransactionDone = false;
                userValidation.TransactionErrorMessage =
                    exc.InnerException != null ?
                   (exc.InnerException.InnerException != null ? exc.InnerException.InnerException.Message :
                   exc.InnerException.Message) : exc.Message;
            }

            return userValidation;
        }
        

        public void TrackLogin(LoginAudit audit)
        {
            try
            {
                SqlParameter[] para = new SqlParameter[] {
                    new SqlParameter("@UserName", audit.UserName),
                    new SqlParameter("@IPAddress", audit.IPAddress),
                    new SqlParameter("@LoginDate", audit.LoginDate),
                    new SqlParameter("@LoginStatus", audit.LoginStatus)
                };

                //DataSet result = HALASQL.eds(UsersSP.LoginAudit, para);
            }
            catch (Exception exc)
            {
                throw;
            }
        }
    }
}
