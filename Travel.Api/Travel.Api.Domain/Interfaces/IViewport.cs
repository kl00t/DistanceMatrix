namespace Travel.Api.Domain.Interfaces
{
    using Models;

    public interface IViewport
    {
        Location NorthEast { get; set; }

        Location SouthEast { get; set; }
    }
}