using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using IMS.Model;
using System.IO;
using IMS.DAL;
using System.Net;

namespace WcfService
{
    public class IMSCoreRESTapi : IIMSCoreRESTapi
    {
        public IMSCoreRESTapi() {
            var mapDirect = new Dictionary<Type, Type>();
            mapDirect.Add( typeof( ArkivDocument ), typeof( ArkivDocumentRepository ) );
            da = new DataAccess( mapDirect );
        }


        private Dictionary<Type, Type> map;
        private DataAccess da;

        public string GetDataString( string s ) {
            return string.Format( "You entered: {0}", s );
        }

        public Stream GetDocument( string id ) {
            var result = new MemoryStream();
            Serializer.Serialize<ArkivDocument>( getSerializationFormat(), da.SelectWithId<ArkivDocument>( int.Parse( id ) ), result );
            result.Position = 0;
            return result;
        }

        public Stream InsertDocument( Stream data ) {
            var sFormat = getSerializationFormat();
            var doc = Deserializer.Deserialize<ArkivDocument>( sFormat, data );
            var r = da.Insert<ArkivDocument>( doc );
            var result = new MemoryStream();
            Serializer.Serialize<int>( sFormat, r, result );
            result.Position = 0;
            return result;
        }

        public void UpdateDocument( Stream data, string id ) {
            var sFormat = getSerializationFormat();
            var doc = Deserializer.Deserialize<ArkivDocument>( sFormat, data );
            da.Update<ArkivDocument>( doc );
        }

        private serializationFormat getSerializationFormat() {
            var headers = WebOperationContext.Current.IncomingRequest.Headers;
            serializationFormat replySerializationFormat;

            var sFormat = String.Empty;
            for ( int i = 0; i < headers.Count; ++i ) {
                if ( headers.GetKey( i ) == "sFormat" ) {
                    sFormat = headers["sFormat"];
                    break;
                }
            }
            if ( !Enum.TryParse<serializationFormat>( sFormat, true, out replySerializationFormat ) ) {
                replySerializationFormat = serializationFormat.JSON;
            }
            return replySerializationFormat;
        }
    }
}
