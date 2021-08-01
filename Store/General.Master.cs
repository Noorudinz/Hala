using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Newtonsoft.Json;
using HALA.DTO.RequestResponseWrappers;
using HALA.Utility;
using System.Configuration;
using System.Reflection;
using System.Resources;
using System.Text.RegularExpressions;
using System.Web.UI.HtmlControls;
using System.Net.Configuration;
using System.Text;
using ASPSnippets.GoogleAPI;
using ASPSnippets.FaceBookAPI;

namespace Store
{
    public partial class GeneralMaster : System.Web.UI.MasterPage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {          

            if (!IsPostBack)
            {
            
                //if (userInfo != null)
                //{
                //    lstSignIn.Attributes.Add("display", "none");
                //    lstCustomerName.Attributes.Add("display", "block");
                //}
                //else
                //{
                //    lstSignIn.Attributes.Add("display", "block");
                //    lstCustomerName.Attributes.Add("display", "none");
                //}
                //var service = CommonMethods.GetLogedInService();

                //LoginServices(userInfo);               

            }
        }

     

        //public void LoginServices(OAuthTokenResponse userInfo)
        //{
        //    if (userInfo != null)
        //    {
        //        lstSignIn.Visible = false;
        //        lstCustomerName.Visible = true;
        //        HomeMegaMenu.InnerText = "Hi!" + userInfo.UserName;
        //    }
        //    else
        //    {
        //        lstSignIn.Visible = true;
        //        lstCustomerName.Visible = false;
        //    }
        //}

        public void IsSessionAvailable(string key = "", bool pCheckFurtherAction = true)
        {
            key = string.IsNullOrEmpty(key) ? CommonMethods.UserInfoKey : key;
            if (CommonMethods.IsCookieAvailable(key))
            {
                var userInfo = CommonMethods.GetLogedInService(key);

                string value = "";
                value = HttpContext.Current.Request.Cookies[key].Value;
                value = value.Decrypt();
                OAuthTokenResponse info = JsonConvert.DeserializeObject<OAuthTokenResponse>(value);

                if (info == null || string.IsNullOrEmpty(value))
                {
                   // Response.Redirect("Login.aspx");
                }

                DateTime iKnowThisIsUtc = info.ExpiresDate;
                DateTime runtimeKnowsThisIsUtc = DateTime.SpecifyKind(
                    iKnowThisIsUtc,
                    DateTimeKind.Utc);
                DateTime localVersion = runtimeKnowsThisIsUtc.ToLocalTime();
                if (localVersion < DateTime.Now)
                {                    
                    // Response.Redirect("Home.aspx");
                }
            }
            else
            {              
                // Response.Redirect("Home.aspx");
            }
        }

        public void RedirectToLogin()
        {
            string OriginalUrl = HttpContext.Current.Request.RawUrl;
            string LoginPageUrl = "/login.aspx";
            Session["ReturnUrl"] = OriginalUrl;

            if (!OriginalUrl.Contains("UserRegistration.aspx"))
            {
                HttpContext.Current.Response.Redirect(String.Format("{0}?ReturnUrl={1}", LoginPageUrl, OriginalUrl));
            }
            else
            {
                HttpContext.Current.Response.Redirect("login.aspx");
            }
        }
             

        public string LoginDetails(ClientUtility client)
        {
            bool IsExist = false;
            string message = string.Empty;

            if (client.UserInfo.StatusCode == 200)
            {
                client.serviceManger = new HALA.Utility.DataServiceManager(Store.ClientUtility.WebApiUri, client.UserInfo.AccessToken, false);

                string userInformation = JsonConvert.SerializeObject(client.UserInfo);
                HttpCookie cookie = new HttpCookie(CommonMethods.UserInfoKey)
                {
                    Value = userInformation.Encrypt(),
                    Expires = DateTime.Now.AddYears(1)
                };
                
                HttpContext.Current.Response.Cookies.Add(cookie);

                IsExist = true;
                message = "Hi! " + client.UserInfo.CustomerName;
                //LoginServices(client.UserInfo);

            }
            else if (client.UserInfo.StatusCode == 404)
            {
                message = "Service not available!";               
                CommonMethods.DeleteCookie();

                IsExist = false;
            }
            else
            {
                message = "Invalid credentials";               
                CommonMethods.DeleteCookie();

                IsExist = false;
            }
          
            var my_jsondata = new
            {
                msg = message,            
                IsAvail = IsExist
            };
           
            string json_data = JsonConvert.SerializeObject(my_jsondata);

            return json_data;
           
        }

        protected void Google_Click(object sender, EventArgs e)
        {
            hdnCustomerType.Value = "GoogleUser";
            GoogleConnect.ClientId = ConfigurationManager.AppSettings["GoogleClientId"];
            GoogleConnect.ClientSecret = ConfigurationManager.AppSettings["GoogleClientSecret"];
            GoogleConnect.RedirectUri = Request.Url.AbsoluteUri.Split('?')[0];
            GoogleConnect.Authorize("profile", "email");
        }

        protected void FaceBook_Click(object sender, EventArgs e)
        {
            hdnCustomerType.Value = "FaceBookUser";
            FaceBookConnect.API_Key = ConfigurationManager.AppSettings["FacebookAppId"];
            FaceBookConnect.API_Secret = ConfigurationManager.AppSettings["FacebookAppSecret"];
            FaceBookConnect.Authorize("user_photos,email", Request.Url.AbsoluteUri.Split('?')[0]);
        }


    }
}