namespace DistanceMatrix.Kernel.Resolvers
{
    using AutoMapper;
    using Domain.Enums;

    // ReSharper disable once ClassNeverInstantiated.Global
    /// <summary>
    /// Resolves a string to our internal domain enum.
    /// </summary>
    public class ElementStatusResolver : ValueResolver<string, ElementStatus>
    {
        /// <summary>
        /// Implementors override this method to resolve the destination value based on the provided source value
        /// </summary>
        /// <param name="source">Source value</param>
        /// <returns>
        /// Destination
        /// </returns>
        protected override ElementStatus ResolveCore(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                return ElementStatus.Ok;
            }

            switch (source)
            {
                case "NOT_FOUND":
                    return ElementStatus.NotFound;
                case "ZERO_RESULTS":
                    return ElementStatus.ZeroResults;
                case "MAX_ROUTE_LENGTH_EXCEEDED":
                    return ElementStatus.MaxRouteLengthExceeded;
                default:
                    return ElementStatus.Ok;
            }
        }
    }
}