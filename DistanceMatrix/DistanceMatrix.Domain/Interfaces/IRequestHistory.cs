namespace DistanceMatrix.Domain.Interfaces
{
	using DistanceMatrix.Domain.Enums;
	using System;

    public interface IRequestHistory
    {
        Guid Id { get; set; }

		Models.DistanceMatrixRequest Request { get; set; }
	}
}