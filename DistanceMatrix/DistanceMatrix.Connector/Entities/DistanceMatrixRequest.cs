// ReSharper disable InconsistentNaming
namespace DistanceMatrix.Connector.Entities
{
    /// <summary>
    /// Request for api.
    /// </summary>
    public class DistanceMatrixRequest
	{
        /// <summary>
        /// Gets or sets the origins.
        /// </summary>
        /// <value>
        /// The origins.
        /// </value>
        public string origins { get; set; }

        /// <summary>
        /// Gets or sets the destinations.
        /// </summary>
        /// <value>
        /// The destinations.
        /// </value>
        public string destinations { get; set; }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>
        /// The mode.
        /// </value>
        public string mode { get; set; }

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        /// <value>
        /// The key.
        /// </value>
        public string key { get; set; }

        /// <summary>
        /// Gets or sets the units.
        /// </summary>
        /// <value>
        /// The units.
        /// </value>
        public string units { get; set; }
	}
}