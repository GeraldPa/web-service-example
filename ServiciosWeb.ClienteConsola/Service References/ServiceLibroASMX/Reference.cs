﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosWeb.ClienteConsola.ServiceLibroASMX {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Libro", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Libro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idLibroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SinopsisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AutorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EditorialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdiomaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FormatoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GeneroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DisponibleField;
        
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
        public int idLibro {
            get {
                return this.idLibroField;
            }
            set {
                if ((this.idLibroField.Equals(value) != true)) {
                    this.idLibroField = value;
                    this.RaisePropertyChanged("idLibro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Sinopsis {
            get {
                return this.SinopsisField;
            }
            set {
                if ((object.ReferenceEquals(this.SinopsisField, value) != true)) {
                    this.SinopsisField = value;
                    this.RaisePropertyChanged("Sinopsis");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Autor {
            get {
                return this.AutorField;
            }
            set {
                if ((object.ReferenceEquals(this.AutorField, value) != true)) {
                    this.AutorField = value;
                    this.RaisePropertyChanged("Autor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Editorial {
            get {
                return this.EditorialField;
            }
            set {
                if ((object.ReferenceEquals(this.EditorialField, value) != true)) {
                    this.EditorialField = value;
                    this.RaisePropertyChanged("Editorial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Idioma {
            get {
                return this.IdiomaField;
            }
            set {
                if ((object.ReferenceEquals(this.IdiomaField, value) != true)) {
                    this.IdiomaField = value;
                    this.RaisePropertyChanged("Idioma");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Formato {
            get {
                return this.FormatoField;
            }
            set {
                if ((object.ReferenceEquals(this.FormatoField, value) != true)) {
                    this.FormatoField = value;
                    this.RaisePropertyChanged("Formato");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Genero {
            get {
                return this.GeneroField;
            }
            set {
                if ((object.ReferenceEquals(this.GeneroField, value) != true)) {
                    this.GeneroField = value;
                    this.RaisePropertyChanged("Genero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Disponible {
            get {
                return this.DisponibleField;
            }
            set {
                if ((object.ReferenceEquals(this.DisponibleField, value) != true)) {
                    this.DisponibleField = value;
                    this.RaisePropertyChanged("Disponible");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceLibroASMX.ServicioLibroSoap")]
    public interface ServicioLibroSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ObtenerLibrosResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerLibros", ReplyAction="*")]
        ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosResponse ObtenerLibros(ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerLibros", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosResponse> ObtenerLibrosAsync(ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerLibrosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerLibros", Namespace="http://tempuri.org/", Order=0)]
        public ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequestBody Body;
        
        public ObtenerLibrosRequest() {
        }
        
        public ObtenerLibrosRequest(ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ObtenerLibrosRequestBody {
        
        public ObtenerLibrosRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerLibrosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerLibrosResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosResponseBody Body;
        
        public ObtenerLibrosResponse() {
        }
        
        public ObtenerLibrosResponse(ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerLibrosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiciosWeb.ClienteConsola.ServiceLibroASMX.Libro[] ObtenerLibrosResult;
        
        public ObtenerLibrosResponseBody() {
        }
        
        public ObtenerLibrosResponseBody(ServiciosWeb.ClienteConsola.ServiceLibroASMX.Libro[] ObtenerLibrosResult) {
            this.ObtenerLibrosResult = ObtenerLibrosResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicioLibroSoapChannel : ServiciosWeb.ClienteConsola.ServiceLibroASMX.ServicioLibroSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioLibroSoapClient : System.ServiceModel.ClientBase<ServiciosWeb.ClienteConsola.ServiceLibroASMX.ServicioLibroSoap>, ServiciosWeb.ClienteConsola.ServiceLibroASMX.ServicioLibroSoap {
        
        public ServicioLibroSoapClient() {
        }
        
        public ServicioLibroSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioLibroSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioLibroSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioLibroSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosResponse ServiciosWeb.ClienteConsola.ServiceLibroASMX.ServicioLibroSoap.ObtenerLibros(ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequest request) {
            return base.Channel.ObtenerLibros(request);
        }
        
        public ServiciosWeb.ClienteConsola.ServiceLibroASMX.Libro[] ObtenerLibros() {
            ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequest inValue = new ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequest();
            inValue.Body = new ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequestBody();
            ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosResponse retVal = ((ServiciosWeb.ClienteConsola.ServiceLibroASMX.ServicioLibroSoap)(this)).ObtenerLibros(inValue);
            return retVal.Body.ObtenerLibrosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosResponse> ServiciosWeb.ClienteConsola.ServiceLibroASMX.ServicioLibroSoap.ObtenerLibrosAsync(ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequest request) {
            return base.Channel.ObtenerLibrosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosResponse> ObtenerLibrosAsync() {
            ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequest inValue = new ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequest();
            inValue.Body = new ServiciosWeb.ClienteConsola.ServiceLibroASMX.ObtenerLibrosRequestBody();
            return ((ServiciosWeb.ClienteConsola.ServiceLibroASMX.ServicioLibroSoap)(this)).ObtenerLibrosAsync(inValue);
        }
    }
}
