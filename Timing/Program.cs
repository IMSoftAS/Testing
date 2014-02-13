using IMS.DAL;
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

            IDataAccess DA;
            var rest = new RESTDataAccess();
            var direct = new DataAccess();

            for ( int i = 2; i < 100000; i = i * 2 ) {
                //spin up the SQL server for the query.
                direct.GetArkivDocuments(i);
                direct.GetArkivDocuments(i);
                rest.GetArkivDocuments(i);
                rest.GetArkivDocuments( i );
                
                Console.WriteLine( "Testing TOP "+ i.ToString() );
                Console.WriteLine();
                DA = direct;
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                var ddata = DA.GetArkivDocuments(i);
                sw.Stop();
                Console.WriteLine( "{0, -30}{1,5}ms", "Direct access time:", sw.ElapsedMilliseconds.ToString() );

                DA = rest;
                sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                var rdata = DA.GetArkivDocuments(i);
                sw.Stop();
                Console.WriteLine( "{0, -30}{1,5}ms", "Total RESTAPI time:", sw.ElapsedMilliseconds.ToString() );
                for ( int idx = 0; idx < ddata.Length; idx++ ) {
                    if ( ddata[idx].DocumentId != rdata[idx].DocumentId ) {
                        Console.WriteLine( "Data not identical, aborting" );
                        break;
                    }
                }
                Console.WriteLine( "-------------------------------------" );
                Console.WriteLine();
            }
                
            Console.WriteLine( "Press any key to exit" );
            Console.ReadLine();
        }
    }
}
