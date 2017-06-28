namespace DistanceMatrix.Domain.Models
{

    using Interfaces;

    public class DistanceMatrixResponse : IDistanceMatrixResponse
    {
        public string[] OriginAddresses { get; set; }

        public string[] DestinationAddresses { get; set; }

        public Element[] Rows { get; set; }

        public string Status { get; set; }
    }
}