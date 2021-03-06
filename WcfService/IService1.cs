﻿using IMS.Model;
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
    ///ObjectName/ObjectId?param_1=value_1&...&param_n=value_n

    [ServiceContract]
    public interface IIMSCoreRESTapi
    {
        [OperationContract]
        [WebGet(UriTemplate = "GetDataString/{s}", ResponseFormat = WebMessageFormat.Json)]
        string GetDataString(string s);

        //[OperationContract]
        //[WebGet( UriTemplate = "GetAllDocuments?sFormat={sformat}" )]
        //Stream GetAllDocuments( string sformat );
        
        //[OperationContract]
        //[WebGet( UriTemplate = "Documents/{i}" )]
        //Stream GetAllDocuments(string i);

        //[OperationContract]
        //[WebGet( UriTemplate = "DocumentsCached/{i}" )]
        //Stream GetAllDocumentsCached( string i );

        [OperationContract]
        [WebInvoke( UriTemplate = "Documents/", Method = "POST" )]
        Stream InsertDocument( Stream data );

        [OperationContract]
        [WebInvoke( UriTemplate = "Documents/{id}", Method = "PUT" )]
        void UpdateDocument(Stream data, string id );

        [OperationContract]
        [WebGet( UriTemplate = "Documents?id={id}" )]
        Stream GetDocument( string id );
    }
}
