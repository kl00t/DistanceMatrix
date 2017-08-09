namespace Travel.Api.Kernel.Resolvers
{
    using System;
    using AutoMapper;
    using Domain.Models;

    public class LocationsResolver : ValueResolver<Domain.Models.Location, string>
    {
        protected override string ResolveCore(Location source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            return string.Format("{0},{1}", source.Latitude, source.Longitude);
        }
    }
}