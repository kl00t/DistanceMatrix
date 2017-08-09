namespace Travel.Api.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class Geometry : IGeometry
    {
        [DataMember]
        public Location Location { get; set; }

        [DataMember]
        public string LocationType { get; set; }

        [DataMember]
        public Viewport Viewport { get; set; }
    }
}