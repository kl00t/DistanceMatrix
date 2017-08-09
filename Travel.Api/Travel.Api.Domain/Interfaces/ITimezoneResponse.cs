namespace Travel.Api.Domain.Interfaces
{
    public interface ITimezoneResponse
    {
        string DstOffset { get; set; }

        string RawOffset { get; set; }

        string TimeZoneId { get; set; }

        string TimeZoneName { get; set; }
    }
}