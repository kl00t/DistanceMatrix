﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DistanceMatrix.ConsoleApplication.DistanceMatrixService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DistanceMatrixService.IDistanceMatrixService")]
    public interface IDistanceMatrixService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceMatrixService/Heartbeat", ReplyAction="http://tempuri.org/IDistanceMatrixService/HeartbeatResponse")]
        DistanceMatrix.Core.Framework.ServiceResponse<System.DateTime> Heartbeat();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceMatrixService/Heartbeat", ReplyAction="http://tempuri.org/IDistanceMatrixService/HeartbeatResponse")]
        System.Threading.Tasks.Task<DistanceMatrix.Core.Framework.ServiceResponse<System.DateTime>> HeartbeatAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceMatrixService/DistanceMatrix", ReplyAction="http://tempuri.org/IDistanceMatrixService/DistanceMatrixResponse")]
        DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.DistanceMatrixResponse> DistanceMatrix(DistanceMatrix.Domain.Models.DistanceMatrixRequest distanceMatrixRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceMatrixService/DistanceMatrix", ReplyAction="http://tempuri.org/IDistanceMatrixService/DistanceMatrixResponse")]
        System.Threading.Tasks.Task<DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.DistanceMatrixResponse>> DistanceMatrixAsync(DistanceMatrix.Domain.Models.DistanceMatrixRequest distanceMatrixRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceMatrixService/GetDistanceMatrixRequestHistory", ReplyAction="http://tempuri.org/IDistanceMatrixService/GetDistanceMatrixRequestHistoryResponse" +
            "")]
        DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.RequestHistory[]> GetDistanceMatrixRequestHistory();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceMatrixService/GetDistanceMatrixRequestHistory", ReplyAction="http://tempuri.org/IDistanceMatrixService/GetDistanceMatrixRequestHistoryResponse" +
            "")]
        System.Threading.Tasks.Task<DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.RequestHistory[]>> GetDistanceMatrixRequestHistoryAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceMatrixService/GetRequestHistory", ReplyAction="http://tempuri.org/IDistanceMatrixService/GetRequestHistoryResponse")]
        DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.RequestHistory> GetRequestHistory(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceMatrixService/GetRequestHistory", ReplyAction="http://tempuri.org/IDistanceMatrixService/GetRequestHistoryResponse")]
        System.Threading.Tasks.Task<DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.RequestHistory>> GetRequestHistoryAsync(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceMatrixService/ReplayRequest", ReplyAction="http://tempuri.org/IDistanceMatrixService/ReplayRequestResponse")]
        DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.DistanceMatrixResponse> ReplayRequest(System.Guid requestId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDistanceMatrixService/ReplayRequest", ReplyAction="http://tempuri.org/IDistanceMatrixService/ReplayRequestResponse")]
        System.Threading.Tasks.Task<DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.DistanceMatrixResponse>> ReplayRequestAsync(System.Guid requestId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDistanceMatrixServiceChannel : DistanceMatrix.ConsoleApplication.DistanceMatrixService.IDistanceMatrixService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DistanceMatrixServiceClient : System.ServiceModel.ClientBase<DistanceMatrix.ConsoleApplication.DistanceMatrixService.IDistanceMatrixService>, DistanceMatrix.ConsoleApplication.DistanceMatrixService.IDistanceMatrixService {
        
        public DistanceMatrixServiceClient() {
        }
        
        public DistanceMatrixServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DistanceMatrixServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DistanceMatrixServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DistanceMatrixServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DistanceMatrix.Core.Framework.ServiceResponse<System.DateTime> Heartbeat() {
            return base.Channel.Heartbeat();
        }
        
        public System.Threading.Tasks.Task<DistanceMatrix.Core.Framework.ServiceResponse<System.DateTime>> HeartbeatAsync() {
            return base.Channel.HeartbeatAsync();
        }
        
        public DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.DistanceMatrixResponse> DistanceMatrix(DistanceMatrix.Domain.Models.DistanceMatrixRequest distanceMatrixRequest) {
            return base.Channel.DistanceMatrix(distanceMatrixRequest);
        }
        
        public System.Threading.Tasks.Task<DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.DistanceMatrixResponse>> DistanceMatrixAsync(DistanceMatrix.Domain.Models.DistanceMatrixRequest distanceMatrixRequest) {
            return base.Channel.DistanceMatrixAsync(distanceMatrixRequest);
        }
        
        public DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.RequestHistory[]> GetDistanceMatrixRequestHistory() {
            return base.Channel.GetDistanceMatrixRequestHistory();
        }
        
        public System.Threading.Tasks.Task<DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.RequestHistory[]>> GetDistanceMatrixRequestHistoryAsync() {
            return base.Channel.GetDistanceMatrixRequestHistoryAsync();
        }
        
        public DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.RequestHistory> GetRequestHistory(System.Guid requestId) {
            return base.Channel.GetRequestHistory(requestId);
        }
        
        public System.Threading.Tasks.Task<DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.RequestHistory>> GetRequestHistoryAsync(System.Guid requestId) {
            return base.Channel.GetRequestHistoryAsync(requestId);
        }
        
        public DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.DistanceMatrixResponse> ReplayRequest(System.Guid requestId) {
            return base.Channel.ReplayRequest(requestId);
        }
        
        public System.Threading.Tasks.Task<DistanceMatrix.Core.Framework.ServiceResponse<DistanceMatrix.Domain.Models.DistanceMatrixResponse>> ReplayRequestAsync(System.Guid requestId) {
            return base.Channel.ReplayRequestAsync(requestId);
        }
    }
}
