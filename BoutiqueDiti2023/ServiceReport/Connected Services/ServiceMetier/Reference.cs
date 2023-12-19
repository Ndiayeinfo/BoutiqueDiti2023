﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReport.ServiceMetier {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Produits", Namespace="http://schemas.datacontract.org/2004/07/ServiceMetier.Model")]
    [System.SerializableAttribute()]
    public partial class Produits : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionProduitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameProduitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceProduitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> QteMinimalField;
        
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
        public string DescriptionProduit {
            get {
                return this.DescriptionProduitField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionProduitField, value) != true)) {
                    this.DescriptionProduitField = value;
                    this.RaisePropertyChanged("DescriptionProduit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NameProduit {
            get {
                return this.NameProduitField;
            }
            set {
                if ((object.ReferenceEquals(this.NameProduitField, value) != true)) {
                    this.NameProduitField = value;
                    this.RaisePropertyChanged("NameProduit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PriceProduit {
            get {
                return this.PriceProduitField;
            }
            set {
                if ((this.PriceProduitField.Equals(value) != true)) {
                    this.PriceProduitField = value;
                    this.RaisePropertyChanged("PriceProduit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> QteMinimal {
            get {
                return this.QteMinimalField;
            }
            set {
                if ((this.QteMinimalField.Equals(value) != true)) {
                    this.QteMinimalField = value;
                    this.RaisePropertyChanged("QteMinimal");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceMetier.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListeProduit", ReplyAction="http://tempuri.org/IService1/getListeProduitResponse")]
        ServiceReport.ServiceMetier.Produits[] getListeProduit();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getListeProduit", ReplyAction="http://tempuri.org/IService1/getListeProduitResponse")]
        System.Threading.Tasks.Task<ServiceReport.ServiceMetier.Produits[]> getListeProduitAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddProduit", ReplyAction="http://tempuri.org/IService1/AddProduitResponse")]
        bool AddProduit(ServiceReport.ServiceMetier.Produits produit);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddProduit", ReplyAction="http://tempuri.org/IService1/AddProduitResponse")]
        System.Threading.Tasks.Task<bool> AddProduitAsync(ServiceReport.ServiceMetier.Produits produit);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ServiceReport.ServiceMetier.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiceReport.ServiceMetier.IService1>, ServiceReport.ServiceMetier.IService1 {
        
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
        
        public ServiceReport.ServiceMetier.Produits[] getListeProduit() {
            return base.Channel.getListeProduit();
        }
        
        public System.Threading.Tasks.Task<ServiceReport.ServiceMetier.Produits[]> getListeProduitAsync() {
            return base.Channel.getListeProduitAsync();
        }
        
        public bool AddProduit(ServiceReport.ServiceMetier.Produits produit) {
            return base.Channel.AddProduit(produit);
        }
        
        public System.Threading.Tasks.Task<bool> AddProduitAsync(ServiceReport.ServiceMetier.Produits produit) {
            return base.Channel.AddProduitAsync(produit);
        }
    }
}