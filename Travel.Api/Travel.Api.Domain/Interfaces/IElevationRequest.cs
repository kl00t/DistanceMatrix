namespace Travel.Api.Domain.Interfaces
{
    using Models;

    public interface IElevationRequest
    {
        Location Location { get; set; }
    }
}