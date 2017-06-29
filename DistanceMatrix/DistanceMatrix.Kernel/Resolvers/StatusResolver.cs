namespace DistanceMatrix.Kernel.Resolvers
{
    using AutoMapper;
    using Domain.Enums;

    public class StatusResolver : ValueResolver<string, Status>
    {
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
                default:
                    return Status.UnknownError;

            }
        }
    }
}