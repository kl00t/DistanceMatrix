namespace Travel.Api.Domain.Interfaces
{
    using System.Collections.Generic;
    using Models;

    public interface IGeocodeResponse
    {
        List<Address> Results { get; set; }
    }
}