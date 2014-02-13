using IMS.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IMS.DAL
{
    public class Deserializer
    {
        public static T Deserialize<T>( serializationFormat format, Stream s ) where T : class {
            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //sw.Start();

            T result = null;
            switch ( format ) {
                case serializationFormat.ProtoBuf:
                    result = deserializeProtobuf<T>( s );
                    break;
                case serializationFormat.JSON:
                    result = deserializeJSON<T>( s );
                    break;
            }

            //sw.Stop();
            //Console.WriteLine( "{0, -30}{1,5}ms", String.Format( "Deserialize {0}:", format.ToString() ), sw.ElapsedMilliseconds.ToString() );

            return result;
        }

        //TODO: Can we define encoding for ProtoBuf serialization?
        private static T deserializeProtobuf<T>( Stream s ) {
            return ProtoBuf.Serializer.Deserialize<T>( s );
        }

        private static T deserializeJSON<T>( Stream s ) {
            var jsonTextReader = new JsonTextReader( new StreamReader( s ) );
            var serializer = new JsonSerializer();
            return serializer.Deserialize<T>( jsonTextReader );
        }
    }
}