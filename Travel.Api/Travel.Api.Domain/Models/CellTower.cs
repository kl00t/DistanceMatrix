namespace Travel.Api.Domain.Models
{
    using System;
    using System.Dynamic;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class CellTower : ICellTower
    {
        [DataMember]
        public int CellId { get; set; }

        [DataMember]
        public int LocationAreaCode { get; set; }

        [DataMember]
        public int MobileCountryCode { get; set; }

        [DataMember]
        public int MobileNetworkCode { get; set; }

        [DataMember]
        public int Age { get; set; }
        
        [DataMember]
        public int SignalStrength { get; set; }

        [DataMember]
        public int TimingAdvance { get; set; }
    }
}