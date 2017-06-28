namespace DistanceMatrix.Domain.Interfaces
{

    using System.Dynamic;
    using Models;

    public interface IDistanceMatrixResponse
    {
        string[] OriginAddresses { get; set; }

        string[] DestinationAddresses { get; set; }

        Element[] Rows { get; set; }

        string Status { get; set; }
    }
}