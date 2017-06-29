namespace DistanceMatrix.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Enums;
    using Interfaces;

    /// <summary>
    /// The element class.
    /// </summary>
    [DataContract]
    [Serializable]
    public class Element : IElement
    {
        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        [DataMember]
        public Distance Distance { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        [DataMember]
        public Duration Duration { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [DataMember]
        public ElementStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the fare.
        /// </summary>
        /// <value>
        /// The fare.
        /// </value>
        [DataMember]
        public Fare Fare { get; set; }
    }
}