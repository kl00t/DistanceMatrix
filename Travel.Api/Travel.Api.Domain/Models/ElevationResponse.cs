namespace Travel.Api.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class ElevationResponse : BaseResponse, IElevationResponse
    {
        [DataMember]
        public List<Elevation> Results { get; set; } 
    }
}