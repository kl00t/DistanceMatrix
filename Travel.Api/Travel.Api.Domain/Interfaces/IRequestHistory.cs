namespace Travel.Api.Domain.Interfaces
{

    using System;

    /// <summary>
    /// Request history.
    /// </summary>
    public interface IRequestHistory
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>
        /// The request.
        /// </value>
        Models.DistanceMatrixRequest Request { get; set; }
	}
}