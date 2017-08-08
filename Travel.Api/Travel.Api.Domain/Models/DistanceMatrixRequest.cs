namespace Travel.Api.Domain.Models
{

    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using Enums;
    using Interfaces;

    /// <summary>
	/// Distance Matric Request.
	/// </summary>
	/// <seealso cref="IDistanceMatrixRequest" />
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