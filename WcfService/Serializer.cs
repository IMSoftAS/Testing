using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using ProtoBuf;
using System.Text;
using IMS.Model;

namespace WcfService
{
    public class Serializer
    {
        public static Stream Serialize<T>( serializationFormat format, T o ) {
            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //sw.Start();

            Stream result = new MemoryStream();
            switch ( format ) {
                case serializationFormat.ProtoBuf:
                    result = serializeProtobuf<T>( o );
                    break;
                case serializationFormat.JSON:
                    result = serializeJSON( o );
                    break;
            }

            //sw.Stop();
            //Console.WriteLine( "{0, -30}{1,5}ms", String.Format("Serialize {0}:", format.ToString()), sw.ElapsedMilliseconds.ToString()  );

            return result;
        }

        //TODO: Can we define encoding for ProtoBuf serialization?
        private static Stream serializeProtobuf<T>( T o ) {
            var ms = new MemoryStream();
            ProtoBuf.Serializer.Serialize<T>( ms, o );
            ms.Position = 0;
            return ms;
        }

        private static Stream serializeJSON( object o ) {
            var r = JsonConvert.SerializeObject( o );
            byte[] resultBytes = Encoding.UTF8.GetBytes( r );
            var ms = new MemoryStream( resultBytes );
            ms.Position = 0;
            return ms;
        }
    }
}