using System.Web.Http;
using AttributeRouting.Web.Http.WebHost;

[assembly: WebActivator.PreApplicationStartMethod(typeof(MVC_Web_API_Test.AttributeRoutingHttpConfig), "Start")]

namespace MVC_Web_API_Test 
{
    public static class AttributeRoutingHttpConfig
	{
		public static void RegisterRoutes(HttpRouteCollection routes) 
		{    
			// See http://github.com/mccalltd/AttributeRouting/wiki for more options.
			// To debug routes locally using the built in ASP.NET development server, go to /routes.axd

            routes.MapHttpAttributeRoutes();
		}

        public static void Start() 
		{
            RegisterRoutes(GlobalConfiguration.Configuration.Routes);
        }
    }
}
