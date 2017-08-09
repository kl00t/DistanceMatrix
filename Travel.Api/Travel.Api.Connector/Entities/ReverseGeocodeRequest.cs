// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    public class ReverseGeocodeRequest : BaseRequest
    {
        public string latlng { get; set; }
    }
}