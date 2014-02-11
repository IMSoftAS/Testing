﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataRetrivalTimerGUI.HttpDataAccess {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ArkivDocument", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class ArkivDocument : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CreatedByIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateCreatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NoteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TypeIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CreatedById {
            get {
                return this.CreatedByIdField;
            }
            set {
                if ((this.CreatedByIdField.Equals(value) != true)) {
                    this.CreatedByIdField = value;
                    this.RaisePropertyChanged("CreatedById");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateCreated {
            get {
                return this.DateCreatedField;
            }
            set {
                if ((this.DateCreatedField.Equals(value) != true)) {
                    this.DateCreatedField = value;
                    this.RaisePropertyChanged("DateCreated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Note {
            get {
                return this.NoteField;
            }
            set {
                if ((object.ReferenceEquals(this.NoteField, value) != true)) {
                    this.NoteField = value;
                    this.RaisePropertyChanged("Note");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TypeId {
            get {
                return this.TypeIdField;
            }
            set {
                if ((this.TypeIdField.Equals(value) != true)) {
                    this.TypeIdField = value;
                    this.RaisePropertyChanged("TypeId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HttpDataAccess.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        DataRetrivalTimerGUI.HttpDataAccess.GetDataResponse GetData(DataRetrivalTimerGUI.HttpDataAccess.GetDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<DataRetrivalTimerGUI.HttpDataAccess.GetDataResponse> GetDataAsync(DataRetrivalTimerGUI.HttpDataAccess.GetDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataString", ReplyAction="http://tempuri.org/IService1/GetDataStringResponse")]
        DataRetrivalTimerGUI.HttpDataAccess.GetDataStringResponse GetDataString(DataRetrivalTimerGUI.HttpDataAccess.GetDataStringRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataString", ReplyAction="http://tempuri.org/IService1/GetDataStringResponse")]
        System.Threading.Tasks.Task<DataRetrivalTimerGUI.HttpDataAccess.GetDataStringResponse> GetDataStringAsync(DataRetrivalTimerGUI.HttpDataAccess.GetDataStringRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllDocuments", ReplyAction="http://tempuri.org/IService1/GetAllDocumentsResponse")]
        DataRetrivalTimerGUI.HttpDataAccess.GetAllDocumentsResponse GetAllDocuments(DataRetrivalTimerGUI.HttpDataAccess.GetAllDocumentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllDocuments", ReplyAction="http://tempuri.org/IService1/GetAllDocumentsResponse")]
        System.Threading.Tasks.Task<DataRetrivalTimerGUI.HttpDataAccess.GetAllDocumentsResponse> GetAllDocumentsAsync(DataRetrivalTimerGUI.HttpDataAccess.GetAllDocumentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        DataRetrivalTimerGUI.HttpDataAccess.GetDataUsingDataContractResponse GetDataUsingDataContract(DataRetrivalTimerGUI.HttpDataAccess.GetDataUsingDataContractRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<DataRetrivalTimerGUI.HttpDataAccess.GetDataUsingDataContractResponse> GetDataUsingDataContractAsync(DataRetrivalTimerGUI.HttpDataAccess.GetDataUsingDataContractRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetData", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int value;
        
        public GetDataRequest() {
        }
        
        public GetDataRequest(int value) {
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string GetDataResult;
        
        public GetDataResponse() {
        }
        
        public GetDataResponse(string GetDataResult) {
            this.GetDataResult = GetDataResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataString", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataStringRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string s;
        
        public GetDataStringRequest() {
        }
        
        public GetDataStringRequest(string s) {
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataStringResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataStringResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string GetDataStringResult;
        
        public GetDataStringResponse() {
        }
        
        public GetDataStringResponse(string GetDataStringResult) {
            this.GetDataStringResult = GetDataStringResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllDocuments", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllDocumentsRequest {
        
        public GetAllDocumentsRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllDocumentsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllDocumentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public DataRetrivalTimerGUI.HttpDataAccess.ArkivDocument[] GetAllDocumentsResult;
        
        public GetAllDocumentsResponse() {
        }
        
        public GetAllDocumentsResponse(DataRetrivalTimerGUI.HttpDataAccess.ArkivDocument[] GetAllDocumentsResult) {
            this.GetAllDocumentsResult = GetAllDocumentsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataUsingDataContract", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataUsingDataContractRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public DataRetrivalTimerGUI.HttpDataAccess.CompositeType composite;
        
        public GetDataUsingDataContractRequest() {
        }
        
        public GetDataUsingDataContractRequest(DataRetrivalTimerGUI.HttpDataAccess.CompositeType composite) {
            this.composite = composite;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetDataUsingDataContractResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetDataUsingDataContractResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public DataRetrivalTimerGUI.HttpDataAccess.CompositeType GetDataUsingDataContractResult;
        
        public GetDataUsingDataContractResponse() {
        }
        
        public GetDataUsingDataContractResponse(DataRetrivalTimerGUI.HttpDataAccess.CompositeType GetDataUsingDataContractResult) {
            this.GetDataUsingDataContractResult = GetDataUsingDataContractResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DataRetrivalTimerGUI.HttpDataAccess.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DataRetrivalTimerGUI.HttpDataAccess.IService1>, DataRetrivalTimerGUI.HttpDataAccess.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DataRetrivalTimerGUI.HttpDataAccess.GetDataResponse GetData(DataRetrivalTimerGUI.HttpDataAccess.GetDataRequest request) {
            return base.Channel.GetData(request);
        }
        
        public System.Threading.Tasks.Task<DataRetrivalTimerGUI.HttpDataAccess.GetDataResponse> GetDataAsync(DataRetrivalTimerGUI.HttpDataAccess.GetDataRequest request) {
            return base.Channel.GetDataAsync(request);
        }
        
        public DataRetrivalTimerGUI.HttpDataAccess.GetDataStringResponse GetDataString(DataRetrivalTimerGUI.HttpDataAccess.GetDataStringRequest request) {
            return base.Channel.GetDataString(request);
        }
        
        public System.Threading.Tasks.Task<DataRetrivalTimerGUI.HttpDataAccess.GetDataStringResponse> GetDataStringAsync(DataRetrivalTimerGUI.HttpDataAccess.GetDataStringRequest request) {
            return base.Channel.GetDataStringAsync(request);
        }
        
        public DataRetrivalTimerGUI.HttpDataAccess.GetAllDocumentsResponse GetAllDocuments(DataRetrivalTimerGUI.HttpDataAccess.GetAllDocumentsRequest request) {
            return base.Channel.GetAllDocuments(request);
        }
        
        public System.Threading.Tasks.Task<DataRetrivalTimerGUI.HttpDataAccess.GetAllDocumentsResponse> GetAllDocumentsAsync(DataRetrivalTimerGUI.HttpDataAccess.GetAllDocumentsRequest request) {
            return base.Channel.GetAllDocumentsAsync(request);
        }
        
        public DataRetrivalTimerGUI.HttpDataAccess.GetDataUsingDataContractResponse GetDataUsingDataContract(DataRetrivalTimerGUI.HttpDataAccess.GetDataUsingDataContractRequest request) {
            return base.Channel.GetDataUsingDataContract(request);
        }
        
        public System.Threading.Tasks.Task<DataRetrivalTimerGUI.HttpDataAccess.GetDataUsingDataContractResponse> GetDataUsingDataContractAsync(DataRetrivalTimerGUI.HttpDataAccess.GetDataUsingDataContractRequest request) {
            return base.Channel.GetDataUsingDataContractAsync(request);
        }
    }
}