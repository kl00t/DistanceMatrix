namespace DistanceMatrix.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;
	using DistanceMatrix.Domain.Enums;

	[DataContract]
    [Serializable]
    public class DistanceMatrixRequest : IDistanceMatrixRequest
    {
        [DataMember]
        public string Origin { get; set; }

        [DataMember]
        public string Destination { get; set; }

		[DataMember]
		public Mode Mode { get; set; }

		[DataMember]
		public Units Units { get; set; }
	}
}