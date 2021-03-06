﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment5Application.chrisService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="chrisService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCrimeData", ReplyAction="http://tempuri.org/IService1/getCrimeDataResponse")]
        int getCrimeData(double lon, double lat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getCrimeData", ReplyAction="http://tempuri.org/IService1/getCrimeDataResponse")]
        System.Threading.Tasks.Task<int> getCrimeDataAsync(double lon, double lat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/isPalindrome", ReplyAction="http://tempuri.org/IService1/isPalindromeResponse")]
        bool isPalindrome(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/isPalindrome", ReplyAction="http://tempuri.org/IService1/isPalindromeResponse")]
        System.Threading.Tasks.Task<bool> isPalindromeAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getStockData", ReplyAction="http://tempuri.org/IService1/getStockDataResponse")]
        string[] getStockData(string Ticker);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getStockData", ReplyAction="http://tempuri.org/IService1/getStockDataResponse")]
        System.Threading.Tasks.Task<string[]> getStockDataAsync(string Ticker);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getDefinition", ReplyAction="http://tempuri.org/IService1/getDefinitionResponse")]
        string getDefinition(string word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getDefinition", ReplyAction="http://tempuri.org/IService1/getDefinitionResponse")]
        System.Threading.Tasks.Task<string> getDefinitionAsync(string word);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Assignment5Application.chrisService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Assignment5Application.chrisService.IService1>, Assignment5Application.chrisService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int getCrimeData(double lon, double lat) {
            return base.Channel.getCrimeData(lon, lat);
        }
        
        public System.Threading.Tasks.Task<int> getCrimeDataAsync(double lon, double lat) {
            return base.Channel.getCrimeDataAsync(lon, lat);
        }
        
        public bool isPalindrome(string value) {
            return base.Channel.isPalindrome(value);
        }
        
        public System.Threading.Tasks.Task<bool> isPalindromeAsync(string value) {
            return base.Channel.isPalindromeAsync(value);
        }
        
        public string[] getStockData(string Ticker) {
            return base.Channel.getStockData(Ticker);
        }
        
        public System.Threading.Tasks.Task<string[]> getStockDataAsync(string Ticker) {
            return base.Channel.getStockDataAsync(Ticker);
        }
        
        public string getDefinition(string word) {
            return base.Channel.getDefinition(word);
        }
        
        public System.Threading.Tasks.Task<string> getDefinitionAsync(string word) {
            return base.Channel.getDefinitionAsync(word);
        }
    }
}
