namespace DistanceMatrix.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Enums;
    using Interfaces;

    /// <summary>
    /// Response for the distance matrix request.
    /// </summary>
    [DataContract]
    [Serializable]
    public class DistanceMatrixResponse : IDistanceMatrixResponse
    {
        /// <summary>
        /// Gets or sets the origin addresses.
        /// </summary>
        /// <value>
        /// The origin addresses.
        /// </value>
        [DataMember]
        public List<string> OriginAddresses { get; set; }

        /// <summary>
        /// Gets or sets the destination addresses.
        /// </summary>
        /// <value>
        /// The destination addresses.
        /// </value>
        [DataMember]
        public List<string> DestinationAddresses { get; set; }

        /// <summary>
        /// Gets or sets the rows.
        /// </summary>
        /// <value>
        /// The rows.
        /// </value>
        [DataMember]
        public List<Row> Rows { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [DataMember]
        public Status Status { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        [DataMember]
        public string ErrorMessage { get; set; }
    }
}