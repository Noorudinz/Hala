using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Owin.Security.WsFederation;
using Owin;
using System;
using System.Configuration;

[assembly: OwinStartup(typeof(HALA.API.Framework.AuthStartup))]

namespace HALA.API.Framework
{
    public class AuthStartup
    {
        public static string PublicClientId { get; private set; }
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            var myProvider = new ApiTokenAuth();
            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                TokenEndpointPath = new PathString("/api/HALAOAuth"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(Convert.ToInt32(ConfigurationManager.AppSettings["OAuthExpiresInSeconds"].ToString())),
                Provider = myProvider
            };
            app.UseOAuthAuthorizationServer(options);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

            //app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions()
            //{
            //    ClientId = "664319515516-oedv8unj7emd757vngo1uahm3ra37ctp.apps.googleusercontent.com",
            //    ClientSecret = "nYvGTQkLUXkLsP9G-LZ9BMQT"
            //});

            app.SetDefaultSignInAsAuthenticationType(WsFederationAuthenticationDefaults.AuthenticationType);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = WsFederationAuthenticationDefaults.AuthenticationType
            });


        }
    }
}