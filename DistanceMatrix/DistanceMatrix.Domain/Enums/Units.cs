namespace DistanceMatrix.Domain.Enums
{
	using System;
	using System.Runtime.Serialization;

	[DataContract]
	[Serializable]
	public enum Units
	{
		[EnumMember]
		Imperial,

		[EnumMember]
		Metric
	}
}