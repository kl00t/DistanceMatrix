namespace DistanceMatrix.Domain.Models
{
	using DistanceMatrix.Domain.Interfaces;
	using System;
	using System.Runtime.Serialization;
	using System.Collections.Generic;

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