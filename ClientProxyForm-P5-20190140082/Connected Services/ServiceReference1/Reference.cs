﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientProxyForm_P5_20190140082.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Koordinat", Namespace="http://schemas.datacontract.org/2004/07/ServiceMtk_P1_20190140082")]
    [System.SerializableAttribute()]
    public partial class Koordinat : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int XField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YField;
        
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
        public int X {
            get {
                return this.XField;
            }
            set {
                if ((this.XField.Equals(value) != true)) {
                    this.XField = value;
                    this.RaisePropertyChanged("X");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Y {
            get {
                return this.YField;
            }
            set {
                if ((this.YField.Equals(value) != true)) {
                    this.YField = value;
                    this.RaisePropertyChanged("Y");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMatematika")]
    public interface IMatematika {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Tambah", ReplyAction="http://tempuri.org/IMatematika/TambahResponse")]
        int Tambah(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Tambah", ReplyAction="http://tempuri.org/IMatematika/TambahResponse")]
        System.Threading.Tasks.Task<int> TambahAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kurang", ReplyAction="http://tempuri.org/IMatematika/KurangResponse")]
        int Kurang(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kurang", ReplyAction="http://tempuri.org/IMatematika/KurangResponse")]
        System.Threading.Tasks.Task<int> KurangAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kali", ReplyAction="http://tempuri.org/IMatematika/KaliResponse")]
        int Kali(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Kali", ReplyAction="http://tempuri.org/IMatematika/KaliResponse")]
        System.Threading.Tasks.Task<int> KaliAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Bagi", ReplyAction="http://tempuri.org/IMatematika/BagiResponse")]
        int Bagi(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/Bagi", ReplyAction="http://tempuri.org/IMatematika/BagiResponse")]
        System.Threading.Tasks.Task<int> BagiAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/TKoordinat", ReplyAction="http://tempuri.org/IMatematika/TKoordinatResponse")]
        ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat TKoordinat(ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat a, ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMatematika/TKoordinat", ReplyAction="http://tempuri.org/IMatematika/TKoordinatResponse")]
        System.Threading.Tasks.Task<ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat> TKoordinatAsync(ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat a, ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMatematikaChannel : ClientProxyForm_P5_20190140082.ServiceReference1.IMatematika, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MatematikaClient : System.ServiceModel.ClientBase<ClientProxyForm_P5_20190140082.ServiceReference1.IMatematika>, ClientProxyForm_P5_20190140082.ServiceReference1.IMatematika {
        
        public MatematikaClient() {
        }
        
        public MatematikaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MatematikaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatematikaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MatematikaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Tambah(int a, int b) {
            return base.Channel.Tambah(a, b);
        }
        
        public System.Threading.Tasks.Task<int> TambahAsync(int a, int b) {
            return base.Channel.TambahAsync(a, b);
        }
        
        public int Kurang(int a, int b) {
            return base.Channel.Kurang(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KurangAsync(int a, int b) {
            return base.Channel.KurangAsync(a, b);
        }
        
        public int Kali(int a, int b) {
            return base.Channel.Kali(a, b);
        }
        
        public System.Threading.Tasks.Task<int> KaliAsync(int a, int b) {
            return base.Channel.KaliAsync(a, b);
        }
        
        public int Bagi(int a, int b) {
            return base.Channel.Bagi(a, b);
        }
        
        public System.Threading.Tasks.Task<int> BagiAsync(int a, int b) {
            return base.Channel.BagiAsync(a, b);
        }
        
        public ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat TKoordinat(ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat a, ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat b) {
            return base.Channel.TKoordinat(a, b);
        }
        
        public System.Threading.Tasks.Task<ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat> TKoordinatAsync(ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat a, ClientProxyForm_P5_20190140082.ServiceReference1.Koordinat b) {
            return base.Channel.TKoordinatAsync(a, b);
        }
    }
}
