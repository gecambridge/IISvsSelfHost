using IISvsSelfHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebApplication1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            var config = GlobalConfiguration.Configuration;
            config.Filters.Clear();
            config.Routes.MapHttpRoute("default-api",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional, namespaces = new[] { typeof(TestApiController).Namespace } });
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
        }
    }
}
