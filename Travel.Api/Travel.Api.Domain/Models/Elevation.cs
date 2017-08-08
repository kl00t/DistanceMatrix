namespace Travel.Api.Domain.Models
{

    using Interfaces;

    public class Elevation : IElevation
    {
        string IElevation.Elevation { get; set; }

        public Location Location { get; set; }

        public string Resolution { get; set; }
    }
}