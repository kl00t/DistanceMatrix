namespace Travel.Api.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class WifiAccessPoint : IWifiAccessPoint
    {
        [DataMember]
        public string MacAddress { get; set; }

        [DataMember]
        public int SignalStrength { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public int Channel { get; set; }

        [DataMember]
        public int SignalToNoiseRatio { get; set; }
    }
}
