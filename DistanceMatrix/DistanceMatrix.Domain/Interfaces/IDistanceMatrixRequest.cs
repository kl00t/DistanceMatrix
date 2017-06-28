using DistanceMatrix.Domain.Enums;

namespace DistanceMatrix.Domain.Interfaces
{
    public interface IDistanceMatrixRequest
    {
        string Origin { get; set; }

        string Destination { get; set; }

		Mode Mode { get; set; }
	}
}