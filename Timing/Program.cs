using IMS.Core.RESTDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timing
{
    class Program
    {
        static void Main( string[] args ) {
            var host = new IMSCore.SelfHostingWCFService();
            Thread thread = new Thread( new ThreadStart( host.ThreadStart ) );
            thread.Name = "HttpDataAccessThread";
            thread.Start();

            //System.Threading.Thread.Sleep( 10000 );
            var p = new Proxy();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            var r = p.Get<List<IMS.Model.ArkivDocument>>( "/GetAllDocuments" );
            sw.Stop();
            Console.WriteLine( "-------------------------------------" );
            Console.WriteLine( "{0, -30}{1,5}ms", "Total time:", sw.ElapsedMilliseconds.ToString() );
            Console.WriteLine();
            Console.WriteLine( "Press any key to exit" );
            Console.ReadLine();
        }
    }
}
