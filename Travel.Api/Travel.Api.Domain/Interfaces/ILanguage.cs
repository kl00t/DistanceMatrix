namespace Travel.Api.Domain.Interfaces
{
    public interface ILanguage
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The 2 letter alpha code.
        /// </value>
        string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name of the language
        /// </value>
        string Name { get; set; }
    }
}