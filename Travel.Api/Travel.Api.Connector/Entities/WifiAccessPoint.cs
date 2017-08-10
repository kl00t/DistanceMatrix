// ReSharper disable InconsistentNaming
namespace Travel.Api.Connector.Entities
{
    public class WifiAccessPoint
    {
        public string macAddress { get; set; }

        public string signalStrength { get; set; }

        public string age { get; set; }

        public string channel { get; set; }

        public string signalToNoiseRatio { get; set; }
    }
}