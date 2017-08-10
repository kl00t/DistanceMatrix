namespace Travel.Api.Domain.Interfaces
{
    public interface IWifiAccessPoint
    {
        string MacAddress { get; set; }

        int SignalStrength { get; set; }

        int Age { get; set; }

        int Channel { get; set; }

        int SignalToNoiseRatio { get; set; }
    }
}