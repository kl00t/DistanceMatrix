// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    /// <summary>
    /// Top level response returned from api.
    /// </summary>
    public class DistanceMatrixResponse : BaseResponse
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
    }
}