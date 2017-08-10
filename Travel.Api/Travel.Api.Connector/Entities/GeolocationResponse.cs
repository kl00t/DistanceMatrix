// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    public class GeolocationResponse : BaseResponse
    {
        public Location location { get; set; }

        public string accuracy { get; set; }
    }
}