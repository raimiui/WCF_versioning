﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClient_Semi_Strict_Ver1.MySvcSemiStrict {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmpInfo", Namespace="http://schemas.mynamespace.com/samples/2012/03")]
    [System.SerializableAttribute()]
    public partial class EmpInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EmpIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmpNameField;
        
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
        public int EmpID {
            get {
                return this.EmpIDField;
            }
            set {
                if ((this.EmpIDField.Equals(value) != true)) {
                    this.EmpIDField = value;
                    this.RaisePropertyChanged("EmpID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmpName {
            get {
                return this.EmpNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmpNameField, value) != true)) {
                    this.EmpNameField = value;
                    this.RaisePropertyChanged("EmpName");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.mynamespace.com/samples/2012/04", ConfigurationName="MySvcSemiStrict.ServiceAContract")]
    public interface ServiceAContract {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://www.mynamespace.com/samples/2012/03) of message UpdateEmployeeDataRequest does not match the default value (http://www.mynamespace.com/samples/2012/04)
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mynamespace.com/samples/2012/03/ServiceAContract/UpdateEmployeeData", ReplyAction="http://www.mynamespace.com/samples/2012/03/ServiceAContract/UpdateEmployeeDataRes" +
            "ponse")]
        WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.UpdateEmployeeDataResponse UpdateEmployeeData(WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.UpdateEmployeeDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mynamespace.com/samples/2012/04/ServiceAContract/GetEmployeeDatabyID", ReplyAction="http://www.mynamespace.com/samples/2012/04/ServiceAContract/GetEmployeeDatabyIDRe" +
            "sponse")]
        WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo GetEmployeeDatabyID(int EmpID);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateEmployeeData", WrapperNamespace="http://www.mynamespace.com/samples/2012/03", IsWrapped=true)]
    public partial class UpdateEmployeeDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.mynamespace.com/samples/2012/03", Order=0)]
        public WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo info;
        
        public UpdateEmployeeDataRequest() {
        }
        
        public UpdateEmployeeDataRequest(WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo info) {
            this.info = info;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateEmployeeDataResponse", WrapperNamespace="http://www.mynamespace.com/samples/2012/03", IsWrapped=true)]
    public partial class UpdateEmployeeDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.mynamespace.com/samples/2012/03", Order=0)]
        public WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo UpdateEmployeeDataResult;
        
        public UpdateEmployeeDataResponse() {
        }
        
        public UpdateEmployeeDataResponse(WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo UpdateEmployeeDataResult) {
            this.UpdateEmployeeDataResult = UpdateEmployeeDataResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceAContractChannel : WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.ServiceAContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAContractClient : System.ServiceModel.ClientBase<WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.ServiceAContract>, WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.ServiceAContract {
        
        public ServiceAContractClient() {
        }
        
        public ServiceAContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.UpdateEmployeeDataResponse WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.ServiceAContract.UpdateEmployeeData(WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.UpdateEmployeeDataRequest request) {
            return base.Channel.UpdateEmployeeData(request);
        }
        
        public WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo UpdateEmployeeData(WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo info) {
            WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.UpdateEmployeeDataRequest inValue = new WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.UpdateEmployeeDataRequest();
            inValue.info = info;
            WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.UpdateEmployeeDataResponse retVal = ((WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.ServiceAContract)(this)).UpdateEmployeeData(inValue);
            return retVal.UpdateEmployeeDataResult;
        }
        
        public WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo GetEmployeeDatabyID(int EmpID) {
            return base.Channel.GetEmployeeDatabyID(EmpID);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Name="ServiceAContract", Namespace="http://www.mynamespace.com/samples/2012/03", ConfigurationName="MySvcSemiStrict.ServiceAContract1")]
    public interface ServiceAContract1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mynamespace.com/samples/2012/03/ServiceAContract/UpdateEmployeeData", ReplyAction="http://www.mynamespace.com/samples/2012/03/ServiceAContract/UpdateEmployeeDataRes" +
            "ponse")]
        WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo UpdateEmployeeData(WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo info);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceAContract1Channel : WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.ServiceAContract1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceAContract1Client : System.ServiceModel.ClientBase<WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.ServiceAContract1>, WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.ServiceAContract1 {
        
        public ServiceAContract1Client() {
        }
        
        public ServiceAContract1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceAContract1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAContract1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceAContract1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo UpdateEmployeeData(WCFClient_Semi_Strict_Ver1.MySvcSemiStrict.EmpInfo info) {
            return base.Channel.UpdateEmployeeData(info);
        }
    }
}
