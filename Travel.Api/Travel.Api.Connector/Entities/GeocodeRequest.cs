// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    public class GeocodeRequest : BaseRequest
    {
        public string address { get; set; }

        public string language { get; set; }
    }
}