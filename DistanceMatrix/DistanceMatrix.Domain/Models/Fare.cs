namespace DistanceMatrix.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Interfaces;

    /// <summary>
    /// The fare class.
    /// </summary>
    [DataContract]
    [Serializable]
    public class Fare : IFare
    {
        [DataMember]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [DataMember]
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        [DataMember]
        public string Currency { get; set; }
    }
}