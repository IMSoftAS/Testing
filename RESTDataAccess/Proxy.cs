using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using ProtoBuf;
using IMS.Model;

namespace IMS.Core.RESTDataAccess
{
    public class Proxy
    {
        public const string UserAgent = "IMSCore REST Proxy";
        public readonly string BaseURI;
        public readonly serializationFormat sFormat;

        public Proxy() {
            var baseURI = ConfigurationManager.AppSettings["RESTEndPoint"];
            if (baseURI.EndsWith("/", StringComparison.InvariantCultureIgnoreCase )){
                baseURI.TrimEnd('/');
            }
            BaseURI = baseURI;

            if ( !Enum.TryParse<serializationFormat>( ConfigurationManager.AppSettings["SerializationFormat"], true, out sFormat ) ) {
                sFormat = serializationFormat.ProtoBuf;
            }
        }

        public T Get<T>( String URI ) where T : class {
            var req = getRequest( URI, HttpMethod.GET );

            using ( HttpWebResponse resp = req.GetResponse() as HttpWebResponse ) {
                return Deserializer.Deserialize<T>( sFormat, resp.GetResponseStream() );
            }
        }
        public void Post<T>( String URI ) where T : class {
            var req = getRequest(URI, HttpMethod.POST);

            string result = null;
            using ( HttpWebResponse resp = req.GetResponse() as HttpWebResponse ) {
                StreamReader reader = new StreamReader( resp.GetResponseStream() );
                result = reader.ReadToEnd();
            }
        }

        private enum HttpMethod { GET, POST }

        private HttpWebRequest getRequest(string URI, HttpMethod method) {
            URI = sanitizeURI(URI);
            HttpWebRequest req = WebRequest.Create( String.Format( "{0}{1}", BaseURI, URI, sFormat.ToString() ) ) as HttpWebRequest;
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
