﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace People_CRUD.PeopleServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="person", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class personServic : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        private System.Nullable<bool> IsMarriedField;
        
        private System.Nullable<People_CRUD.PeopleServiceReference2.Gender> GenderField;
        
        private System.Nullable<System.DateTime> BDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<bool> IsMarried {
            get {
                return this.IsMarriedField;
            }
            set {
                if ((this.IsMarriedField.Equals(value) != true)) {
                    this.IsMarriedField = value;
                    this.RaisePropertyChanged("IsMarried");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.Nullable<People_CRUD.PeopleServiceReference2.Gender> Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<System.DateTime> BDate {
            get {
                return this.BDateField;
            }
            set {
                if ((this.BDateField.Equals(value) != true)) {
                    this.BDateField = value;
                    this.RaisePropertyChanged("BDate");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Gender", Namespace="http://tempuri.org/")]
    public enum Gender : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Male = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Female = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PeopleServiceReference2.peopleSoap")]
    public interface peopleSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        People_CRUD.PeopleServiceReference2.HelloWorldResponse HelloWorld(People_CRUD.PeopleServiceReference2.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.HelloWorldResponse> HelloWorldAsync(People_CRUD.PeopleServiceReference2.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name person from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddPerson", ReplyAction="*")]
        People_CRUD.PeopleServiceReference2.AddPersonResponse AddPerson(People_CRUD.PeopleServiceReference2.AddPersonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddPerson", ReplyAction="*")]
        System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.AddPersonResponse> AddPersonAsync(People_CRUD.PeopleServiceReference2.AddPersonRequest request);
        
        // CODEGEN: Generating message contract since element name GetNamesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetNames", ReplyAction="*")]
        People_CRUD.PeopleServiceReference2.GetNamesResponse GetNames(People_CRUD.PeopleServiceReference2.GetNamesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetNames", ReplyAction="*")]
        System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.GetNamesResponse> GetNamesAsync(People_CRUD.PeopleServiceReference2.GetNamesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeletePerson", ReplyAction="*")]
        void DeletePerson(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeletePerson", ReplyAction="*")]
        System.Threading.Tasks.Task DeletePersonAsync(int Id);
        
        // CODEGEN: Generating message contract since element name person from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EditPerson", ReplyAction="*")]
        People_CRUD.PeopleServiceReference2.EditPersonResponse EditPerson(People_CRUD.PeopleServiceReference2.EditPersonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EditPerson", ReplyAction="*")]
        System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.EditPersonResponse> EditPersonAsync(People_CRUD.PeopleServiceReference2.EditPersonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public People_CRUD.PeopleServiceReference2.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(People_CRUD.PeopleServiceReference2.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public People_CRUD.PeopleServiceReference2.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(People_CRUD.PeopleServiceReference2.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddPersonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddPerson", Namespace="http://tempuri.org/", Order=0)]
        public People_CRUD.PeopleServiceReference2.AddPersonRequestBody Body;
        
        public AddPersonRequest() {
        }
        
        public AddPersonRequest(People_CRUD.PeopleServiceReference2.AddPersonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddPersonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public People_CRUD.PeopleServiceReference2.personServic person;
        
        public AddPersonRequestBody() {
        }
        
        public AddPersonRequestBody(People_CRUD.PeopleServiceReference2.personServic person) {
            this.person = person;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddPersonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddPersonResponse", Namespace="http://tempuri.org/", Order=0)]
        public People_CRUD.PeopleServiceReference2.AddPersonResponseBody Body;
        
        public AddPersonResponse() {
        }
        
        public AddPersonResponse(People_CRUD.PeopleServiceReference2.AddPersonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddPersonResponseBody {
        
        public AddPersonResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNamesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetNames", Namespace="http://tempuri.org/", Order=0)]
        public People_CRUD.PeopleServiceReference2.GetNamesRequestBody Body;
        
        public GetNamesRequest() {
        }
        
        public GetNamesRequest(People_CRUD.PeopleServiceReference2.GetNamesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetNamesRequestBody {
        
        public GetNamesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetNamesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetNamesResponse", Namespace="http://tempuri.org/", Order=0)]
        public People_CRUD.PeopleServiceReference2.GetNamesResponseBody Body;
        
        public GetNamesResponse() {
        }
        
        public GetNamesResponse(People_CRUD.PeopleServiceReference2.GetNamesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetNamesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public People_CRUD.PeopleServiceReference2.ArrayOfString GetNamesResult;
        
        public GetNamesResponseBody() {
        }
        
        public GetNamesResponseBody(People_CRUD.PeopleServiceReference2.ArrayOfString GetNamesResult) {
            this.GetNamesResult = GetNamesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EditPersonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EditPerson", Namespace="http://tempuri.org/", Order=0)]
        public People_CRUD.PeopleServiceReference2.EditPersonRequestBody Body;
        
        public EditPersonRequest() {
        }
        
        public EditPersonRequest(People_CRUD.PeopleServiceReference2.EditPersonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EditPersonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public People_CRUD.PeopleServiceReference2.personServic person;
        
        public EditPersonRequestBody() {
        }
        
        public EditPersonRequestBody(People_CRUD.PeopleServiceReference2.personServic person) {
            this.person = person;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EditPersonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EditPersonResponse", Namespace="http://tempuri.org/", Order=0)]
        public People_CRUD.PeopleServiceReference2.EditPersonResponseBody Body;
        
        public EditPersonResponse() {
        }
        
        public EditPersonResponse(People_CRUD.PeopleServiceReference2.EditPersonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class EditPersonResponseBody {
        
        public EditPersonResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface peopleSoapChannel : People_CRUD.PeopleServiceReference2.peopleSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class peopleSoapClient : System.ServiceModel.ClientBase<People_CRUD.PeopleServiceReference2.peopleSoap>, People_CRUD.PeopleServiceReference2.peopleSoap {
        
        public peopleSoapClient() {
        }
        
        public peopleSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public peopleSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public peopleSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public peopleSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        People_CRUD.PeopleServiceReference2.HelloWorldResponse People_CRUD.PeopleServiceReference2.peopleSoap.HelloWorld(People_CRUD.PeopleServiceReference2.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            People_CRUD.PeopleServiceReference2.HelloWorldRequest inValue = new People_CRUD.PeopleServiceReference2.HelloWorldRequest();
            inValue.Body = new People_CRUD.PeopleServiceReference2.HelloWorldRequestBody();
            People_CRUD.PeopleServiceReference2.HelloWorldResponse retVal = ((People_CRUD.PeopleServiceReference2.peopleSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.HelloWorldResponse> People_CRUD.PeopleServiceReference2.peopleSoap.HelloWorldAsync(People_CRUD.PeopleServiceReference2.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.HelloWorldResponse> HelloWorldAsync() {
            People_CRUD.PeopleServiceReference2.HelloWorldRequest inValue = new People_CRUD.PeopleServiceReference2.HelloWorldRequest();
            inValue.Body = new People_CRUD.PeopleServiceReference2.HelloWorldRequestBody();
            return ((People_CRUD.PeopleServiceReference2.peopleSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        People_CRUD.PeopleServiceReference2.AddPersonResponse People_CRUD.PeopleServiceReference2.peopleSoap.AddPerson(People_CRUD.PeopleServiceReference2.AddPersonRequest request) {
            return base.Channel.AddPerson(request);
        }
        
        public void AddPerson(People_CRUD.PeopleServiceReference2.personServic person) {
            People_CRUD.PeopleServiceReference2.AddPersonRequest inValue = new People_CRUD.PeopleServiceReference2.AddPersonRequest();
            inValue.Body = new People_CRUD.PeopleServiceReference2.AddPersonRequestBody();
            inValue.Body.person = person;
            People_CRUD.PeopleServiceReference2.AddPersonResponse retVal = ((People_CRUD.PeopleServiceReference2.peopleSoap)(this)).AddPerson(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.AddPersonResponse> People_CRUD.PeopleServiceReference2.peopleSoap.AddPersonAsync(People_CRUD.PeopleServiceReference2.AddPersonRequest request) {
            return base.Channel.AddPersonAsync(request);
        }
        
        public System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.AddPersonResponse> AddPersonAsync(People_CRUD.PeopleServiceReference2.personServic person) {
            People_CRUD.PeopleServiceReference2.AddPersonRequest inValue = new People_CRUD.PeopleServiceReference2.AddPersonRequest();
            inValue.Body = new People_CRUD.PeopleServiceReference2.AddPersonRequestBody();
            inValue.Body.person = person;
            return ((People_CRUD.PeopleServiceReference2.peopleSoap)(this)).AddPersonAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        People_CRUD.PeopleServiceReference2.GetNamesResponse People_CRUD.PeopleServiceReference2.peopleSoap.GetNames(People_CRUD.PeopleServiceReference2.GetNamesRequest request) {
            return base.Channel.GetNames(request);
        }
        
        public People_CRUD.PeopleServiceReference2.ArrayOfString GetNames() {
            People_CRUD.PeopleServiceReference2.GetNamesRequest inValue = new People_CRUD.PeopleServiceReference2.GetNamesRequest();
            inValue.Body = new People_CRUD.PeopleServiceReference2.GetNamesRequestBody();
            People_CRUD.PeopleServiceReference2.GetNamesResponse retVal = ((People_CRUD.PeopleServiceReference2.peopleSoap)(this)).GetNames(inValue);
            return retVal.Body.GetNamesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.GetNamesResponse> People_CRUD.PeopleServiceReference2.peopleSoap.GetNamesAsync(People_CRUD.PeopleServiceReference2.GetNamesRequest request) {
            return base.Channel.GetNamesAsync(request);
        }
        
        public System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.GetNamesResponse> GetNamesAsync() {
            People_CRUD.PeopleServiceReference2.GetNamesRequest inValue = new People_CRUD.PeopleServiceReference2.GetNamesRequest();
            inValue.Body = new People_CRUD.PeopleServiceReference2.GetNamesRequestBody();
            return ((People_CRUD.PeopleServiceReference2.peopleSoap)(this)).GetNamesAsync(inValue);
        }
        
        public void DeletePerson(int Id) {
            base.Channel.DeletePerson(Id);
        }
        
        public System.Threading.Tasks.Task DeletePersonAsync(int Id) {
            return base.Channel.DeletePersonAsync(Id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        People_CRUD.PeopleServiceReference2.EditPersonResponse People_CRUD.PeopleServiceReference2.peopleSoap.EditPerson(People_CRUD.PeopleServiceReference2.EditPersonRequest request) {
            return base.Channel.EditPerson(request);
        }
        
        public void EditPerson(People_CRUD.PeopleServiceReference2.personServic person) {
            People_CRUD.PeopleServiceReference2.EditPersonRequest inValue = new People_CRUD.PeopleServiceReference2.EditPersonRequest();
            inValue.Body = new People_CRUD.PeopleServiceReference2.EditPersonRequestBody();
            inValue.Body.person = person;
            People_CRUD.PeopleServiceReference2.EditPersonResponse retVal = ((People_CRUD.PeopleServiceReference2.peopleSoap)(this)).EditPerson(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.EditPersonResponse> People_CRUD.PeopleServiceReference2.peopleSoap.EditPersonAsync(People_CRUD.PeopleServiceReference2.EditPersonRequest request) {
            return base.Channel.EditPersonAsync(request);
        }
        
        public System.Threading.Tasks.Task<People_CRUD.PeopleServiceReference2.EditPersonResponse> EditPersonAsync(People_CRUD.PeopleServiceReference2.personServic person) {
            People_CRUD.PeopleServiceReference2.EditPersonRequest inValue = new People_CRUD.PeopleServiceReference2.EditPersonRequest();
            inValue.Body = new People_CRUD.PeopleServiceReference2.EditPersonRequestBody();
            inValue.Body.person = person;
            return ((People_CRUD.PeopleServiceReference2.peopleSoap)(this)).EditPersonAsync(inValue);
        }
    }
}