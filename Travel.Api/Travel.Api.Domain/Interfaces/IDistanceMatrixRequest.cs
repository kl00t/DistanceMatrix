namespace Travel.Api.Domain.Interfaces
{

    using Enums;

    public interface IDistanceMatrixRequest
    {
        string Origins { get; set; }

        string Destinations { get; set; }

		Mode Mode { get; set; }
	}
}