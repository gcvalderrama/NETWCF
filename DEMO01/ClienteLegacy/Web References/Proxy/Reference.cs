﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace ClienteLegacy.Proxy {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ILog", Namespace="http://tempuri.org/")]
    public partial class Logger : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback LogMessageOperationCompleted;
        
        private System.Threading.SendOrPostCallback LogMessageObjectOperationCompleted;
        
        private @string auditField;
        
        private System.Threading.SendOrPostCallback TraceOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Logger() {
            this.Url = global::ClienteLegacy.Properties.Settings.Default.ClienteLegacy_Proxy_Logger;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public @string Audit {
            get {
                return this.auditField;
            }
            set {
                this.auditField = value;
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
        public event LogMessageCompletedEventHandler LogMessageCompleted;
        
        /// <remarks/>
        public event LogMessageObjectCompletedEventHandler LogMessageObjectCompleted;
        
        /// <remarks/>
        public event TraceCompletedEventHandler TraceCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILog/LogMessage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LogMessage([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string message) {
            this.Invoke("LogMessage", new object[] {
                        message});
        }
        
        /// <remarks/>
        public void LogMessageAsync(string message) {
            this.LogMessageAsync(message, null);
        }
        
        /// <remarks/>
        public void LogMessageAsync(string message, object userState) {
            if ((this.LogMessageOperationCompleted == null)) {
                this.LogMessageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLogMessageOperationCompleted);
            }
            this.InvokeAsync("LogMessage", new object[] {
                        message}, this.LogMessageOperationCompleted, userState);
        }
        
        private void OnLogMessageOperationCompleted(object arg) {
            if ((this.LogMessageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LogMessageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILog/LogMessageObject", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void LogMessageObject([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] LogMessage message) {
            this.Invoke("LogMessageObject", new object[] {
                        message});
        }
        
        /// <remarks/>
        public void LogMessageObjectAsync(LogMessage message) {
            this.LogMessageObjectAsync(message, null);
        }
        
        /// <remarks/>
        public void LogMessageObjectAsync(LogMessage message, object userState) {
            if ((this.LogMessageObjectOperationCompleted == null)) {
                this.LogMessageObjectOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLogMessageObjectOperationCompleted);
            }
            this.InvokeAsync("LogMessageObject", new object[] {
                        message}, this.LogMessageObjectOperationCompleted, userState);
        }
        
        private void OnLogMessageObjectOperationCompleted(object arg) {
            if ((this.LogMessageObjectCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LogMessageObjectCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("Audit")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILog/Trace", RequestElementName="TraceRequest", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Trace([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string Message, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string UIMessage) {
            this.Invoke("Trace", new object[] {
                        Message,
                        UIMessage});
        }
        
        /// <remarks/>
        public void TraceAsync(string Message, string UIMessage) {
            this.TraceAsync(Message, UIMessage, null);
        }
        
        /// <remarks/>
        public void TraceAsync(string Message, string UIMessage, object userState) {
            if ((this.TraceOperationCompleted == null)) {
                this.TraceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTraceOperationCompleted);
            }
            this.InvokeAsync("Trace", new object[] {
                        Message,
                        UIMessage}, this.TraceOperationCompleted, userState);
        }
        
        private void OnTraceOperationCompleted(object arg) {
            if ((this.TraceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TraceCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2001/XMLSchema")]
    [System.Xml.Serialization.XmlRootAttribute("Audit", Namespace="http://tempuri.org/", IsNullable=true)]
    public partial class @string : System.Web.Services.Protocols.SoapHeader {
        
        private string[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/Compartir")]
    public partial class LogMessage {
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        private string textField;
        
        /// <remarks/>
        public System.DateTime date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateSpecified {
            get {
                return this.dateFieldSpecified;
            }
            set {
                this.dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LogMessageCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void LogMessageObjectCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void TraceCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591