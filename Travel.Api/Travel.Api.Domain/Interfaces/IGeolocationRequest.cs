namespace Travel.Api.Domain.Interfaces
{

    using System.Collections.Generic;
    using Models;

    public interface IGeolocationRequest
    {
        string Carrier { get; set; }

        string HomeMobileCountryCode { get; set; }

        string HomeMobileNetworkCode { get; set; }

        string RadioType { get; set; }

        bool ConsiderIp { get; set; }

        ////List<CellTower> CellTowers { get; set; }

        ////List<WifiAccessPoint> WifiAccessPoints { get; set; }
    }
}