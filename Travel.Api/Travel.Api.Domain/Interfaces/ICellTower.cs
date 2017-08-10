namespace Travel.Api.Domain.Interfaces
{
    public interface ICellTower
    {
        int CellId { get; set; }

        int LocationAreaCode { get; set; }

        int MobileCountryCode { get; set; }

        int MobileNetworkCode { get; set; }

        int Age { get; set; }

        int SignalStrength { get; set; }

        int TimingAdvance { get; set; }
    }
}