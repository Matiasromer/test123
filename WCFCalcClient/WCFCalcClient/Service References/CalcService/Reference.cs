﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFCalcClient.CalcService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WCFServiceCalculator")]
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalcService.ICalcService")]
    public interface ICalcService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/GetData", ReplyAction="http://tempuri.org/ICalcService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/GetData", ReplyAction="http://tempuri.org/ICalcService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/plus", ReplyAction="http://tempuri.org/ICalcService/plusResponse")]
        double plus(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/plus", ReplyAction="http://tempuri.org/ICalcService/plusResponse")]
        System.Threading.Tasks.Task<double> plusAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Minus", ReplyAction="http://tempuri.org/ICalcService/MinusResponse")]
        double Minus(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Minus", ReplyAction="http://tempuri.org/ICalcService/MinusResponse")]
        System.Threading.Tasks.Task<double> MinusAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Divider", ReplyAction="http://tempuri.org/ICalcService/DividerResponse")]
        double Divider(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Divider", ReplyAction="http://tempuri.org/ICalcService/DividerResponse")]
        System.Threading.Tasks.Task<double> DividerAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Gange", ReplyAction="http://tempuri.org/ICalcService/GangeResponse")]
        double Gange(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/Gange", ReplyAction="http://tempuri.org/ICalcService/GangeResponse")]
        System.Threading.Tasks.Task<double> GangeAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICalcService/GetDataUsingDataContractResponse")]
        WCFCalcClient.CalcService.CompositeType GetDataUsingDataContract(WCFCalcClient.CalcService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ICalcService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WCFCalcClient.CalcService.CompositeType> GetDataUsingDataContractAsync(WCFCalcClient.CalcService.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcServiceChannel : WCFCalcClient.CalcService.ICalcService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcServiceClient : System.ServiceModel.ClientBase<WCFCalcClient.CalcService.ICalcService>, WCFCalcClient.CalcService.ICalcService {
        
        public CalcServiceClient() {
        }
        
        public CalcServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public double plus(int a, int b) {
            return base.Channel.plus(a, b);
        }
        
        public System.Threading.Tasks.Task<double> plusAsync(int a, int b) {
            return base.Channel.plusAsync(a, b);
        }
        
        public double Minus(int a, int b) {
            return base.Channel.Minus(a, b);
        }
        
        public System.Threading.Tasks.Task<double> MinusAsync(int a, int b) {
            return base.Channel.MinusAsync(a, b);
        }
        
        public double Divider(int a, int b) {
            return base.Channel.Divider(a, b);
        }
        
        public System.Threading.Tasks.Task<double> DividerAsync(int a, int b) {
            return base.Channel.DividerAsync(a, b);
        }
        
        public double Gange(int a, int b) {
            return base.Channel.Gange(a, b);
        }
        
        public System.Threading.Tasks.Task<double> GangeAsync(int a, int b) {
            return base.Channel.GangeAsync(a, b);
        }
        
        public WCFCalcClient.CalcService.CompositeType GetDataUsingDataContract(WCFCalcClient.CalcService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WCFCalcClient.CalcService.CompositeType> GetDataUsingDataContractAsync(WCFCalcClient.CalcService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}