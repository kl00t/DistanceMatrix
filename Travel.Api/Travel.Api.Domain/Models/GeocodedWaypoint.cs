namespace Travel.Api.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Interfaces;

    [DataContract]
	[Serializable]
	public class GeocodedWaypoint : IGeocodedWaypoint
	{
        [DataMember]
        public List<string> Types { get; set; }

        [DataMember]
        public string GeocoderStatus { get; set; }

        [DataMember]
        public string PartialMatch { get; set; }

        [DataMember]
        public string PlaceId { get; set; }
	}
}