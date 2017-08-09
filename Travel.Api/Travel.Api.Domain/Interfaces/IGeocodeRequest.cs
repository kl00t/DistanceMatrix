namespace Travel.Api.Domain.Interfaces
{
    using Models;

    public interface IGeocodeRequest
    {
        string Address { get; set; }

        Language Language { get; set; }
    }
}
