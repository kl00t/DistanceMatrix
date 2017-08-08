namespace Travel.Api.Domain.Interfaces
{

    using System.Collections.Generic;
    using Enums;
    using Models;

    /// <summary>
    /// Response for the distance matrix request.
    /// </summary>
    public interface IDistanceMatrixResponse
    {
        /// <summary>
        /// Gets or sets the origin addresses.
        /// </summary>
        /// <value>
        /// The origin addresses.
        /// </value>
        List<string> OriginAddresses { get; set; }

        /// <summary>
        /// Gets or sets the destination addresses.
        /// </summary>
        /// <value>
        /// The destination addresses.
        /// </value>
        List<string> DestinationAddresses { get; set; }

        /// <summary>
        /// Gets or sets the rows.
        /// </summary>
        /// <value>
        /// The rows.
        /// </value>
        List<Row> Rows { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        Status Status { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        string ErrorMessage { get; set; }
    }
}