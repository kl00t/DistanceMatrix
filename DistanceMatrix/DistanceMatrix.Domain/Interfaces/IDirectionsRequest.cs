using DistanceMatrix.Domain.Enums;

namespace DistanceMatrix.Domain.Interfaces
{
	public interface IDirectionsRequest
	{
		string Origin { get; set; }

		string Destination { get; set; }

		Mode Mode { get; set; }
	}
}