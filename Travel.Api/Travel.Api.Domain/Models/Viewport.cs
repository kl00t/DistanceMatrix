namespace Travel.Api.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class Viewport : IViewport
    {
        [DataMember]
        public Location NorthEast { get; set; }

        [DataMember]
        public Location SouthEast { get; set; }
    }
}