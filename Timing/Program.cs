using IMS.DAL;
using IMS.Model;
using Ninject;
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
        private IKernel container;

        public Program() {
            ConfigureContainer();
        }

        private void ConfigureContainer() {
            this.container = new StandardKernel();
            var mapREST = new Dictionary<Type, Type>();
            mapREST.Add( typeof( ArkivDocument ), typeof( ArkivDocumentRESTRepository ) );
            container.Bind<Dictionary<Type, Type>>().ToConstant( mapREST );
        }

        public void runTest() {
            var da = container.Get<IDataAccess>();
            var test = da.SelectWithId<ArkivDocument>( 114229 );
            test.Description += "!";
            da.Update<ArkivDocument>( test );
            var test2 = da.SelectWithId<ArkivDocument>( 114229 );
            Console.WriteLine( "Press any key to exit" );
        }

        static void Main( string[] args ) {
            //var smallDateTime = new DateTime( 1900, 1, 1 );
            //var doc = new ArkivDocument() { DocumentFrom = 42, Description = "text", AutoExpireDate = smallDateTime, CustomDate = smallDateTime, DateAnswerDue = smallDateTime, DateArchived = smallDateTime, DateArchiveDue = smallDateTime, DateCreated = smallDateTime, DateDocumentDated = smallDateTime, DateSentRecived = smallDateTime };
            //var rest = new RESTDataAccess();
            var o = new Program();
            o.startRESTApi();
            o.runTest();
            //o.TimeFetch();
            //var r = rest.InsertArkivDocument( doc );  
        }

        public void startRESTApi() {
            var host = new IMSCore.SelfHostingWCFService();
            Thread thread = new Thread( new ThreadStart( host.ThreadStart ) );
            thread.Name = "HttpDataAccessThread";
            thread.Start();
        }

        //public void TimeFetch() {
        //    IDataAccess DA;
        //    var rest = new RESTDataAccess();
        //    var direct = new DataAccess();
        //    var retestingfactor = 10;
        //    var directretestingfactor = 10;
        //    var fetchMax = 17000;

        //    for ( int i = 1; i < fetchMax; i = i * 2 ) {
        //        if ( i < 257 ) {
        //            retestingfactor *= 10;
        //            directretestingfactor *= 10;
        //        }
        //        //spin up the SQL server for the query.
        //        direct.GetArkivDocuments( i );
        //        direct.GetArkivDocuments( i );
        //        rest.GetArkivDocuments( i );
        //        rest.GetArkivDocuments( i );
        //        rest.GetArkivDocumentsCached( i );
        //        rest.GetArkivDocumentsCached( i );

        //        //DA = direct;
        //        System.Diagnostics.Stopwatch sw;



        //        Decimal dticks = 0;
        //        for ( int r = 0; r < directretestingfactor; r++ ) {
        //            GC.Collect();
        //            sw = new System.Diagnostics.Stopwatch();
        //            sw.Start();
        //            var ddata = direct.GetArkivDocuments( i );
        //            sw.Stop();
        //            dticks += sw.ElapsedTicks;
        //        }
        //        Decimal dtimetotal = dticks / 1000;
        //        Decimal dtimesingle = dtimetotal / directretestingfactor;

        //        DA = rest;
        //        Decimal rticks = 0;
        //        for ( int r = 0; r < retestingfactor; r++ ) {
        //            GC.Collect();
        //            sw = new System.Diagnostics.Stopwatch();
        //            sw.Start();
        //            var ddata = direct.GetArkivDocuments( i );
        //            sw.Stop();
        //            rticks += sw.ElapsedTicks;
        //        }
        //        Decimal rtimetotal = rticks / 1000;
        //        Decimal rtimesingle = rtimetotal / retestingfactor;

        //        Decimal rcticks = 0;
        //        for ( int r = 0; r < retestingfactor; r++ ) {
        //            GC.Collect();
        //            sw = new System.Diagnostics.Stopwatch();
        //            sw.Start();
        //            var ddata = rest.GetArkivDocumentsCached( i );
        //            sw.Stop();
        //            rcticks += sw.ElapsedTicks;
        //        }
        //        Decimal rctimetotal = rcticks / 1000;
        //        Decimal rctimesingle = rctimetotal / retestingfactor;

        //        var oarr = ( rtimesingle / dtimesingle ).ToString().Split( '.' );
        //        if ( oarr[1].Length > 3 ) {
        //            oarr[1] = oarr[1].Substring( 0, 3 );
        //        }
        //        var ocarr = ( rctimesingle / dtimesingle ).ToString().Split( '.' );
        //        if ( ocarr[1].Length > 3 ) {
        //            ocarr[1] = ocarr[1].Substring( 0, 3 );
        //        }

        //        var darr = dtimesingle.ToString().Split( '.' );
        //        var rarr = rtimesingle.ToString().Split( '.' );
        //        var rcarr = rctimesingle.ToString().Split( '.' );
        //        Console.WriteLine( "{4,-3} {3, -6} {0, -30}{1,5}.{2,-3}ms  x 1.00", "DB access time:", darr[0], darr[1].Length >= 3 ? darr[1].Substring( 0, 3 ) : darr[1], i.ToString(), "TOP" );
        //        Console.WriteLine( "           {0, -30}{1,5}.{2,-3}ms  x{3,2}.{4,-3}", "RESTAPI access time:", rarr[0], rarr[1].Length >= 3 ? rarr[1].Substring( 0, 3 ) : rarr[1], oarr[0], oarr[1] );
        //        Console.WriteLine( "           {0, -30}{1,5}.{2,-3}ms  x{3,2}.{4,-3}", "RESTAPI cached access time:", rcarr[0], rcarr[1].Length >= 3 ? rcarr[1].Substring( 0, 3 ) : rcarr[1], ocarr[0], ocarr[1] );
        //        //Console.WriteLine( "           {0, -33}{1,5}%", "Overhead:", overheadpercentString );
        //        Console.WriteLine();
        //    }
        //}
    }
}
