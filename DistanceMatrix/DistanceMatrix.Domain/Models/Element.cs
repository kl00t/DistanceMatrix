namespace DistanceMatrix.Domain.Models
{
    using Interfaces;

    public class Element : IElement
    {
        public Distance Distance { get; set; }
        public Duration Duration { get; set; }
        public string Status { get; set; }
    }
}