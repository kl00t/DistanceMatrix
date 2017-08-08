namespace Travel.Api.Domain.Models
{

    using System;
    using System.Runtime.Serialization;
    using Enums;
    using Interfaces;

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