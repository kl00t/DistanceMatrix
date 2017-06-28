namespace DistanceMatrix.Domain.Models
{

    using Interfaces;

    public class DistanceMatrixRequest : IDistanceMatrixRequest
    {
        public string Origin { get; set; }

        public string Destination { get; set; }
    }
}
