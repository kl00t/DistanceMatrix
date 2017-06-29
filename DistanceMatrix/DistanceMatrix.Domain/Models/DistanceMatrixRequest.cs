namespace DistanceMatrix.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;
	using Enums;

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
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets the destination.
        /// </summary>
        /// <value>
        /// The destination.
        /// </value>
        [DataMember]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        [DataMember]
		public Mode Mode { get; set; }

        /// <summary>
        /// Gets or sets the units.
        /// </summary>
        /// <value>
        /// The units.
        /// </value>
        [DataMember]
		public Units Units { get; set; }
	}
}