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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="MyCollection", Namespace="http://schemas.datacontract.org/2004/07/ConsoleApplication1", ItemName="Color")]
    [System.SerializableAttribute()]
    public class MyCollection : System.Collections.Generic.List<ConsoleApplication1.ServiceReference1.Color> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Color", Namespace="http://schemas.datacontract.org/2004/07/ConsoleApplication1")]
    [System.SerializableAttribute()]
    public partial class Color : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Gggg", Namespace="http://schemas.datacontract.org/2004/07/ConsoleApplication1")]
    public enum Gggg : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        dgdgf = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCollection", ReplyAction="http://tempuri.org/IService1/GetCollectionResponse")]
        ConsoleApplication1.ServiceReference1.MyCollection GetCollection(string[] people);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetCollection", ReplyAction="http://tempuri.org/IService1/GetCollectionResponse")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.MyCollection> GetCollectionAsync(string[] people);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEnum", ReplyAction="http://tempuri.org/IService1/GetEnumResponse")]
        ConsoleApplication1.ServiceReference1.Gggg GetEnum();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetEnum", ReplyAction="http://tempuri.org/IService1/GetEnumResponse")]
        System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.Gggg> GetEnumAsync();
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
        
        public ConsoleApplication1.ServiceReference1.MyCollection GetCollection(string[] people) {
            return base.Channel.GetCollection(people);
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.MyCollection> GetCollectionAsync(string[] people) {
            return base.Channel.GetCollectionAsync(people);
        }
        
        public ConsoleApplication1.ServiceReference1.Gggg GetEnum() {
            return base.Channel.GetEnum();
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication1.ServiceReference1.Gggg> GetEnumAsync() {
            return base.Channel.GetEnumAsync();
        }
    }
}
