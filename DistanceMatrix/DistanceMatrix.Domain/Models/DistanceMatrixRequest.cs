namespace DistanceMatrix.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;
	using Enums;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel;

	/// <summary>
	/// Distance Matric Request.
	/// </summary>
	/// <seealso cref="DistanceMatrix.Domain.Interfaces.IDistanceMatrixRequest" />
	[DataContract]
    [Serializable]
    public class DistanceMatrixRequest : IDistanceMatrixRequest
    {
        /// <summary>
        /// Gets or sets the origin.
        /// </summary>
        /// <value>
        /// The origin.
        /// </value>
        [DataMember]
		[DisplayName("Origin")]
		[Required]
		public string Origins { get; set; }

        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        /// <value>
        /// The destination.
        /// </value>
        [DataMember]
		[DisplayName("Destination")]
		[Required]
		public string Destinations { get; set; }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        [DataMember]
		[DisplayName("Mode of travel")]
		[Required]
		public Mode Mode { get; set; }

        /// <summary>
        /// Gets or sets the units.
        /// </summary>
        /// <value>
        /// The units.
        /// </value>
        [DataMember]
		[DisplayName("Units")]
		[Required]
		public Units Units { get; set; }
	}
}