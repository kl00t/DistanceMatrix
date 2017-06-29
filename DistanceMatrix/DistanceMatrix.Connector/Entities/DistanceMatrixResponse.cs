// ReSharper disable InconsistentNaming
namespace DistanceMatrix.Connector.Entities
{
    /// <summary>
    /// Top level response returned from api.
    /// </summary>
    public class DistanceMatrixResponse
    {
        /// <summary>
        /// Gets or sets the destination addresses.
        /// </summary>
        /// <value>
        /// The destination addresses.
        /// </value>
        public string[] destination_addresses { get; set; }

        /// <summary>
        /// Gets or sets the origin addresses.
        /// </summary>
        /// <value>
        /// The origin addresses.
        /// </value>
        public string[] origin_addresses { get; set; }

        /// <summary>
        /// Gets or sets the rows.
        /// </summary>
        /// <value>
        /// The rows.
        /// </value>
        public Row[] rows { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string status { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        public string error_message { get; set; }
    }
}