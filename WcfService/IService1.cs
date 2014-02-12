using IMS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    [ServiceContract]
    public interface IIMSCoreRESTapi
    {
        [OperationContract]
        [WebGet(UriTemplate = "GetDataString/{s}", ResponseFormat = WebMessageFormat.Json)]
        string GetDataString(string s);

        [OperationContract]
        [WebGet( UriTemplate = "GetAllDocuments?sFormat={sformat}" )]
        Stream GetAllDocuments( string sformat );
    }
}
