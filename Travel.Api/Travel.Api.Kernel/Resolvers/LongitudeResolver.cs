namespace Travel.Api.Kernel.Resolvers
{
    using AutoMapper;
    using Domain.Models;

    public class LongitudeResolver : ValueResolver<Domain.Models.ElevationRequest, string>
    {
        protected override string ResolveCore(ElevationRequest source)
        {
            throw new System.NotImplementedException();
        }
    }
}