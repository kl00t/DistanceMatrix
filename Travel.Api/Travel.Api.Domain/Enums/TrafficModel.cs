namespace Travel.Api.Domain.Enums
{

    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Specifies the assumptions to use when calculating time in traffic. 
    /// </summary>
    [DataContract]
    [Serializable]
    public enum TrafficModel
    {
        /// <summary>
        /// indicates that the returned duration_in_traffic should be the best estimate of travel time given what is known about both historical traffic conditions and live traffic. Live traffic becomes more important the closer the departure_time is to now.
        /// </summary>
        [EnumMember]
        BestGuess,

        /// <summary>
        /// pessimistic indicates that the returned duration_in_traffic should be longer than the actual travel time on most days, though occasional days with particularly bad traffic conditions may exceed this value.
        /// </summary>
        [EnumMember]
        Pessimistic,

        /// <summary>
        /// optimistic indicates that the returned duration_in_traffic should be shorter than the actual travel time on most days, though occasional days with particularly good traffic conditions may be faster than this value.
        /// </summary>
        [EnumMember]
        Optimistic
    }
}