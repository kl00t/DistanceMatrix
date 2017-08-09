namespace Travel.Api.Domain.Interfaces
{
    using Models;

    public interface ITimezoneRequest
    {
        Location Location { get; set; }

        string Timestamp { get; set; }

        Language Language { get; set; }
    }
}