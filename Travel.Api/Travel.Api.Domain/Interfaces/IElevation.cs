namespace Travel.Api.Domain.Interfaces
{
    using Models;

    public interface IElevation
    {
        string Elevation { get; set; }

        Location Location { get; set; }

        string Resolution { get; set; }
    }
}