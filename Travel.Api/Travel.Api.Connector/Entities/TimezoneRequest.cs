// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    public class TimezoneRequest : BaseRequest
    {
        public string key { get; set; }

        public string location { get; set; }

        public string timestamp { get; set; }

        public string language { get; set; }
    }
}