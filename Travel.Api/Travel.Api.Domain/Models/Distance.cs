namespace Travel.Api.Domain.Models
{

    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class Distance : IDistance
    {
        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public int Value { get; set; }
    }
}
