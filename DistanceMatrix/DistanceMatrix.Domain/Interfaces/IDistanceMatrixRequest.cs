using DistanceMatrix.Domain.Enums;

namespace DistanceMatrix.Domain.Interfaces
{
    public interface IDistanceMatrixRequest
    {
        string Origins { get; set; }

        string Destinations { get; set; }

		Mode Mode { get; set; }
	}
}