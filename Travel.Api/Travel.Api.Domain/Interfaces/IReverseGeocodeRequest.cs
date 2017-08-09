namespace Travel.Api.Domain.Interfaces
{
    using Models;

    public interface IReverseGeocodeRequest
    {
        Location Location { get; set; }
    }
}