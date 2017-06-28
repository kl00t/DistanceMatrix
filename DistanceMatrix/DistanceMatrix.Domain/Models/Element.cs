namespace DistanceMatrix.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Enums;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class Element : IElement
    {
        [DataMember]
        public Distance Distance { get; set; }

        [DataMember]
        public Duration Duration { get; set; }

        [DataMember]
        public ElementStatus Status { get; set; }
    }
}