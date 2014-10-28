﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientService.PeopleReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Details", Namespace="http://schemas.datacontract.org/2004/07/PeopleServiceLib")]
    [System.SerializableAttribute()]
    public partial class Details : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
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
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="PeopleReference.IPeopleService")]
    public interface IPeopleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IPeopleService/GetName", ReplyAction="http://Microsoft.ServiceModel.Samples/IPeopleService/GetNameResponse")]
        string GetName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IPeopleService/GetName", ReplyAction="http://Microsoft.ServiceModel.Samples/IPeopleService/GetNameResponse")]
        System.Threading.Tasks.Task<string> GetNameAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IPeopleService/GetCountry", ReplyAction="http://Microsoft.ServiceModel.Samples/IPeopleService/GetCountryResponse")]
        string GetCountry(string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IPeopleService/GetCountry", ReplyAction="http://Microsoft.ServiceModel.Samples/IPeopleService/GetCountryResponse")]
        System.Threading.Tasks.Task<string> GetCountryAsync(string country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IPeopleService/GetPerson", ReplyAction="http://Microsoft.ServiceModel.Samples/IPeopleService/GetPersonResponse")]
        ClientService.PeopleReference.Details GetPerson(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IPeopleService/GetPerson", ReplyAction="http://Microsoft.ServiceModel.Samples/IPeopleService/GetPersonResponse")]
        System.Threading.Tasks.Task<ClientService.PeopleReference.Details> GetPersonAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IPeopleService/GetListOfPeople", ReplyAction="http://Microsoft.ServiceModel.Samples/IPeopleService/GetListOfPeopleResponse")]
        ClientService.PeopleReference.Details[] GetListOfPeople();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IPeopleService/GetListOfPeople", ReplyAction="http://Microsoft.ServiceModel.Samples/IPeopleService/GetListOfPeopleResponse")]
        System.Threading.Tasks.Task<ClientService.PeopleReference.Details[]> GetListOfPeopleAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPeopleServiceChannel : ClientService.PeopleReference.IPeopleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeopleServiceClient : System.ServiceModel.ClientBase<ClientService.PeopleReference.IPeopleService>, ClientService.PeopleReference.IPeopleService {
        
        public PeopleServiceClient() {
        }
        
        public PeopleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeopleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeopleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetName(string name) {
            return base.Channel.GetName(name);
        }
        
        public System.Threading.Tasks.Task<string> GetNameAsync(string name) {
            return base.Channel.GetNameAsync(name);
        }
        
        public string GetCountry(string country) {
            return base.Channel.GetCountry(country);
        }
        
        public System.Threading.Tasks.Task<string> GetCountryAsync(string country) {
            return base.Channel.GetCountryAsync(country);
        }
        
        public ClientService.PeopleReference.Details GetPerson(string name) {
            return base.Channel.GetPerson(name);
        }
        
        public System.Threading.Tasks.Task<ClientService.PeopleReference.Details> GetPersonAsync(string name) {
            return base.Channel.GetPersonAsync(name);
        }
        
        public ClientService.PeopleReference.Details[] GetListOfPeople() {
            return base.Channel.GetListOfPeople();
        }
        
        public System.Threading.Tasks.Task<ClientService.PeopleReference.Details[]> GetListOfPeopleAsync() {
            return base.Channel.GetListOfPeopleAsync();
        }
    }
}
