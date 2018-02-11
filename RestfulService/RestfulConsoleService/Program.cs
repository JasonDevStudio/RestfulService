using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace RestfulConsoleService
{
    class Program
    {
        static void Main(string[] args)
        {
            RestDemoService demoServices = new RestDemoService();
            WebServiceHost _serviceHost = new WebServiceHost(demoServices, new Uri("http://localhost:10000/DemoService"));
            _serviceHost.Open();
            Console.ReadKey();
            _serviceHost.Close();
        }
    }
}
