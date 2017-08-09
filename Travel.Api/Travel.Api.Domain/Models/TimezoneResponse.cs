namespace Travel.Api.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class TimezoneResponse :  BaseResponse, ITimezoneResponse
    {
        [DataMember]
        public string DstOffset { get; set; }

        [DataMember]
        public string RawOffset { get; set; }

        [DataMember]
        public string TimeZoneId { get; set; }

        [DataMember]
        public string TimeZoneName { get; set; }
    }
}
