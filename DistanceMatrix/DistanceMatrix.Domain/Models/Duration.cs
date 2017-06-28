namespace DistanceMatrix.Domain.Models
{

    using Interfaces;

    public class Duration : IDuration
    {
        public string Text { get; set; }

        public int Value { get; set; }
    }
}
