// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    /// <summary>
    /// Fare entity.
    /// </summary>
    public class Fare
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The total fare amount, formatted in the requested language.
        /// </value>
        public string text { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The total fare amount, in the currency specified above.
        /// </value>
        public int value { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// An ISO 4217 currency code indicating the currency that the amount is expressed in.
        /// </value>
        public string currency { get; set; }
    }
}