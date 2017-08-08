// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    public class TimezoneResponse : BaseResponse
    {
        public string dstOffset { get; set; }

        public string rawOffset { get; set; }

        public string timeZoneId { get; set; }

        public string timeZoneName { get; set; }
    }
}