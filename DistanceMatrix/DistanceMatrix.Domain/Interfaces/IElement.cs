namespace DistanceMatrix.Domain.Interfaces
{

    using Models;

    public interface IElement
    {
        Distance Distance { get; set; }

        Duration Duration { get; set; }

        string Status { get; set; }
    }
}