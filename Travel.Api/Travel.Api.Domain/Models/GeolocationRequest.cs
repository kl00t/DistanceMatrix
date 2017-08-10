namespace Travel.Api.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class GeolocationRequest : BaseRequest, IGeolocationRequest
    {
        [DataMember]
        public string Carrier { get; set; }

        [DataMember]
        public string HomeMobileCountryCode { get; set; }

        [DataMember]
        public string HomeMobileNetworkCode { get; set; }

        [DataMember]
        public string RadioType { get; set; }

        [DataMember]
        public bool ConsiderIp { get; set; }

        ////[DataMember]
        ////public List<CellTower> CellTowers { get; set; }

        ////[DataMember]
        ////public List<WifiAccessPoint> WifiAccessPoints { get; set; }
    }
}