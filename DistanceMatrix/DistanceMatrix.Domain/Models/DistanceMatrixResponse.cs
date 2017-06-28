namespace DistanceMatrix.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Enums;
    using Interfaces;

    [DataContract]
    [Serializable]
    public class DistanceMatrixResponse : IDistanceMatrixResponse
    {
        [DataMember]
        public List<string> OriginAddresses { get; set; }

        [DataMember]
        public List<string> DestinationAddresses { get; set; }

        [DataMember]
        public List<Row> Rows { get; set; }

        [DataMember]
        public Status Status { get; set; }
    }
}