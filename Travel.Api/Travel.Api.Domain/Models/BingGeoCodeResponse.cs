namespace Travel.Api.Domain.Models
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    [Serializable]
    public class BingGeoCodeResponse
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Confidence { get; set; }

        [DataMember]
        public string EntityType { get; set; }
    }
}