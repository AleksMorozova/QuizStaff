﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IApplicationServer")]
    public interface IApplicationServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetData", ReplyAction="http://tempuri.org/IApplicationServer/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetData", ReplyAction="http://tempuri.org/IApplicationServer/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllTestees", ReplyAction="http://tempuri.org/IApplicationServer/GetAllTesteesResponse")]
        DomainModel.Testee[] GetAllTestees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetAllTestees", ReplyAction="http://tempuri.org/IApplicationServer/GetAllTesteesResponse")]
        System.Threading.Tasks.Task<DomainModel.Testee[]> GetAllTesteesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveAllTestees", ReplyAction="http://tempuri.org/IApplicationServer/SaveAllTesteesResponse")]
        void SaveAllTestees(DomainModel.Testee[] testees);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/SaveAllTestees", ReplyAction="http://tempuri.org/IApplicationServer/SaveAllTesteesResponse")]
        System.Threading.Tasks.Task SaveAllTesteesAsync(DomainModel.Testee[] testees);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetTestee", ReplyAction="http://tempuri.org/IApplicationServer/GetTesteeResponse")]
        DomainModel.Testee GetTestee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IApplicationServer/GetTestee", ReplyAction="http://tempuri.org/IApplicationServer/GetTesteeResponse")]
        System.Threading.Tasks.Task<DomainModel.Testee> GetTesteeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IApplicationServerChannel : Client.ServiceReference.IApplicationServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ApplicationServerClient : System.ServiceModel.ClientBase<Client.ServiceReference.IApplicationServer>, Client.ServiceReference.IApplicationServer {
        
        public ApplicationServerClient() {
        }
        
        public ApplicationServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ApplicationServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ApplicationServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public DomainModel.Testee[] GetAllTestees() {
            return base.Channel.GetAllTestees();
        }
        
        public System.Threading.Tasks.Task<DomainModel.Testee[]> GetAllTesteesAsync() {
            return base.Channel.GetAllTesteesAsync();
        }
        
        public void SaveAllTestees(DomainModel.Testee[] testees) {
            base.Channel.SaveAllTestees(testees);
        }
        
        public System.Threading.Tasks.Task SaveAllTesteesAsync(DomainModel.Testee[] testees) {
            return base.Channel.SaveAllTesteesAsync(testees);
        }
        
        public DomainModel.Testee GetTestee() {
            return base.Channel.GetTestee();
        }
        
        public System.Threading.Tasks.Task<DomainModel.Testee> GetTesteeAsync() {
            return base.Channel.GetTesteeAsync();
        }
    }
}
