// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    /// <summary>
    /// Duration entity showing how long travel takes.
    /// </summary>
    public class Duration
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string text { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public int value { get; set; }
    }
}