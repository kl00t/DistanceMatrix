// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    public class Geometry
    {
        public Location location { get; set; }

        public string location_type { get; set; }

        public Viewport viewport { get; set; }
    }
}
