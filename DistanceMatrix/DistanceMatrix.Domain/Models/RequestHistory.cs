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
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DataMember]
		public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>
        /// The request.
        /// </value>
        [DataMember]
		public DistanceMatrixRequest Request { get; set; }
	}
}