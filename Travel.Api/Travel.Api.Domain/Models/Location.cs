namespace Travel.Api.Domain.Models
{
    using Interfaces;

    public class Location : ILocation
    {
        public string Latitude { get; set; }

        public string Longitude { get; set; }
    }
}