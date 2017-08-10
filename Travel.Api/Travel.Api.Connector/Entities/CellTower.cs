// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    public class CellTower
    {
        public string cellId { get; set; }

        public string locationAreaCode { get; set; }

        public string mobileCountryCode { get; set; }

        public string mobileNetworkCode { get; set; }

        public string signalStrength { get; set; }

        public string timingAdvance { get; set; }

        public string age { get; set; }
    }
}