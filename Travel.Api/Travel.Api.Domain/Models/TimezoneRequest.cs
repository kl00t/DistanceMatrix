namespace Travel.Api.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class TimezoneRequest : BaseRequest, ITimezoneRequest
    {
        [DataMember]
        public Location Location { get; set; }

        [DataMember]
        public string Timestamp { get; set; }

        [DataMember]
        public Language Language { get; set; }
    }
}