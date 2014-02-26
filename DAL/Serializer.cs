using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using ProtoBuf;
using System.Text;
using IMS.Model;

namespace IMS.DAL
{
    public class Serializer
    {
        public static void Serialize<T>( serializationFormat format, T o, Stream output ) {
            switch ( format ) {
                case serializationFormat.ProtoBuf:
                    serializeProtobuf<T>( o, output );
                    break;
                case serializationFormat.JSON:
                    serializeJSON( o, output );
                    break;
            }
        }

        //TODO: Can we define encoding for ProtoBuf serialization?
        private static void serializeProtobuf<T>( T o, Stream output ) {
            ProtoBuf.Serializer.Serialize<T>( output, o );
        }

        private static void serializeJSON( object o, Stream output ) {
            var r = JsonConvert.SerializeObject( o );
            byte[] resultBytes = Encoding.UTF8.GetBytes( r );
            output.Write( resultBytes, 0, resultBytes.Length );
        }
    }
}