﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineShoping.MessageCenter {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MessageCenter.WebServiceSoap")]
    public interface WebServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubcribePage", ReplyAction="*")]
        void SubcribePage(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubcribePage", ReplyAction="*")]
        System.Threading.Tasks.Task SubcribePageAsync(int id);
        
        // CODEGEN: Generating message contract since element name message from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Notify", ReplyAction="*")]
        OnlineShoping.MessageCenter.NotifyResponse Notify(OnlineShoping.MessageCenter.NotifyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Notify", ReplyAction="*")]
        System.Threading.Tasks.Task<OnlineShoping.MessageCenter.NotifyResponse> NotifyAsync(OnlineShoping.MessageCenter.NotifyRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NotifyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Notify", Namespace="http://tempuri.org/", Order=0)]
        public OnlineShoping.MessageCenter.NotifyRequestBody Body;
        
        public NotifyRequest() {
        }
        
        public NotifyRequest(OnlineShoping.MessageCenter.NotifyRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class NotifyRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string message;
        
        public NotifyRequestBody() {
        }
        
        public NotifyRequestBody(string message) {
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class NotifyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="NotifyResponse", Namespace="http://tempuri.org/", Order=0)]
        public OnlineShoping.MessageCenter.NotifyResponseBody Body;
        
        public NotifyResponse() {
        }
        
        public NotifyResponse(OnlineShoping.MessageCenter.NotifyResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class NotifyResponseBody {
        
        public NotifyResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : OnlineShoping.MessageCenter.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<OnlineShoping.MessageCenter.WebServiceSoap>, OnlineShoping.MessageCenter.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SubcribePage(int id) {
            base.Channel.SubcribePage(id);
        }
        
        public System.Threading.Tasks.Task SubcribePageAsync(int id) {
            return base.Channel.SubcribePageAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        OnlineShoping.MessageCenter.NotifyResponse OnlineShoping.MessageCenter.WebServiceSoap.Notify(OnlineShoping.MessageCenter.NotifyRequest request) {
            return base.Channel.Notify(request);
        }
        
        public void Notify(string message) {
            OnlineShoping.MessageCenter.NotifyRequest inValue = new OnlineShoping.MessageCenter.NotifyRequest();
            inValue.Body = new OnlineShoping.MessageCenter.NotifyRequestBody();
            inValue.Body.message = message;
            OnlineShoping.MessageCenter.NotifyResponse retVal = ((OnlineShoping.MessageCenter.WebServiceSoap)(this)).Notify(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<OnlineShoping.MessageCenter.NotifyResponse> OnlineShoping.MessageCenter.WebServiceSoap.NotifyAsync(OnlineShoping.MessageCenter.NotifyRequest request) {
            return base.Channel.NotifyAsync(request);
        }
        
        public System.Threading.Tasks.Task<OnlineShoping.MessageCenter.NotifyResponse> NotifyAsync(string message) {
            OnlineShoping.MessageCenter.NotifyRequest inValue = new OnlineShoping.MessageCenter.NotifyRequest();
            inValue.Body = new OnlineShoping.MessageCenter.NotifyRequestBody();
            inValue.Body.message = message;
            return ((OnlineShoping.MessageCenter.WebServiceSoap)(this)).NotifyAsync(inValue);
        }
    }
}
