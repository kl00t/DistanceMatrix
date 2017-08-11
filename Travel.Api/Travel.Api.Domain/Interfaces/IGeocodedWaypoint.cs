namespace Travel.Api.Domain.Interfaces
{
    using System.Collections.Generic;

    public interface IGeocodedWaypoint
	{
        List<string> Types { get; set; }

        string GeocoderStatus { get; set; }

        string PartialMatch { get; set; }

        string PlaceId { get; set; }
    }
}