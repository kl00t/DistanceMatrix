namespace Travel.Api.Domain.Models
{

    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class Row : IRow
    {
        [DataMember]
        public List<Element> Elements { get; set; }
    }
}