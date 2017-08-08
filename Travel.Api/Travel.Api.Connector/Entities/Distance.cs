// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    /// <summary>
    /// Distance of travel shown in in metric or imperial
    /// </summary>
    public class Distance
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