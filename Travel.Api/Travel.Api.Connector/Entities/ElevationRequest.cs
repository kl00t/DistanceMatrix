// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    public class ElevationRequest : BaseRequest
    {
        public string key { get; set; }

        public string locations { get; set; }
    }
}