using System.Web.Http;
using HALA.API;
using WebActivatorEx;
using Swashbuckle.Application;
using HALA.API.App_Start;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace HALA.API.App_Start
{
    public class SwaggerConfig
    {
        public static void Register()
        {

            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
           .EnableSwagger(c =>
           {
               c.SingleApiVersion("v1", "HALA API Services");

           })
          .EnableSwaggerUi(c =>
          {
          });

        }

        protected static string GetXmlCommentsPath()
        {
          return System.String.Format(@"{0}\bin\WebApiSwagger.XML", System.AppDomain.CurrentDomain.BaseDirectory);
        }
    }
}