﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryApp.ServiceLogin {
    using System.Runtime.Serialization;
    using System;
    
    
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Card", Namespace="http://schemas.datacontract.org/2004/07/DataBase.Db.DbUsers.Models")]
    [System.SerializableAttribute()]
    public partial class Card : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CardIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OwnerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OwnerSurnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LibraryApp.ServiceLogin.User UserField;
        
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
        public int CardId {
            get {
                return this.CardIdField;
            }
            set {
                if ((this.CardIdField.Equals(value) != true)) {
                    this.CardIdField = value;
                    this.RaisePropertyChanged("CardId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OwnerName {
            get {
                return this.OwnerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.OwnerNameField, value) != true)) {
                    this.OwnerNameField = value;
                    this.RaisePropertyChanged("OwnerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OwnerSurname {
            get {
                return this.OwnerSurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.OwnerSurnameField, value) != true)) {
                    this.OwnerSurnameField = value;
                    this.RaisePropertyChanged("OwnerSurname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LibraryApp.ServiceLogin.User User {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="History", Namespace="http://schemas.datacontract.org/2004/07/DataBase.Db.DbUsers.Models")]
    [System.SerializableAttribute()]
    public partial class History : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LibraryApp.ServiceLogin.Card CardField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CardIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HistoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ToField;
        
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
        public int BookId {
            get {
                return this.BookIdField;
            }
            set {
                if ((this.BookIdField.Equals(value) != true)) {
                    this.BookIdField = value;
                    this.RaisePropertyChanged("BookId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LibraryApp.ServiceLogin.Card Card {
            get {
                return this.CardField;
            }
            set {
                if ((object.ReferenceEquals(this.CardField, value) != true)) {
                    this.CardField = value;
                    this.RaisePropertyChanged("Card");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CardId {
            get {
                return this.CardIdField;
            }
            set {
                if ((this.CardIdField.Equals(value) != true)) {
                    this.CardIdField = value;
                    this.RaisePropertyChanged("CardId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime From {
            get {
                return this.FromField;
            }
            set {
                if ((this.FromField.Equals(value) != true)) {
                    this.FromField = value;
                    this.RaisePropertyChanged("From");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HistoryId {
            get {
                return this.HistoryIdField;
            }
            set {
                if ((this.HistoryIdField.Equals(value) != true)) {
                    this.HistoryIdField = value;
                    this.RaisePropertyChanged("HistoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime To {
            get {
                return this.ToField;
            }
            set {
                if ((this.ToField.Equals(value) != true)) {
                    this.ToField = value;
                    this.RaisePropertyChanged("To");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceLogin.IServiceLogin")]
    public interface IServiceLogin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/Login", ReplyAction="http://tempuri.org/IServiceLogin/LoginResponse")]
        LibraryApp.ServiceLogin.User Login(string userName, string userPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/Login", ReplyAction="http://tempuri.org/IServiceLogin/LoginResponse")]
        System.Threading.Tasks.Task<LibraryApp.ServiceLogin.User> LoginAsync(string userName, string userPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/IsUserAdmin", ReplyAction="http://tempuri.org/IServiceLogin/IsUserAdminResponse")]
        bool IsUserAdmin(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/IsUserAdmin", ReplyAction="http://tempuri.org/IServiceLogin/IsUserAdminResponse")]
        System.Threading.Tasks.Task<bool> IsUserAdminAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/GetUserCards", ReplyAction="http://tempuri.org/IServiceLogin/GetUserCardsResponse")]
        LibraryApp.ServiceLogin.Card[] GetUserCards(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/GetUserCards", ReplyAction="http://tempuri.org/IServiceLogin/GetUserCardsResponse")]
        System.Threading.Tasks.Task<LibraryApp.ServiceLogin.Card[]> GetUserCardsAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/GetUserHistory", ReplyAction="http://tempuri.org/IServiceLogin/GetUserHistoryResponse")]
        LibraryApp.ServiceLogin.History[] GetUserHistory(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/GetUserHistory", ReplyAction="http://tempuri.org/IServiceLogin/GetUserHistoryResponse")]
        System.Threading.Tasks.Task<LibraryApp.ServiceLogin.History[]> GetUserHistoryAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/GetCardById", ReplyAction="http://tempuri.org/IServiceLogin/GetCardByIdResponse")]
        LibraryApp.ServiceLogin.Card GetCardById(int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/GetCardById", ReplyAction="http://tempuri.org/IServiceLogin/GetCardByIdResponse")]
        System.Threading.Tasks.Task<LibraryApp.ServiceLogin.Card> GetCardByIdAsync(int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/GetUsersNonAdmin", ReplyAction="http://tempuri.org/IServiceLogin/GetUsersNonAdminResponse")]
        LibraryApp.ServiceLogin.User[] GetUsersNonAdmin();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceLogin/GetUsersNonAdmin", ReplyAction="http://tempuri.org/IServiceLogin/GetUsersNonAdminResponse")]
        System.Threading.Tasks.Task<LibraryApp.ServiceLogin.User[]> GetUsersNonAdminAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceLoginChannel : LibraryApp.ServiceLogin.IServiceLogin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceLoginClient : System.ServiceModel.ClientBase<LibraryApp.ServiceLogin.IServiceLogin>, LibraryApp.ServiceLogin.IServiceLogin {
        
        public ServiceLoginClient() {
        }
        
        public ServiceLoginClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceLoginClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLoginClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceLoginClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LibraryApp.ServiceLogin.User Login(string userName, string userPassword) {
            return base.Channel.Login(userName, userPassword);
        }
        
        public System.Threading.Tasks.Task<LibraryApp.ServiceLogin.User> LoginAsync(string userName, string userPassword) {
            return base.Channel.LoginAsync(userName, userPassword);
        }
        
        public bool IsUserAdmin(int userId) {
            return base.Channel.IsUserAdmin(userId);
        }
        
        public System.Threading.Tasks.Task<bool> IsUserAdminAsync(int userId) {
            return base.Channel.IsUserAdminAsync(userId);
        }
        
        public LibraryApp.ServiceLogin.Card[] GetUserCards(int userId) {
            return base.Channel.GetUserCards(userId);
        }
        
        public System.Threading.Tasks.Task<LibraryApp.ServiceLogin.Card[]> GetUserCardsAsync(int userId) {
            return base.Channel.GetUserCardsAsync(userId);
        }
        
        public LibraryApp.ServiceLogin.History[] GetUserHistory(int userId) {
            return base.Channel.GetUserHistory(userId);
        }
        
        public System.Threading.Tasks.Task<LibraryApp.ServiceLogin.History[]> GetUserHistoryAsync(int userId) {
            return base.Channel.GetUserHistoryAsync(userId);
        }
        
        public LibraryApp.ServiceLogin.Card GetCardById(int cardId) {
            return base.Channel.GetCardById(cardId);
        }
        
        public System.Threading.Tasks.Task<LibraryApp.ServiceLogin.Card> GetCardByIdAsync(int cardId) {
            return base.Channel.GetCardByIdAsync(cardId);
        }
        
        public LibraryApp.ServiceLogin.User[] GetUsersNonAdmin() {
            return base.Channel.GetUsersNonAdmin();
        }
        
        public System.Threading.Tasks.Task<LibraryApp.ServiceLogin.User[]> GetUsersNonAdminAsync() {
            return base.Channel.GetUsersNonAdminAsync();
        }
    }
}
