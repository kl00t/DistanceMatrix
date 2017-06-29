// ReSharper disable InconsistentNaming
namespace DistanceMatrix.Connector.Entities
{
    /// <summary>
    /// Element containing distance and duration.
    /// </summary>
    public class Element
    {
        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        public Distance distance { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public Duration duration { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string status { get; set; }
    }
}