﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryApp.ServiceSubscriptions {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Subscription", Namespace="http://schemas.datacontract.org/2004/07/DataBase.Db.DbUsers.Models")]
    [System.SerializableAttribute()]
    public partial class Subscription : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsNewField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsReturnedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SubscriptionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LibraryApp.ServiceSubscriptions.User UserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        public string Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsNew {
            get {
                return this.IsNewField;
            }
            set {
                if ((this.IsNewField.Equals(value) != true)) {
                    this.IsNewField = value;
                    this.RaisePropertyChanged("IsNew");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsReturned {
            get {
                return this.IsReturnedField;
            }
            set {
                if ((this.IsReturnedField.Equals(value) != true)) {
                    this.IsReturnedField = value;
                    this.RaisePropertyChanged("IsReturned");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SubscriptionId {
            get {
                return this.SubscriptionIdField;
            }
            set {
                if ((this.SubscriptionIdField.Equals(value) != true)) {
                    this.SubscriptionIdField = value;
                    this.RaisePropertyChanged("SubscriptionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LibraryApp.ServiceSubscriptions.User User {
            get {
                return this.UserField;
            }
            set {
                if ((object.ReferenceEquals(this.UserField, value) != true)) {
                    this.UserField = value;
                    this.RaisePropertyChanged("User");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/DataBase.Db.DbUsers.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SaltField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserPasswordField;
        
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
        public string Salt {
            get {
                return this.SaltField;
            }
            set {
                if ((object.ReferenceEquals(this.SaltField, value) != true)) {
                    this.SaltField = value;
                    this.RaisePropertyChanged("Salt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserPassword {
            get {
                return this.UserPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.UserPasswordField, value) != true)) {
                    this.UserPasswordField = value;
                    this.RaisePropertyChanged("UserPassword");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceSubscriptions.IServiceSubscriptions")]
    public interface IServiceSubscriptions {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSubscriptions/DeleteSubscription", ReplyAction="http://tempuri.org/IServiceSubscriptions/DeleteSubscriptionResponse")]
        void DeleteSubscription(int subscriptionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSubscriptions/DeleteSubscription", ReplyAction="http://tempuri.org/IServiceSubscriptions/DeleteSubscriptionResponse")]
        System.Threading.Tasks.Task DeleteSubscriptionAsync(int subscriptionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSubscriptions/AddSubscription", ReplyAction="http://tempuri.org/IServiceSubscriptions/AddSubscriptionResponse")]
        bool AddSubscription(bool newS, bool retS, int userId, string genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSubscriptions/AddSubscription", ReplyAction="http://tempuri.org/IServiceSubscriptions/AddSubscriptionResponse")]
        System.Threading.Tasks.Task<bool> AddSubscriptionAsync(bool newS, bool retS, int userId, string genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSubscriptions/GetUserSubscriptions", ReplyAction="http://tempuri.org/IServiceSubscriptions/GetUserSubscriptionsResponse")]
        LibraryApp.ServiceSubscriptions.Subscription[] GetUserSubscriptions(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSubscriptions/GetUserSubscriptions", ReplyAction="http://tempuri.org/IServiceSubscriptions/GetUserSubscriptionsResponse")]
        System.Threading.Tasks.Task<LibraryApp.ServiceSubscriptions.Subscription[]> GetUserSubscriptionsAsync(int userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSubscriptionsChannel : LibraryApp.ServiceSubscriptions.IServiceSubscriptions, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSubscriptionsClient : System.ServiceModel.ClientBase<LibraryApp.ServiceSubscriptions.IServiceSubscriptions>, LibraryApp.ServiceSubscriptions.IServiceSubscriptions {
        
        public ServiceSubscriptionsClient() {
        }
        
        public ServiceSubscriptionsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSubscriptionsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSubscriptionsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSubscriptionsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DeleteSubscription(int subscriptionId) {
            base.Channel.DeleteSubscription(subscriptionId);
        }
        
        public System.Threading.Tasks.Task DeleteSubscriptionAsync(int subscriptionId) {
            return base.Channel.DeleteSubscriptionAsync(subscriptionId);
        }
        
        public bool AddSubscription(bool newS, bool retS, int userId, string genre) {
            return base.Channel.AddSubscription(newS, retS, userId, genre);
        }
        
        public System.Threading.Tasks.Task<bool> AddSubscriptionAsync(bool newS, bool retS, int userId, string genre) {
            return base.Channel.AddSubscriptionAsync(newS, retS, userId, genre);
        }
        
        public LibraryApp.ServiceSubscriptions.Subscription[] GetUserSubscriptions(int userId) {
            return base.Channel.GetUserSubscriptions(userId);
        }
        
        public System.Threading.Tasks.Task<LibraryApp.ServiceSubscriptions.Subscription[]> GetUserSubscriptionsAsync(int userId) {
            return base.Channel.GetUserSubscriptionsAsync(userId);
        }
    }
}
