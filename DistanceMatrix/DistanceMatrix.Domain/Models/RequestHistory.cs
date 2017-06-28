namespace DistanceMatrix.Domain.Models
{
	using System;
	using System.Runtime.Serialization;
	using Interfaces;

	/// <summary>
	/// Request History class.
	/// </summary>
	/// <seealso cref="DistanceMatrix.Domain.Interfaces.IRequestHistory" />
	[DataContract]
	[Serializable]
	public class RequestHistory : IRequestHistory
    {
		[DataMember]
		public Guid Id { get; set; }

		[DataMember]
		public DistanceMatrixRequest Request { get; set; }
	}
}