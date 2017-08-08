namespace Travel.Api.Domain.Enums
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
        ConfigurationError,

        /// <summary>
        /// The invalid API key
        /// </summary>
        [EnumMember]
        InvalidApiKey,

        /// <summary>
        /// The request denied
        /// </summary>
        [EnumMember]
        RequestDenied,

        /// <summary>
        /// The invalid request
        /// </summary>
        [EnumMember]
        InvalidRequest,

        /// <summary>
        /// The maximum elements exceeded
        /// </summary>
        [EnumMember]
        MaxElementsExceeded,

        /// <summary>
        /// The over query limit
        /// </summary>
        [EnumMember]
        OverQueryLimit
    }
}