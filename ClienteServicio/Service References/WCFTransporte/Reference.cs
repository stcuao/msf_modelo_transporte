﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteServicio.WCFTransporte {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFTransporte.IWCFTransporte")]
    public interface IWCFTransporte {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFTransporte/modeloTransporte", ReplyAction="http://tempuri.org/IWCFTransporte/modeloTransporteResponse")]
        string modeloTransporte(string parametros);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWCFTransporte/modeloTransporte", ReplyAction="http://tempuri.org/IWCFTransporte/modeloTransporteResponse")]
        System.Threading.Tasks.Task<string> modeloTransporteAsync(string parametros);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWCFTransporteChannel : ClienteServicio.WCFTransporte.IWCFTransporte, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFTransporteClient : System.ServiceModel.ClientBase<ClienteServicio.WCFTransporte.IWCFTransporte>, ClienteServicio.WCFTransporte.IWCFTransporte {
        
        public WCFTransporteClient() {
        }
        
        public WCFTransporteClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFTransporteClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFTransporteClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFTransporteClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string modeloTransporte(string parametros) {
            return base.Channel.modeloTransporte(parametros);
        }
        
        public System.Threading.Tasks.Task<string> modeloTransporteAsync(string parametros) {
            return base.Channel.modeloTransporteAsync(parametros);
        }
    }
}
