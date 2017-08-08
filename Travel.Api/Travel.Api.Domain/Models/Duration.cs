namespace Travel.Api.Domain.Models
{

    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class Duration : IDuration
    {
        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public int Value { get; set; }
    }
}
