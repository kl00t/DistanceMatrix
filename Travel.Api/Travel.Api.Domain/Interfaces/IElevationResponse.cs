namespace Travel.Api.Domain.Interfaces
{
    using System.Collections.Generic;
    using Models;

    public interface IElevationResponse
    {
        List<Elevation> Results { get; set; }
    }
}