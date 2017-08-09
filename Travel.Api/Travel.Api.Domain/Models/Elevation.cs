namespace Travel.Api.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class Elevation : IElevation
    {
        [DataMember]
        string IElevation.Elevation { get; set; }

        [DataMember]
        public Location Location { get; set; }

        [DataMember]
        public string Resolution { get; set; }
    }
}