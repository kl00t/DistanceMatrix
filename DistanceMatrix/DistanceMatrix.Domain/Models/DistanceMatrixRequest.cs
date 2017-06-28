namespace DistanceMatrix.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class DistanceMatrixRequest : IDistanceMatrixRequest
    {
        [DataMember]
        public string Origin { get; set; }

        [DataMember]
        public string Destination { get; set; }
    }
}