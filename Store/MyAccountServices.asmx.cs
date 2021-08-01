using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Newtonsoft.Json;
using Microsoft.Ajax.Utilities;
using BDO = HALA.DTO.RequestResponseWrappers;
using System.Web.UI.HtmlControls;
using System.Net.Mail;
using System.Net;
using ASPSnippets.GoogleAPI;

namespace Store
{
    /// <summary>
    /// Summary description for MyAccountServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class MyAccountServices : System.Web.Services.WebService
    {
        //private GeneralMaster master;

        //public MyAccountServices()
        //{

        //}

        [WebMethod]
        public string LoginService()
        {
            try
            {
                GeneralMaster master = new GeneralMaster();

                string checkService = null;
                //bool IsAvail = false;

                //master.IsSessionAvailable();
                var userInfo = CommonMethods.GetUserDetails();

                if (userInfo != null)
                {
                    var returnData = new
                    {
                        userName = "Hi! " + userInfo.CustomerName,
                        userId = userInfo.CustomerID,
                        IsExist = true
                    };

                    checkService = JsonConvert.SerializeObject(returnData);
                }
               
                return checkService;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        [WebMethod]
        public string Login(string emailId, string password)
        {
            try
            {
                GeneralMaster master = new GeneralMaster();

                string loginRes = string.Empty;

                if (!string.IsNullOrEmpty(emailId) && !string.IsNullOrEmpty(password))
                {
                    CommonMethods.DeleteCookie();

                    var authentication = new HALA.DTO.RequestResponseWrappers.OAuthRequest();
                    authentication.UserName = emailId;
                    authentication.Password = password;
                    authentication.GrantType = "";

                    var client = new Store.ClientUtility
                    {
                        serviceManger = new HALA.Utility.DataServiceManager(Store.ClientUtility.WebApiUri, "", true)
                    };


                    client.UserInfo = client.serviceManger.PostData<HALA.DTO.RequestResponseWrappers.OAuthTokenResponse,
                                    HALA.DTO.RequestResponseWrappers.OAuthRequest>
                                    (HALA.DTO.Constants.UserURI.Authentication, authentication);

                    loginRes = master.LoginDetails(client);

                }

                return loginRes;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [WebMethod]
        public string SignUp(BDO.CustomerMasterReq signUpJson)
        {
            try
            {
                GeneralMaster master = new GeneralMaster();

                string loginRes = string.Empty;

                var service = CommonMethods.GetLogedInService();

                signUpJson.CustomerId = 0;
                signUpJson.Type = "insertInternalUser";

                var results = service.PostData<BDO.ApiResponse
                              <HALA.DTO.RequestResponseWrappers.CustomerMasterRes>,
                              BDO.CustomerMasterReq>(HALA.DTO.Constants.CustomerURI.PostCustomerMaster, signUpJson);

                if(!results.Result.IsUserAlreadyExists && results.Result.IsTransactionDone)
                {
                    CommonMethods.DeleteCookie();

                    var authentication = new HALA.DTO.RequestResponseWrappers.OAuthRequest();
                    authentication.UserName = signUpJson.Email;
                    authentication.Password = signUpJson.Password;
                    authentication.GrantType = "";

                    var client = new Store.ClientUtility
                    {
                        serviceManger = new HALA.Utility.DataServiceManager(Store.ClientUtility.WebApiUri, "", true)
                    };


                    client.UserInfo = client.serviceManger.PostData<HALA.DTO.RequestResponseWrappers.OAuthTokenResponse,
                                    HALA.DTO.RequestResponseWrappers.OAuthRequest>
                                    (HALA.DTO.Constants.UserURI.Authentication, authentication);

                    loginRes = master.LoginDetails(client);
                }

                return loginRes;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        [WebMethod]
        public string Recover(string emailId)
        {
            var service = CommonMethods.GetLogedInService();

            var url = HALA.DTO.Constants
                         .CustomerURI.GetCustomerByEmail                      
                         .Replace("{emailId}", emailId.ToString());

            var customerDetail = service.GetData<HALA.DTO.RequestResponseWrappers.ApiResponse
                              <HALA.DTO.RequestResponseWrappers.CustomerDetailsResult>>(url);

            if(customerDetail.Result.IsTransactionDone)
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("ecommercehala@gmail.com");
                message.To.Add(new MailAddress(customerDetail.Result.Email));
                message.Subject = "Recover Password";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "<h1>Your Password: </h1>" + customerDetail.Result.Password;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = new NetworkCredential("ecommercehala@gmail.com", "HalaEcommerce75");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                //smtp.Send(message);
            }

            var result = new
            {
                IsSent = customerDetail.Result.IsTransactionDone
            };

            return JsonConvert.SerializeObject(result);

        }

   
    }
}
