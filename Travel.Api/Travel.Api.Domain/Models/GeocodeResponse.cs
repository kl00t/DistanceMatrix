namespace Travel.Api.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class GeocodeResponse : BaseResponse, IGeocodeResponse
    {
        [DataMember]
        public List<Address> Results { get; set; }
    }
}
