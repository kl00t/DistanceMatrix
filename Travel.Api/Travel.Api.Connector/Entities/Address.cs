// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    public class Address
    {
        public AddressComponent[] address_components { get; set; }

        public string formatted_address { get; set; }

        public Geometry geometry { get; set; }

        public string place_id { get; set; }

        public string[] types { get; set; }
    }
}