﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeHelper", Namespace="http://schemas.datacontract.org/2004/07/ConsoleApplication1")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(ConsoleApplication1.ServiceReference1.CompositeType))]
    public partial class CompositeHelper : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResultField;
        
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
        public string Result {
            get {
                return this.ResultField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultField, value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    
	public interface IContact
	{
		string FirstName { get; set; }
		string LastName { get; set; }
	}

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/ConsoleApplication1")]
    [System.SerializableAttribute()]
    public partial class CompositeType : ConsoleApplication1.ServiceReference1.CompositeHelper {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ХерПоймиField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ХерПойми {
            get {
                return this.ХерПоймиField;
            }
            set {
                if ((this.ХерПоймиField.Equals(value) != true)) {
                    this.ХерПоймиField = value;
                    this.RaisePropertyChanged("ХерПойми");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/ConsoleApplication1")]
    [System.SerializableAttribute()]
	public partial class Contact : IContact, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
	{
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetDataWithService2", ReplyAction="http://tempuri.org/IService2/GetDataWithService2Response")]
        string GetDataWithService2(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetDataWithService2", ReplyAction="http://tempuri.org/IService2/GetDataWithService2Response")]
        System.Threading.Tasks.Task<string> GetDataWithService2Async(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddContact", ReplyAction="http://tempuri.org/IService1/AddContactResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleApplication1.ServiceReference1.CompositeType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleApplication1.ServiceReference1.CompositeHelper))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleApplication1.ServiceReference1.Contact))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
		void AddContact(IContact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddContact", ReplyAction="http://tempuri.org/IService1/AddContactResponse")]
		System.Threading.Tasks.Task AddContactAsync(IContact contact);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetContancts", ReplyAction="http://tempuri.org/IService1/GetContanctsResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleApplication1.ServiceReference1.CompositeType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleApplication1.ServiceReference1.CompositeHelper))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ConsoleApplication1.ServiceReference1.Contact))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] GetContancts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetContancts", ReplyAction="http://tempuri.org/IService1/GetContanctsResponse")]
        System.Threading.Tasks.Task<object[]> GetContanctsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSimpleProperty", ReplyAction="http://tempuri.org/IService1/GetSimplePropertyResponse")]
        string GetSimpleProperty();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSimpleProperty", ReplyAction="http://tempuri.org/IService1/GetSimplePropertyResponse")]
        System.Threading.Tasks.Task<string> GetSimplePropertyAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataDouble", ReplyAction="http://tempuri.org/IService1/GetDataDoubleResponse")]
        string GetDataDouble(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataDouble", ReplyAction="http://tempuri.org/IService1/GetDataDoubleResponse")]
        System.Threading.Tasks.Task<string> GetDataDoubleAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        ConsoleApplication1.ServiceReference1.CompositeHelper GetDataUsingDataContract(ConsoleApplication1.ServiceReference1.CompositeHelper composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.CompositeHelper> GetDataUsingDataContractAsync(ConsoleApplication1.ServiceReference1.CompositeHelper composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract1", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContract1Response")]
        ConsoleApplication1.ServiceReference1.CompositeHelper GetDataUsingDataContract1(ConsoleApplication1.ServiceReference1.CompositeHelper composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract1", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContract1Response")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.CompositeHelper> GetDataUsingDataContract1Async(ConsoleApplication1.ServiceReference1.CompositeHelper composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleApplication1.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsoleApplication1.ServiceReference1.IService1>, ConsoleApplication1.ServiceReference1.IService1 {
        
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
        
        public string GetDataWithService2(int value) {
            return base.Channel.GetDataWithService2(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataWithService2Async(int value) {
            return base.Channel.GetDataWithService2Async(value);
        }

		public void AddContact(IContact contact)
		{
            base.Channel.AddContact(contact);
        }

		public System.Threading.Tasks.Task AddContactAsync(IContact contact)
		{
            return base.Channel.AddContactAsync(contact);
        }
        
        public object[] GetContancts() {
            return base.Channel.GetContancts();
        }
        
        public System.Threading.Tasks.Task<object[]> GetContanctsAsync() {
            return base.Channel.GetContanctsAsync();
        }
        
        public string GetSimpleProperty() {
            return base.Channel.GetSimpleProperty();
        }
        
        public System.Threading.Tasks.Task<string> GetSimplePropertyAsync() {
            return base.Channel.GetSimplePropertyAsync();
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string GetDataDouble(double value) {
            return base.Channel.GetDataDouble(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataDoubleAsync(double value) {
            return base.Channel.GetDataDoubleAsync(value);
        }
        
        public ConsoleApplication1.ServiceReference1.CompositeHelper GetDataUsingDataContract(ConsoleApplication1.ServiceReference1.CompositeHelper composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.CompositeHelper> GetDataUsingDataContractAsync(ConsoleApplication1.ServiceReference1.CompositeHelper composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public ConsoleApplication1.ServiceReference1.CompositeHelper GetDataUsingDataContract1(ConsoleApplication1.ServiceReference1.CompositeHelper composite) {
            return base.Channel.GetDataUsingDataContract1(composite);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.CompositeHelper> GetDataUsingDataContract1Async(ConsoleApplication1.ServiceReference1.CompositeHelper composite) {
            return base.Channel.GetDataUsingDataContract1Async(composite);
        }
    }
}
