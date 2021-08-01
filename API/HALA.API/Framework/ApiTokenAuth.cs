using HALA.DTO.RequestResponseWrappers;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using BDL = HALA.DL.BL;
using BLO = HALA.DL.BO;
using BLR = HALA.DL.BL.Repositories;


namespace HALA.API.Framework
{
    public class ApiTokenAuth : OAuthAuthorizationServerProvider
    {
        private readonly BLR.IUser _user;
        private readonly BLR.ICustomer _customer;

        public ApiTokenAuth()
        {
            _user = new BDL.Implementation.User();
            _customer = new BDL.Implementation.Customer();
        }

        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return base.ValidateClientAuthentication(context);
        }

        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            var validUser = _user.IsUserValid(context.UserName, context.Password);

            BLO.LoginAudit loginAudit = new BLO.LoginAudit();
            //loginAudit.IPAddress =GetClientIP();
            loginAudit.UserName = context.UserName;
            loginAudit.LoginDate = DateTime.Now;
            loginAudit.LoginStatus = "Failed";

            if (validUser.IsTransactionDone)
            {
                if (validUser.IsValidUser)
                {
                    string[] roles = _user.GetUserRoles(context.UserName);

                    foreach (string role in roles)
                    {
                        identity.AddClaim(new Claim(ClaimTypes.Role, role));
                    }

                    identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));


                    var userDetails = _customer.FetchUserInformation(context.UserName);
                    identity.AddClaim(new Claim(ClaimTypes.Name, userDetails.CustomerName));
                    identity.AddClaim(new Claim("customerName", userDetails.CustomerName));
                    identity.AddClaim(new Claim("customerID", userDetails.CustomerID.ToString()));
                    identity.AddClaim(new Claim("email", userDetails.Email));
                 
                    context.Validated(identity);
                    loginAudit.LoginStatus = "Success";
                   
                }
                else
                {
                    context.SetError("invalid_grant", "Provided username and password is incorrect");
                 
                    return base.GrantResourceOwnerCredentials(context);
                }
            }
            else
            {
                context.SetError("Transaction_error", "Transaction failed. Please try again");
               
                return base.GrantResourceOwnerCredentials(context);
            }

            return base.GrantResourceOwnerCredentials(context);
        }

        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            var identity = context.Identity as ClaimsIdentity;
            var roles = identity.Claims
                        .Where(c => c.Type == ClaimTypes.Role)
                        .Select(c => c.Value);

            // Append authenticated user roles in token end point response

            if (roles != null)
            {
                var roleKeyValue = new KeyValuePair<string, string>("roles", string.Join(",", roles.ToList()));
                context.AdditionalResponseParameters.Add(roleKeyValue.Key, roleKeyValue.Value);
            }

            if (!string.IsNullOrEmpty(identity.Name))
            {
                var userKeyValue = new KeyValuePair<string, string>("name", identity.Name);
                context.AdditionalResponseParameters.Add(userKeyValue.Key, userKeyValue.Value);
            }

            var userId = identity.Claims
                        .Where(c => c.Type == "customerID")
                        .Select(c => c.Value);

            if (userId != null)
            {
                var userIdKeyValue = new KeyValuePair<string, string>("customerID", string.Join(",", userId.ToList()));
                context.AdditionalResponseParameters.Add(userIdKeyValue.Key, userIdKeyValue.Value);
            }

            var Id = identity.Claims
                      .Where(c => c.Type == "email")
                      .Select(c => c.Value);

            if (Id != null)
            {
                var IdKeyValue = new KeyValuePair<string, string>("ID", string.Join(",", Id.ToList()));
                context.AdditionalResponseParameters.Add(IdKeyValue.Key, IdKeyValue.Value);
            }

            var userName = identity.Claims
                        .Where(c => c.Type == "customerName")
                        .Select(c => c.Value).DefaultIfEmpty();

            if (userName != null)
            {
                context.AdditionalResponseParameters.Add("customerName", string.Join(",", userName.ToList()));
            }        

            context.AdditionalResponseParameters.Add("statusCode", 200);

            return Task.FromResult<object>(null);
        }

        private void TrackLoginAudit(BLO.LoginAudit audit)
        {
            _user.TrackLogin(audit);
        }

        public static String GetClientIP()
        {
            String ip =
                HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (string.IsNullOrEmpty(ip))
            {
                ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }

            return ip;
        }
    }
}