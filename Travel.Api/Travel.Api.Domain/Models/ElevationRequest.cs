namespace Travel.Api.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class ElevationRequest : BaseRequest, IElevationRequest
    {
        [DataMember]
        public Location Location { get; set; }
    }
}