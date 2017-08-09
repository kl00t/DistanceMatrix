namespace Travel.Api.Domain.Interfaces
{
    using Models;

    public interface IGeometry
    {
        Location Location { get; set; }

        string LocationType { get; set; }

        Viewport Viewport { get; set; }
    }
}