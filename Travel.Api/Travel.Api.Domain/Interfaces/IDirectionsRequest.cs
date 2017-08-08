namespace Travel.Api.Domain.Interfaces
{

    using Enums;

    public interface IDirectionsRequest
	{
		string Origin { get; set; }

		string Destination { get; set; }

		Mode Mode { get; set; }
	}
}