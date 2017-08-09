namespace Travel.Api.Kernel.Resolvers
{

    using AutoMapper;
    using Domain.Enums;

    // ReSharper disable once ClassNeverInstantiated.Global
    /// <summary>
    /// Resolves a string to our internal domain enum.
    /// </summary>
    public class StatusResolver : ValueResolver<string, Status>
    {
        /// <summary>
        /// Implementors override this method to resolve the destination value based on the provided source value
        /// </summary>
        /// <param name="source">Source value</param>
        /// <returns>
        /// Destination
        /// </returns>
        protected override Status ResolveCore(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return Status.Ok;
            }

            switch (source)
            {
                case "OK":
                    return Status.Ok;
                case "INVALID_REQUEST":
                    return Status.InvalidRequest;
                case "MAX_ELEMENTS_EXCEEDED":
                    return Status.MaxElementsExceeded;
                case "OVER_QUERY_LIMIT":
                    return Status.OverQueryLimit;
                case "REQUEST_DENIED":
                    return Status.RequestDenied;
                case "ZERO_RESULTS":
                    return Status.ZeroResults;
                default:
                    return Status.UnknownError;

            }
        }
    }
}