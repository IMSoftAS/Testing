using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfService;

namespace SelfHostingWCFApp
{
    public class SelfHostingWCFService : IDisposable
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                host.Open();

                Console.WriteLine("The service is ready at {0}");
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                host.Close();
            }
            Console.ReadLine();
        }

        private ServiceHost host
        {
            get;
            set;
        }

        public SelfHostingWCFService()
        {
            host = new ServiceHost(typeof(Service1));
            host.Open();
        }

        public void Dispose()
        {
            host.Close();
        }
    }
}
