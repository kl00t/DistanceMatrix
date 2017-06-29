// ReSharper disable InconsistentNaming
namespace DistanceMatrix.Connector.Entities
{
    /// <summary>
    /// Request for api.
    /// </summary>
    public class DistanceMatrixRequest : BaseRequest
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

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        public string language { get; set; }

        /// <summary>
        /// Gets or sets the avoid.
        /// </summary>
        /// <value>
        /// The avoid.
        /// </value>
        public string avoid { get; set; }

        /// <summary>
        /// Gets or sets the arrival time.
        /// </summary>
        /// <value>
        /// The arrival time.
        /// </value>
        public string arrival_time { get; set; }

        /// <summary>
        /// Gets or sets the departure time.
        /// </summary>
        /// <value>
        /// The departure time.
        /// </value>
        public string departure_time { get; set; }

        /// <summary>
        /// Gets or sets the traffic model.
        /// </summary>
        /// <value>
        /// The traffic model.
        /// </value>
        public string traffic_model { get; set; }

        /// <summary>
        /// Gets or sets the transit mode.
        /// </summary>
        /// <value>
        /// The transit mode.
        /// </value>
        public string transit_mode { get; set; }

        /// <summary>
        /// Gets or sets the transit routing preference.
        /// </summary>
        /// <value>
        /// The transit routing preference.
        /// </value>
        public string transit_routing_preference { get; set; }
    }
}