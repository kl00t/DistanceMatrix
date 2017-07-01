namespace DistanceMatrix.Domain.Enums
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    [Serializable]
    public enum EventType
    {
        /// <summary>
        /// The event type is not specified.
        /// </summary>
        [EnumMember]
        NotSpecified,

        /// <summary>
        /// The distance matrix
        /// </summary>
        [EnumMember]
        DistanceMatrix,

        /// <summary>
        /// The performance timing
        /// </summary>
        [EnumMember]
        PerformanceTiming,

        /// <summary>
        /// The get distance matrix request history
        /// </summary>
        [EnumMember]
        GetDistanceMatrixRequestHistory,

        /// <summary>
        /// The get request history
        /// </summary>
        [EnumMember]
        GetRequestHistory,

        /// <summary>
        /// The replay request
        /// </summary>
        [EnumMember]
        ReplayRequest,

		[EnumMember]
		Directions,

		[EnumMember]
		DeleteRequestHistory
	}
}