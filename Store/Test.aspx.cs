using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Web.Security;
using System.Drawing;

namespace Store
{
    public partial class Test : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
             
            }
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            //your client id  
            string clientid = "664319515516-oedv8unj7emd757vngo1uahm3ra37ctp.apps.googleusercontent.com";
            //your client secret  
            string clientsecret = "nYvGTQkLUXkLsP9G-LZ9BMQT";
            //your redirection url  
            string redirection_url = "http://localhost:62889/Home.aspx";
            string url = "https://accounts.google.com/o/oauth2/v2/auth?scope=profile&include_granted_scopes=true&redirect_uri=" + redirection_url + "&response_type=code&client_id=" + clientid + "";
            Response.Redirect(url);
        }

    }
}