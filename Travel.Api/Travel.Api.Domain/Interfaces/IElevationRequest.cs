namespace Travel.Api.Domain.Interfaces
{
    public interface IElevationRequest
    {
        string Latitude { get; set; }

        string Longitude { get; set; }
    }
}