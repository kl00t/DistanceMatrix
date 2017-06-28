namespace DistanceMatrix.Domain.Interfaces
{
    using System.Collections.Generic;
    using Enums;
    using Models;

    public interface IDistanceMatrixResponse
    {
        List<string> OriginAddresses { get; set; }

        List<string> DestinationAddresses { get; set; }

        List<Row> Rows { get; set; }

        Status Status { get; set; }
    }
}