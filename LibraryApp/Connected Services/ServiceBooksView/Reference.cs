﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryApp.ServiceBooksView {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsableBook", Namespace="http://schemas.datacontract.org/2004/07/DataBase.Db.DbBooks")]
    [System.SerializableAttribute()]
    public partial class UsableBook : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BookFormatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BookIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] CharactersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CoverImgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] GenresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LanguageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumOfRatingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PagesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PublisherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float RatingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SeriesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] SettingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
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
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BookFormat {
            get {
                return this.BookFormatField;
            }
            set {
                if ((object.ReferenceEquals(this.BookFormatField, value) != true)) {
                    this.BookFormatField = value;
                    this.RaisePropertyChanged("BookFormat");
                }
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
        public string[] Characters {
            get {
                return this.CharactersField;
            }
            set {
                if ((object.ReferenceEquals(this.CharactersField, value) != true)) {
                    this.CharactersField = value;
                    this.RaisePropertyChanged("Characters");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CoverImg {
            get {
                return this.CoverImgField;
            }
            set {
                if ((object.ReferenceEquals(this.CoverImgField, value) != true)) {
                    this.CoverImgField = value;
                    this.RaisePropertyChanged("CoverImg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Genres {
            get {
                return this.GenresField;
            }
            set {
                if ((object.ReferenceEquals(this.GenresField, value) != true)) {
                    this.GenresField = value;
                    this.RaisePropertyChanged("Genres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Language {
            get {
                return this.LanguageField;
            }
            set {
                if ((object.ReferenceEquals(this.LanguageField, value) != true)) {
                    this.LanguageField = value;
                    this.RaisePropertyChanged("Language");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumOfRatings {
            get {
                return this.NumOfRatingsField;
            }
            set {
                if ((this.NumOfRatingsField.Equals(value) != true)) {
                    this.NumOfRatingsField = value;
                    this.RaisePropertyChanged("NumOfRatings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pages {
            get {
                return this.PagesField;
            }
            set {
                if ((this.PagesField.Equals(value) != true)) {
                    this.PagesField = value;
                    this.RaisePropertyChanged("Pages");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Publisher {
            get {
                return this.PublisherField;
            }
            set {
                if ((object.ReferenceEquals(this.PublisherField, value) != true)) {
                    this.PublisherField = value;
                    this.RaisePropertyChanged("Publisher");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Rating {
            get {
                return this.RatingField;
            }
            set {
                if ((this.RatingField.Equals(value) != true)) {
                    this.RatingField = value;
                    this.RaisePropertyChanged("Rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Series {
            get {
                return this.SeriesField;
            }
            set {
                if ((object.ReferenceEquals(this.SeriesField, value) != true)) {
                    this.SeriesField = value;
                    this.RaisePropertyChanged("Series");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] Setting {
            get {
                return this.SettingField;
            }
            set {
                if ((object.ReferenceEquals(this.SettingField, value) != true)) {
                    this.SettingField = value;
                    this.RaisePropertyChanged("Setting");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceBooksView.IServiceBooksView")]
    public interface IServiceBooksView {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooksView/GetBooksFiltered", ReplyAction="http://tempuri.org/IServiceBooksView/GetBooksFilteredResponse")]
        LibraryApp.ServiceBooksView.UsableBook[] GetBooksFiltered(string titleAuthor, int maxPrice, int minPrice, int maxPages, int minPages, string[] genres, string language);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooksView/GetBooksFiltered", ReplyAction="http://tempuri.org/IServiceBooksView/GetBooksFilteredResponse")]
        System.Threading.Tasks.Task<LibraryApp.ServiceBooksView.UsableBook[]> GetBooksFilteredAsync(string titleAuthor, int maxPrice, int minPrice, int maxPages, int minPages, string[] genres, string language);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooksView/GetLanguages", ReplyAction="http://tempuri.org/IServiceBooksView/GetLanguagesResponse")]
        string[] GetLanguages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooksView/GetLanguages", ReplyAction="http://tempuri.org/IServiceBooksView/GetLanguagesResponse")]
        System.Threading.Tasks.Task<string[]> GetLanguagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooksView/GetGenresByFirstLetter", ReplyAction="http://tempuri.org/IServiceBooksView/GetGenresByFirstLetterResponse")]
        string[] GetGenresByFirstLetter(string firstLetter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooksView/GetGenresByFirstLetter", ReplyAction="http://tempuri.org/IServiceBooksView/GetGenresByFirstLetterResponse")]
        System.Threading.Tasks.Task<string[]> GetGenresByFirstLetterAsync(string firstLetter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooksView/GetGenres", ReplyAction="http://tempuri.org/IServiceBooksView/GetGenresResponse")]
        string[] GetGenres();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooksView/GetGenres", ReplyAction="http://tempuri.org/IServiceBooksView/GetGenresResponse")]
        System.Threading.Tasks.Task<string[]> GetGenresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooksView/GetUsableBookById", ReplyAction="http://tempuri.org/IServiceBooksView/GetUsableBookByIdResponse")]
        LibraryApp.ServiceBooksView.UsableBook GetUsableBookById(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBooksView/GetUsableBookById", ReplyAction="http://tempuri.org/IServiceBooksView/GetUsableBookByIdResponse")]
        System.Threading.Tasks.Task<LibraryApp.ServiceBooksView.UsableBook> GetUsableBookByIdAsync(int bookId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBooksViewChannel : LibraryApp.ServiceBooksView.IServiceBooksView, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBooksViewClient : System.ServiceModel.ClientBase<LibraryApp.ServiceBooksView.IServiceBooksView>, LibraryApp.ServiceBooksView.IServiceBooksView {
        
        public ServiceBooksViewClient() {
        }
        
        public ServiceBooksViewClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceBooksViewClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBooksViewClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBooksViewClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LibraryApp.ServiceBooksView.UsableBook[] GetBooksFiltered(string titleAuthor, int maxPrice, int minPrice, int maxPages, int minPages, string[] genres, string language) {
            return base.Channel.GetBooksFiltered(titleAuthor, maxPrice, minPrice, maxPages, minPages, genres, language);
        }
        
        public System.Threading.Tasks.Task<LibraryApp.ServiceBooksView.UsableBook[]> GetBooksFilteredAsync(string titleAuthor, int maxPrice, int minPrice, int maxPages, int minPages, string[] genres, string language) {
            return base.Channel.GetBooksFilteredAsync(titleAuthor, maxPrice, minPrice, maxPages, minPages, genres, language);
        }
        
        public string[] GetLanguages() {
            return base.Channel.GetLanguages();
        }
        
        public System.Threading.Tasks.Task<string[]> GetLanguagesAsync() {
            return base.Channel.GetLanguagesAsync();
        }
        
        public string[] GetGenresByFirstLetter(string firstLetter) {
            return base.Channel.GetGenresByFirstLetter(firstLetter);
        }
        
        public System.Threading.Tasks.Task<string[]> GetGenresByFirstLetterAsync(string firstLetter) {
            return base.Channel.GetGenresByFirstLetterAsync(firstLetter);
        }
        
        public string[] GetGenres() {
            return base.Channel.GetGenres();
        }
        
        public System.Threading.Tasks.Task<string[]> GetGenresAsync() {
            return base.Channel.GetGenresAsync();
        }
        
        public LibraryApp.ServiceBooksView.UsableBook GetUsableBookById(int bookId) {
            return base.Channel.GetUsableBookById(bookId);
        }
        
        public System.Threading.Tasks.Task<LibraryApp.ServiceBooksView.UsableBook> GetUsableBookByIdAsync(int bookId) {
            return base.Channel.GetUsableBookByIdAsync(bookId);
        }
    }
}
