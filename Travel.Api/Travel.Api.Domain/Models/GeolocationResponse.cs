namespace Travel.Api.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class GeolocationResponse : BaseResponse, IGeolocationResponse
    {
        [DataMember]
        public Location Location { get; set; }

        [DataMember]
        public string Accuracy { get; set; }
    }
}