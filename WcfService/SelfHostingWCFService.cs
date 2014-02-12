using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfService;

namespace IMSCore
{
    public class SelfHostingWCFService : IDisposable
    {
        private ServiceHost host
        {
            get;
            set;
        }

        public SelfHostingWCFService()
        {
            host = new ServiceHost(typeof(IMSCoreRESTapi));

        }
        public void ThreadStart()
        {
            host.Open();
        } 

        public void Dispose()
        {
            host.Close();
        }
    }
}
