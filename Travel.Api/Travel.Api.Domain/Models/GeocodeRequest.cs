namespace Travel.Api.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class GeocodeRequest : BaseRequest, IGeocodeRequest
    {
        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public Language Language { get; set; }
    }
}