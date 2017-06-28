namespace DistanceMatrix.Domain.Models
{

    using Interfaces;

    public class Distance : IDistance
    {
        public string Text { get; set; }

        public int Value { get; set; }
    }
}
