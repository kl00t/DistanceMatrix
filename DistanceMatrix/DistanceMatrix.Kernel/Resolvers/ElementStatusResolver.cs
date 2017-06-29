namespace DistanceMatrix.Kernel.Resolvers
{
    using AutoMapper;
    using Domain.Enums;

    public class ElementStatusResolver : ValueResolver<string, ElementStatus>
    {
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