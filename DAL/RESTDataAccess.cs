using IMS.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DAL
{
    public class RESTDataAccess : IDataAccess
    {
        public const string UserAgent = "IMSCore REST Proxy";
        public readonly string BaseURI;
        public readonly serializationFormat sFormat;

        public RESTDataAccess() {
            var baseURI = ConfigurationManager.AppSettings["RESTEndPoint"];
            if ( baseURI.EndsWith( "/", StringComparison.InvariantCultureIgnoreCase ) ) {
                baseURI.TrimEnd( '/' );
            }
            BaseURI = baseURI;

            if ( !Enum.TryParse<serializationFormat>( ConfigurationManager.AppSettings["SerializationFormat"], true, out sFormat ) ) {
                sFormat = serializationFormat.ProtoBuf;
            }
        }

        public Model.ArkivDocument[] GetArkivDocuments(int i) {
            return Get<ArkivDocument[]>( "/Documents/" + i.ToString() );
        }

        private T Get<T>( String URI ) where T : class {
            var req = getRequest( URI, HttpMethod.GET );

            using ( HttpWebResponse resp = req.GetResponse() as HttpWebResponse ) {
                return Deserializer.Deserialize<T>( sFormat, resp.GetResponseStream() );
            }
        }
        private enum HttpMethod { GET, POST }

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
