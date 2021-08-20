using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using Newtonsoft.Json;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using ASPSnippets.GoogleAPI;
using BDO = HALA.DTO.RequestResponseWrappers;
using ASPSnippets.FaceBookAPI;
using System.Data;

namespace Store
{
    public partial class _Home : Page
    {
        //your client id  
        string clientid = "664319515516-oedv8unj7emd757vngo1uahm3ra37ctp.apps.googleusercontent.com";
        //your client secret  
        string clientsecret = "nYvGTQkLUXkLsP9G-LZ9BMQT";
        //your redirection url  
        string redirection_url = "http://localhost:62889/Home.aspx";
        string url = "https://accounts.google.com/o/oauth2/token";
   

        public class GoogleProfile
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Picture { get; set; }
            public string Email { get; set; }
            public string Verified_Email { get; set; }
        }

        public class FaceBookUser
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string UserName { get; set; }
            public string PictureUrl { get; set; }
            public string Email { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadHomeBanner();
                if (!string.IsNullOrEmpty(Request.QueryString["code"]))
                {
                    GeneralMaster master = new GeneralMaster();

                    CommonMethods.DeleteCookie();

                    //string code = Request.QueryString["code"];
                    //string json = GoogleConnect.Fetch("me", code);
                    //GoogleProfile profile = new JavaScriptSerializer().Deserialize<GoogleProfile>(json);

                    string data = FaceBookConnect.Fetch(Request.QueryString["code"].ToString(), "me?fields=id,name,email");
                    FaceBookUser faceBookUser = new JavaScriptSerializer().Deserialize<FaceBookUser>(data);

                    var client = new Store.ClientUtility
                    {
                        serviceManger = new HALA.Utility.DataServiceManager(Store.ClientUtility.WebApiUri, "", true)
                    };

                    //client.UserInfo.AccessToken = profile.Id;
                    //client.UserInfo.CustomerName = profile.Name;
                    //client.UserInfo.email = profile.Email;
                    //client.UserInfo.StatusCode = 200;

                    master.LoginDetails(client);

                   // RegisterGoogleUser(profile);

                    Response.Redirect(Request.RawUrl.Replace(Request.Url.Query, ""));
                
                }
                if (Request.QueryString["error"] == "access_denied")
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", "alert('Access denied.')", true);
                }
               
            }
        }

        public void RegisterGoogleUser(GoogleProfile profile)
        {
            var service = CommonMethods.GetLogedInService();

            var url = HALA.DTO.Constants
                         .CustomerURI.GetCustomerByEmail
                         .Replace("{emailId}", profile.Email);

            var customerDetail = service.GetData<HALA.DTO.RequestResponseWrappers.ApiResponse
                              <HALA.DTO.RequestResponseWrappers.CustomerDetailsResult>>(url);

            if(customerDetail.Result.Email == null)
            {

                var googleRegister = new BDO.CustomerMasterReq();

                googleRegister.CustomerId = 0;
                googleRegister.CustomerName = profile.Name;
                googleRegister.Email = profile.Email;
                googleRegister.Type = "insertGoogleUser";

                service.PostData<BDO.ApiResponse
                              <HALA.DTO.RequestResponseWrappers.CustomerMasterRes>,
                              BDO.CustomerMasterReq>(HALA.DTO.Constants.CustomerURI.PostCustomerMaster, googleRegister);
            }
        }
        //public void GetToken(string code)
        //{
        //    string poststring = "grant_type=authorization_code&code=" + code + "&client_id=" + clientid + "&client_secret=" + clientsecret + "&redirect_uri=" + redirection_url + "";
        //    var request = (HttpWebRequest)WebRequest.Create(url);
        //    request.ContentType = "application/x-www-form-urlencoded";
        //    request.Method = "POST";
        //    UTF8Encoding utfenc = new UTF8Encoding();
        //    byte[] bytes = utfenc.GetBytes(poststring);
        //    Stream outputstream = null;
        //    try
        //    {
        //        request.ContentLength = bytes.Length;
        //        outputstream = request.GetRequestStream();
        //        outputstream.Write(bytes, 0, bytes.Length);
        //    }
        //    catch { }
        //    var response = (HttpWebResponse)request.GetResponse();
        //    var streamReader = new StreamReader(response.GetResponseStream());
        //    string responseFromServer = streamReader.ReadToEnd();
        //    JavaScriptSerializer js = new JavaScriptSerializer();
        //    Tokenclass obj = js.Deserialize<Tokenclass>(responseFromServer);
        //    GetuserProfile(obj.access_token);
        //}
        //public void GetuserProfile(string accesstoken)
        //{
        //    string url = "https://www.googleapis.com/oauth2/v1/userinfo?alt=json&access_token=" + accesstoken + "";
        //    WebRequest request = WebRequest.Create(url);
        //    request.Credentials = CredentialCache.DefaultCredentials;
        //    WebResponse response = request.GetResponse();
        //    Stream dataStream = response.GetResponseStream();
        //    StreamReader reader = new StreamReader(dataStream);
        //    string responseFromServer = reader.ReadToEnd();
        //    reader.Close();
        //    response.Close();
        //    JavaScriptSerializer js = new JavaScriptSerializer();
        //    Userclass userinfo = js.Deserialize<Userclass>(responseFromServer);
        //    //imgprofile.ImageUrl = userinfo.picture;
        //    //lblid.Text = userinfo.id;
        //    //lblgender.Text = userinfo.gender;
        //    //lbllocale.Text = userinfo.locale;
        //    //lblname.Text = userinfo.name;
        //    //hylprofile.NavigateUrl = userinfo.link;
        //}


        public void Login(string emailId, string password)
        {
            if (!string.IsNullOrEmpty(emailId) && !string.IsNullOrEmpty(password))
            {
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

                if (client.UserInfo.StatusCode == 200)
                {
                    client.serviceManger = new HALA.Utility.DataServiceManager(Store.ClientUtility.WebApiUri, client.UserInfo.AccessToken, false);

                    string userInformation = JsonConvert.SerializeObject(client.UserInfo);
                    HttpCookie cookie = new HttpCookie(CommonMethods.UserInfoKey)
                    {
                        Value = userInformation.Encrypt(),
                        Expires = DateTime.Now.AddYears(1) //client.UserInfo.ExpiresDate
                    };

                    Response.Cookies.Add(cookie);

                    // createa a new GUID and save into the session
                    string guid = Guid.NewGuid().ToString();
                    // now create a new cookie with this guid value
                    //Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", guid));

                    if (Session["ReturnUrl"] != null)
                    {
                        this.Response.Redirect(Session["ReturnUrl"].ToString());
                    }
                    else
                    {
                        //var productRequest = new AgecyProductRequest();
                        //productRequest.Agency = client.UserInfo.Agency;
                        //productRequest.AgentCode = client.UserInfo.AgentCode;
                        //productRequest.MainClass = string.Empty;
                        //productRequest.SubClass = string.Empty;
                        //productRequest.Type = "MotorInsurance";

                        //var productResponse = client.serviceManger.PostData<BKIC.SellingPoint.DTO.RequestResponseWrappers.ApiResponseWrapper
                        //                        <BKIC.SellingPoint.DTO.RequestResponseWrappers.AgencyProductResponse>,
                        //                        BKIC.SellingPoint.DTO.RequestResponseWrappers.AgecyProductRequest>
                        //                        (BKIC.SellingPoint.DTO.Constants.AdminURI.FetchAgencyProductByType, productRequest);

                        //if (productResponse.StatusCode == 200 && productResponse.Result.IsTransactionDone)
                        //{
                        //    if (productResponse.Result.MotorProducts != null && productResponse.Result.MotorProducts.Count > 0)
                        //    {
                        //        Session["MotorProducts"] = productResponse.Result.MotorProducts;
                        //    }
                        //}
                        this.Response.Redirect("HomePage.aspx");
                    }
                }
                else if (client.UserInfo.StatusCode == 404)
                {
                    //ErrorMessage.Text = "Service not available!";
                    //  Session.Remove("UserInfo");
                    CommonMethods.DeleteCookie();
                }
                else
                {
                    //ErrorMessage.Text = "Invalid credentials";
                    //  Session.Remove("UserInfo");
                    CommonMethods.DeleteCookie();
                }
            }          
        }

        public void LoadHomeBanner()
        {
            try
            {

                var service = CommonMethods.GetLogedInService();

                var url = HALA.DTO.Constants
                      .ContentURI.FetchHomeMainBanner
                      .Replace("{type}", "HOME_MAIN_BANNER");

                var results = service.GetData<HALA.DTO.RequestResponseWrappers.ApiResponse
                          <HALA.DTO.RequestResponseWrappers.GetContentResponse>>(url);

                DataTable dt = new DataTable();

                dt.Columns.Add("ContentDetails");
                dt.Rows.Add(results.Result.Content);

                HomeBanner.DataSource = dt;
                HomeBanner.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}