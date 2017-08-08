namespace Travel.Api.Domain.Models
{
    using Interfaces;

    public class ElevationRequest : IElevationRequest
    {
        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }
}