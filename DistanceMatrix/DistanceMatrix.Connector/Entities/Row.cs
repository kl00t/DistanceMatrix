// ReSharper disable InconsistentNaming
namespace DistanceMatrix.Connector.Entities
{
    /// <summary>
    /// Row containing list of elements.
    /// </summary>
    public class Row
    {
        /// <summary>
        /// Gets or sets the elements.
        /// </summary>
        /// <value>
        /// The elements.
        /// </value>
        public Element[] elements { get; set; }
    }
}