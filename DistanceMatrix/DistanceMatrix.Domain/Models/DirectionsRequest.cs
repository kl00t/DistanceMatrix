namespace DistanceMatrix.Domain.Models
{
	using DistanceMatrix.Domain.Enums;
	using DistanceMatrix.Domain.Interfaces;
	using System;
	using System.Runtime.Serialization;

	/// <summary>
	/// Distance Matric Request.
	/// </summary>
	[DataContract]
	[Serializable]
	public class DirectionsRequest : IDirectionsRequest
	{
		[DataMember]
		public string Origin { get; set; }

		[DataMember]
		public string Destination { get; set; }

		[DataMember]
		public Mode Mode { get; set; }
	}
}