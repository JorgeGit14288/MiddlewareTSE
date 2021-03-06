﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace MiddlewareTse.wsConsulta {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CaptchaServiceSoap", Namespace="http://tempuri.org/")]
    public partial class CaptchaService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ObtenerLugar1OperationCompleted;
        
        private System.Threading.SendOrPostCallback Transacciones1OperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CaptchaService() {
            this.Url = global::MiddlewareTse.Properties.Settings.Default.MiddlewareTse_wsConsulta_CaptchaService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ObtenerLugar1CompletedEventHandler ObtenerLugar1Completed;
        
        /// <remarks/>
        public event Transacciones1CompletedEventHandler Transacciones1Completed;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ObtenerLugar1", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RESPUESTA2 ObtenerLugar1(string nTransac, string Guid, string Id) {
            object[] results = this.Invoke("ObtenerLugar1", new object[] {
                        nTransac,
                        Guid,
                        Id});
            return ((RESPUESTA2)(results[0]));
        }
        
        /// <remarks/>
        public void ObtenerLugar1Async(string nTransac, string Guid, string Id) {
            this.ObtenerLugar1Async(nTransac, Guid, Id, null);
        }
        
        /// <remarks/>
        public void ObtenerLugar1Async(string nTransac, string Guid, string Id, object userState) {
            if ((this.ObtenerLugar1OperationCompleted == null)) {
                this.ObtenerLugar1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnObtenerLugar1OperationCompleted);
            }
            this.InvokeAsync("ObtenerLugar1", new object[] {
                        nTransac,
                        Guid,
                        Id}, this.ObtenerLugar1OperationCompleted, userState);
        }
        
        private void OnObtenerLugar1OperationCompleted(object arg) {
            if ((this.ObtenerLugar1Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ObtenerLugar1Completed(this, new ObtenerLugar1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Transacciones1", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public RESULTADO Transacciones1(string codSys, string cui, string fechaNacimiento) {
            object[] results = this.Invoke("Transacciones1", new object[] {
                        codSys,
                        cui,
                        fechaNacimiento});
            return ((RESULTADO)(results[0]));
        }
        
        /// <remarks/>
        public void Transacciones1Async(string codSys, string cui, string fechaNacimiento) {
            this.Transacciones1Async(codSys, cui, fechaNacimiento, null);
        }
        
        /// <remarks/>
        public void Transacciones1Async(string codSys, string cui, string fechaNacimiento, object userState) {
            if ((this.Transacciones1OperationCompleted == null)) {
                this.Transacciones1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnTransacciones1OperationCompleted);
            }
            this.InvokeAsync("Transacciones1", new object[] {
                        codSys,
                        cui,
                        fechaNacimiento}, this.Transacciones1OperationCompleted, userState);
        }
        
        private void OnTransacciones1OperationCompleted(object arg) {
            if ((this.Transacciones1Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Transacciones1Completed(this, new Transacciones1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RESPUESTA2 {
        
        private string sTATUSField;
        
        private string cODIGOField;
        
        private string uSRMENSAJEField;
        
        private string dETMENSAJEField;
        
        private string bOLETAField;
        
        private string dPIField;
        
        private string nOMBRES_APELLIDOSField;
        
        private string fECHA_DE_NACIMIENTOField;
        
        private string mESA_DE_NUMEROField;
        
        private string pAGINAField;
        
        private string lINEAField;
        
        private string cENTROField;
        
        private string dIRECCIONField;
        
        private string dEPARTAMENTOField;
        
        private string mUNICIPIOField;
        
        /// <remarks/>
        public string STATUS {
            get {
                return this.sTATUSField;
            }
            set {
                this.sTATUSField = value;
            }
        }
        
        /// <remarks/>
        public string CODIGO {
            get {
                return this.cODIGOField;
            }
            set {
                this.cODIGOField = value;
            }
        }
        
        /// <remarks/>
        public string USRMENSAJE {
            get {
                return this.uSRMENSAJEField;
            }
            set {
                this.uSRMENSAJEField = value;
            }
        }
        
        /// <remarks/>
        public string DETMENSAJE {
            get {
                return this.dETMENSAJEField;
            }
            set {
                this.dETMENSAJEField = value;
            }
        }
        
        /// <remarks/>
        public string BOLETA {
            get {
                return this.bOLETAField;
            }
            set {
                this.bOLETAField = value;
            }
        }
        
        /// <remarks/>
        public string DPI {
            get {
                return this.dPIField;
            }
            set {
                this.dPIField = value;
            }
        }
        
        /// <remarks/>
        public string NOMBRES_APELLIDOS {
            get {
                return this.nOMBRES_APELLIDOSField;
            }
            set {
                this.nOMBRES_APELLIDOSField = value;
            }
        }
        
        /// <remarks/>
        public string FECHA_DE_NACIMIENTO {
            get {
                return this.fECHA_DE_NACIMIENTOField;
            }
            set {
                this.fECHA_DE_NACIMIENTOField = value;
            }
        }
        
        /// <remarks/>
        public string MESA_DE_NUMERO {
            get {
                return this.mESA_DE_NUMEROField;
            }
            set {
                this.mESA_DE_NUMEROField = value;
            }
        }
        
        /// <remarks/>
        public string PAGINA {
            get {
                return this.pAGINAField;
            }
            set {
                this.pAGINAField = value;
            }
        }
        
        /// <remarks/>
        public string LINEA {
            get {
                return this.lINEAField;
            }
            set {
                this.lINEAField = value;
            }
        }
        
        /// <remarks/>
        public string CENTRO {
            get {
                return this.cENTROField;
            }
            set {
                this.cENTROField = value;
            }
        }
        
        /// <remarks/>
        public string DIRECCION {
            get {
                return this.dIRECCIONField;
            }
            set {
                this.dIRECCIONField = value;
            }
        }
        
        /// <remarks/>
        public string DEPARTAMENTO {
            get {
                return this.dEPARTAMENTOField;
            }
            set {
                this.dEPARTAMENTOField = value;
            }
        }
        
        /// <remarks/>
        public string MUNICIPIO {
            get {
                return this.mUNICIPIOField;
            }
            set {
                this.mUNICIPIOField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RESULTADO {
        
        private string nTRANSField;
        
        private string iMAField;
        
        private string sTATUSField;
        
        private string cODIGOField;
        
        private string uSRMENSAJEField;
        
        private string dETMENSAJEField;
        
        /// <remarks/>
        public string NTRANS {
            get {
                return this.nTRANSField;
            }
            set {
                this.nTRANSField = value;
            }
        }
        
        /// <remarks/>
        public string IMA {
            get {
                return this.iMAField;
            }
            set {
                this.iMAField = value;
            }
        }
        
        /// <remarks/>
        public string STATUS {
            get {
                return this.sTATUSField;
            }
            set {
                this.sTATUSField = value;
            }
        }
        
        /// <remarks/>
        public string CODIGO {
            get {
                return this.cODIGOField;
            }
            set {
                this.cODIGOField = value;
            }
        }
        
        /// <remarks/>
        public string USRMENSAJE {
            get {
                return this.uSRMENSAJEField;
            }
            set {
                this.uSRMENSAJEField = value;
            }
        }
        
        /// <remarks/>
        public string DETMENSAJE {
            get {
                return this.dETMENSAJEField;
            }
            set {
                this.dETMENSAJEField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void ObtenerLugar1CompletedEventHandler(object sender, ObtenerLugar1CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObtenerLugar1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ObtenerLugar1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RESPUESTA2 Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RESPUESTA2)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    public delegate void Transacciones1CompletedEventHandler(object sender, Transacciones1CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Transacciones1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Transacciones1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public RESULTADO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((RESULTADO)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591