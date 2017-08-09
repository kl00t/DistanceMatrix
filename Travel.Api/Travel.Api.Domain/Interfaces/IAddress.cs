namespace Travel.Api.Domain.Interfaces
{
    using System.Collections.Generic;
    using Models;

    public interface IAddress
    {
        List<AddressComponent> AddressComponents { get; set; }

        string FormattedAddress { get; set; }

        Geometry Geometry { get; set; }

        string PlaceId { get; set; }

        List<string> Types { get; set; }
    }
}