namespace Travel.Api.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class AddressComponent : IAddressComponent
    {
        [DataMember]
        public string LongName { get; set; }

        [DataMember]
        public string ShortName { get; set; }

        [DataMember]
        public List<string> Types { get; set; }
    }
}