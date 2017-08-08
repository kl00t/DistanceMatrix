namespace Travel.Api.Domain.Interfaces
{
    /// <summary>
    /// Duration interface
    /// </summary>
    public interface IDuration
    {
        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        string Text { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        int Value { get; set; }
    }
}