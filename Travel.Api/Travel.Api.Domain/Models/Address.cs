namespace Travel.Api.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class Address : IAddress
    {
        [DataMember]
        public List<AddressComponent> AddressComponents { get; set; }

        [DataMember]
        public string FormattedAddress { get; set; }

        [DataMember]
        public Geometry Geometry { get; set; }

        [DataMember]
        public string PlaceId { get; set; }

        [DataMember]
        public List<string> Types { get; set; }
    }
}