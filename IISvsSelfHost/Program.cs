using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace IISvsSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            const string serviceAddress = "http://localhost:4444";


            var config = new HttpSelfHostConfiguration(serviceAddress);
            config.Routes.MapHttpRoute("default-api",
                                      "api/{controller}/{id}",
                                      new
                                      {
                                          id = RouteParameter.Optional,
                                          namespaces = new[] { typeof(TestApiController).Namespace }
                                      });


            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            var server = new HttpSelfHostServer(config);
            server.OpenAsync();


            Console.WriteLine("Waiting on " + serviceAddress);


            Console.ReadLine();
        }
    }
}
