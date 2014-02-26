using IMS.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DAL
{
    public class RESTRepositoryBase
    {
        public const string UserAgent = "IMSCore REST Proxy";
        public readonly string BaseURI;
        public readonly serializationFormat sFormat;

        public RESTRepositoryBase() {
            var baseURI = ConfigurationManager.AppSettings["RESTEndPoint"];
            if ( baseURI.EndsWith( "/", StringComparison.InvariantCultureIgnoreCase ) ) {
                baseURI.TrimEnd( '/' );
            }
            BaseURI = baseURI;

            if ( !Enum.TryParse<serializationFormat>( ConfigurationManager.AppSettings["SerializationFormat"], true, out sFormat ) ) {
                sFormat = serializationFormat.ProtoBuf;
            }
        }

        protected enum HttpMethod { GET, POST, PUT }

        protected T Get<T>( String URI ) {
            return respond<T>(getRequest( URI, HttpMethod.GET ));
        }

        protected V Post<T, V>( string URI, T data ) {
            var req = getRequest( URI, HttpMethod.POST );
            Serializer.Serialize<T>( sFormat, data, req.GetRequestStream() );
            return respond<V>( req );
        }

        protected V Put<T, V>( string URI, T data ) {
            var req = getRequest( URI, HttpMethod.PUT );
            Serializer.Serialize<T>( sFormat, data, req.GetRequestStream() );
            return respond<V>( req );
        }

        private V respond<V>(HttpWebRequest request) {
            using ( HttpWebResponse resp = request.GetResponse() as HttpWebResponse ) {
                return Deserializer.Deserialize<V>( sFormat, resp.GetResponseStream() );
            }
        }

        private HttpWebRequest getRequest( string URI, HttpMethod method ) {
            URI = sanitizeURI( URI );
            HttpWebRequest req = WebRequest.Create( String.Format( "{0}{1}", BaseURI, URI, sFormat.ToString() ) ) as HttpWebRequest;
            req.Headers.Add( "sFormat", sFormat.ToString() );
            req.Method = method.ToString();
            return req;
        }

        private String sanitizeURI( string URI ) {
            if ( !URI.StartsWith( "/", StringComparison.InvariantCultureIgnoreCase ) ) {
                URI = "/" + URI;
            }
            return URI;
        }
    }
}
