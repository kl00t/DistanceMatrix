namespace DistanceMatrix.Domain.Enums
{

    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Capita Service Error.
    /// </summary>
    [Serializable]
    [DataContract]
    public enum ServiceError
    {
        /// <summary>
        /// The none.
        /// </summary>
        [EnumMember]
        None,

        /// <summary>
        /// The unknown.
        /// </summary>
        [EnumMember]
        Unknown,

        /// <summary>
        /// The invalid argument
        /// </summary>
        [EnumMember]
        InvalidArgument,

        /// <summary>
        /// The distance matrix error
        /// </summary>
        [EnumMember]
        DistanceMatrixError,

        /// <summary>
        /// The configuration error
        /// </summary>
        [EnumMember]
        ConfigurationError
    }
}