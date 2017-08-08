namespace Travel.Api.Domain.Models
{

    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Interfaces;

    /// <summary>
	/// Distance Matric Request.
	/// </summary>
	[DataContract]
	[Serializable]
	public class DirectionsResponse : BaseResponse, IDirectionsResponse
	{
		[DataMember]
		public List<GeocodedWaypoint> GeocodedWaypoints { get; set; }

		[DataMember]
		public List<Route> Routes { get; set; }
	}
}