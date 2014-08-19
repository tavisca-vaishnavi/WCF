﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace client.myservice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Remarks", Namespace="http://schemas.datacontract.org/2004/07/assg")]
    [System.SerializableAttribute()]
    public partial class Remarks : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime GetDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RemarkField;
        
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
        public System.DateTime GetDateTime {
            get {
                return this.GetDateTimeField;
            }
            set {
                if ((this.GetDateTimeField.Equals(value) != true)) {
                    this.GetDateTimeField = value;
                    this.RaisePropertyChanged("GetDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Remark {
            get {
                return this.RemarkField;
            }
            set {
                if ((object.ReferenceEquals(this.RemarkField, value) != true)) {
                    this.RemarkField = value;
                    this.RaisePropertyChanged("Remark");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/assg")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="myservice.IAddEmpRecords")]
    public interface IAddEmpRecords {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmpRecords/AddEmployee", ReplyAction="http://tempuri.org/IAddEmpRecords/AddEmployeeResponse")]
        string AddEmployee(string id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmpRecords/AddEmployee", ReplyAction="http://tempuri.org/IAddEmpRecords/AddEmployeeResponse")]
        System.Threading.Tasks.Task<string> AddEmployeeAsync(string id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmpRecords/delete", ReplyAction="http://tempuri.org/IAddEmpRecords/deleteResponse")]
        int delete(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmpRecords/delete", ReplyAction="http://tempuri.org/IAddEmpRecords/deleteResponse")]
        System.Threading.Tasks.Task<int> deleteAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmpRecords/AddRemarks", ReplyAction="http://tempuri.org/IAddEmpRecords/AddRemarksResponse")]
        client.myservice.Remarks AddRemarks(string id, string remarks);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmpRecords/AddRemarks", ReplyAction="http://tempuri.org/IAddEmpRecords/AddRemarksResponse")]
        System.Threading.Tasks.Task<client.myservice.Remarks> AddRemarksAsync(string id, string remarks);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmpRecords/ClearAllData", ReplyAction="http://tempuri.org/IAddEmpRecords/ClearAllDataResponse")]
        void ClearAllData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAddEmpRecords/ClearAllData", ReplyAction="http://tempuri.org/IAddEmpRecords/ClearAllDataResponse")]
        System.Threading.Tasks.Task ClearAllDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAddEmpRecordsChannel : client.myservice.IAddEmpRecords, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddEmpRecordsClient : System.ServiceModel.ClientBase<client.myservice.IAddEmpRecords>, client.myservice.IAddEmpRecords {
        
        public AddEmpRecordsClient() {
        }
        
        public AddEmpRecordsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AddEmpRecordsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddEmpRecordsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddEmpRecordsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddEmployee(string id, string name) {
            return base.Channel.AddEmployee(id, name);
        }
        
        public System.Threading.Tasks.Task<string> AddEmployeeAsync(string id, string name) {
            return base.Channel.AddEmployeeAsync(id, name);
        }
        
        public int delete(string id) {
            return base.Channel.delete(id);
        }
        
        public System.Threading.Tasks.Task<int> deleteAsync(string id) {
            return base.Channel.deleteAsync(id);
        }
        
        public client.myservice.Remarks AddRemarks(string id, string remarks) {
            return base.Channel.AddRemarks(id, remarks);
        }
        
        public System.Threading.Tasks.Task<client.myservice.Remarks> AddRemarksAsync(string id, string remarks) {
            return base.Channel.AddRemarksAsync(id, remarks);
        }
        
        public void ClearAllData() {
            base.Channel.ClearAllData();
        }
        
        public System.Threading.Tasks.Task ClearAllDataAsync() {
            return base.Channel.ClearAllDataAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="myservice.IRetrieveDetails")]
    public interface IRetrieveDetails {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/Search", ReplyAction="http://tempuri.org/IRetrieveDetails/SearchResponse")]
        client.myservice.Employee Search(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/Search", ReplyAction="http://tempuri.org/IRetrieveDetails/SearchResponse")]
        System.Threading.Tasks.Task<client.myservice.Employee> SearchAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/SearchByName", ReplyAction="http://tempuri.org/IRetrieveDetails/SearchByNameResponse")]
        client.myservice.Employee SearchByName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/SearchByName", ReplyAction="http://tempuri.org/IRetrieveDetails/SearchByNameResponse")]
        System.Threading.Tasks.Task<client.myservice.Employee> SearchByNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/GetAllDetails", ReplyAction="http://tempuri.org/IRetrieveDetails/GetAllDetailsResponse")]
        System.Collections.Generic.List<client.myservice.Employee> GetAllDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/GetAllDetails", ReplyAction="http://tempuri.org/IRetrieveDetails/GetAllDetailsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<client.myservice.Employee>> GetAllDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/GetAllRemarks", ReplyAction="http://tempuri.org/IRetrieveDetails/GetAllRemarksResponse")]
        System.Collections.Generic.List<client.myservice.Remarks> GetAllRemarks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/GetAllRemarks", ReplyAction="http://tempuri.org/IRetrieveDetails/GetAllRemarksResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<client.myservice.Remarks>> GetAllRemarksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/GetNameFromId", ReplyAction="http://tempuri.org/IRetrieveDetails/GetNameFromIdResponse")]
        string GetNameFromId(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/GetNameFromId", ReplyAction="http://tempuri.org/IRetrieveDetails/GetNameFromIdResponse")]
        System.Threading.Tasks.Task<string> GetNameFromIdAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/GetRemarks", ReplyAction="http://tempuri.org/IRetrieveDetails/GetRemarksResponse")]
        System.Collections.Generic.List<client.myservice.Remarks> GetRemarks(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieveDetails/GetRemarks", ReplyAction="http://tempuri.org/IRetrieveDetails/GetRemarksResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<client.myservice.Remarks>> GetRemarksAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRetrieveDetailsChannel : client.myservice.IRetrieveDetails, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RetrieveDetailsClient : System.ServiceModel.ClientBase<client.myservice.IRetrieveDetails>, client.myservice.IRetrieveDetails {
        
        public RetrieveDetailsClient() {
        }
        
        public RetrieveDetailsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RetrieveDetailsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RetrieveDetailsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RetrieveDetailsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public client.myservice.Employee Search(string id) {
            return base.Channel.Search(id);
        }
        
        public System.Threading.Tasks.Task<client.myservice.Employee> SearchAsync(string id) {
            return base.Channel.SearchAsync(id);
        }
        
        public client.myservice.Employee SearchByName(string name) {
            return base.Channel.SearchByName(name);
        }
        
        public System.Threading.Tasks.Task<client.myservice.Employee> SearchByNameAsync(string name) {
            return base.Channel.SearchByNameAsync(name);
        }
        
        public System.Collections.Generic.List<client.myservice.Employee> GetAllDetails() {
            return base.Channel.GetAllDetails();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<client.myservice.Employee>> GetAllDetailsAsync() {
            return base.Channel.GetAllDetailsAsync();
        }
        
        public System.Collections.Generic.List<client.myservice.Remarks> GetAllRemarks() {
            return base.Channel.GetAllRemarks();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<client.myservice.Remarks>> GetAllRemarksAsync() {
            return base.Channel.GetAllRemarksAsync();
        }
        
        public string GetNameFromId(string id) {
            return base.Channel.GetNameFromId(id);
        }
        
        public System.Threading.Tasks.Task<string> GetNameFromIdAsync(string id) {
            return base.Channel.GetNameFromIdAsync(id);
        }
        
        public System.Collections.Generic.List<client.myservice.Remarks> GetRemarks(string id) {
            return base.Channel.GetRemarks(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<client.myservice.Remarks>> GetRemarksAsync(string id) {
            return base.Channel.GetRemarksAsync(id);
        }
    }
}
