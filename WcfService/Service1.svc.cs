using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json;
using ProtoBuf;
using IMS.Model;
using System.IO;

using System.Net;

namespace WcfService
{
    

    public class IMSCoreRESTapi : IIMSCoreRESTapi
    {
        public string GetDataString(string s)
        {
            return string.Format("You entered: {0}", s);
        }

        public Stream GetAllDocuments(string replyformat)
        {
            serializationFormat replySerializationFormat;
            if ( !Enum.TryParse<serializationFormat>( replyformat, true, out replySerializationFormat ) ) {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.BadRequest;
                WebOperationContext.Current.OutgoingResponse.StatusDescription = "Serialization format is unknown";
                return new MemoryStream();
            }

            var r = (new IMS.DAL.DataAccess()).TestDataAccess();
            WebOperationContext.Current.OutgoingResponse.ContentType = "text/plain";
            return Serializer.Serialize<ArkivDocument[]>(replySerializationFormat, r);
        }       
    }
}
