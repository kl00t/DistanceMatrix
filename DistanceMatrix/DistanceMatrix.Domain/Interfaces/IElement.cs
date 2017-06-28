namespace DistanceMatrix.Domain.Interfaces
{
    using Enums;
    using Models;

    public interface IElement
    {
        Distance Distance { get; set; }

        Duration Duration { get; set; }

        ElementStatus Status { get; set; }
    }
}