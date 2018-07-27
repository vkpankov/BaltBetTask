﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaltBetSimpleServer.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/BaltBetService.Models")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ulong PassportField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BaltBetSimpleServer.ServiceReference.Sex SexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ulong Passport {
            get {
                return this.PassportField;
            }
            set {
                if ((this.PassportField.Equals(value) != true)) {
                    this.PassportField = value;
                    this.RaisePropertyChanged("Passport");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BaltBetSimpleServer.ServiceReference.Sex Sex {
            get {
                return this.SexField;
            }
            set {
                if ((this.SexField.Equals(value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sex", Namespace="http://schemas.datacontract.org/2004/07/BaltBetService.Models")]
    public enum Sex : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Male = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Female = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUsers", ReplyAction="http://tempuri.org/IUserService/GetUsersResponse")]
        BaltBetSimpleServer.ServiceReference.User[] GetUsers(int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUsers", ReplyAction="http://tempuri.org/IUserService/GetUsersResponse")]
        System.Threading.Tasks.Task<BaltBetSimpleServer.ServiceReference.User[]> GetUsersAsync(int pageNumber, int pageSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Create", ReplyAction="http://tempuri.org/IUserService/CreateResponse")]
        void Create(BaltBetSimpleServer.ServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Create", ReplyAction="http://tempuri.org/IUserService/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(BaltBetSimpleServer.ServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Delete", ReplyAction="http://tempuri.org/IUserService/DeleteResponse")]
        void Delete(BaltBetSimpleServer.ServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Delete", ReplyAction="http://tempuri.org/IUserService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(BaltBetSimpleServer.ServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindByName", ReplyAction="http://tempuri.org/IUserService/FindByNameResponse")]
        BaltBetSimpleServer.ServiceReference.User FindByName(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindByName", ReplyAction="http://tempuri.org/IUserService/FindByNameResponse")]
        System.Threading.Tasks.Task<BaltBetSimpleServer.ServiceReference.User> FindByNameAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindByUserId", ReplyAction="http://tempuri.org/IUserService/FindByUserIdResponse")]
        BaltBetSimpleServer.ServiceReference.User FindByUserId(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/FindByUserId", ReplyAction="http://tempuri.org/IUserService/FindByUserIdResponse")]
        System.Threading.Tasks.Task<BaltBetSimpleServer.ServiceReference.User> FindByUserIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Update", ReplyAction="http://tempuri.org/IUserService/UpdateResponse")]
        void Update(BaltBetSimpleServer.ServiceReference.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Update", ReplyAction="http://tempuri.org/IUserService/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(BaltBetSimpleServer.ServiceReference.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : BaltBetSimpleServer.ServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<BaltBetSimpleServer.ServiceReference.IUserService>, BaltBetSimpleServer.ServiceReference.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BaltBetSimpleServer.ServiceReference.User[] GetUsers(int pageNumber, int pageSize) {
            return base.Channel.GetUsers(pageNumber, pageSize);
        }
        
        public System.Threading.Tasks.Task<BaltBetSimpleServer.ServiceReference.User[]> GetUsersAsync(int pageNumber, int pageSize) {
            return base.Channel.GetUsersAsync(pageNumber, pageSize);
        }
        
        public void Create(BaltBetSimpleServer.ServiceReference.User user) {
            base.Channel.Create(user);
        }
        
        public System.Threading.Tasks.Task CreateAsync(BaltBetSimpleServer.ServiceReference.User user) {
            return base.Channel.CreateAsync(user);
        }
        
        public void Delete(BaltBetSimpleServer.ServiceReference.User user) {
            base.Channel.Delete(user);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(BaltBetSimpleServer.ServiceReference.User user) {
            return base.Channel.DeleteAsync(user);
        }
        
        public BaltBetSimpleServer.ServiceReference.User FindByName(string userName) {
            return base.Channel.FindByName(userName);
        }
        
        public System.Threading.Tasks.Task<BaltBetSimpleServer.ServiceReference.User> FindByNameAsync(string userName) {
            return base.Channel.FindByNameAsync(userName);
        }
        
        public BaltBetSimpleServer.ServiceReference.User FindByUserId(int id) {
            return base.Channel.FindByUserId(id);
        }
        
        public System.Threading.Tasks.Task<BaltBetSimpleServer.ServiceReference.User> FindByUserIdAsync(int id) {
            return base.Channel.FindByUserIdAsync(id);
        }
        
        public void Update(BaltBetSimpleServer.ServiceReference.User user) {
            base.Channel.Update(user);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(BaltBetSimpleServer.ServiceReference.User user) {
            return base.Channel.UpdateAsync(user);
        }
    }
}
