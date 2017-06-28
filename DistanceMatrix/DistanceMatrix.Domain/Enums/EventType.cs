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
        GetDistanceMatrixRequestHistory
    }
}