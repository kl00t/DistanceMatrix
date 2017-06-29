namespace DistanceMatrix.Domain.Enums
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Specifies one or more preferred modes of transit.
    /// </summary>
    [DataContract]
    [Serializable]
    public enum TransitRoutingPreference
    {
        [EnumMember]
        LessWalking,

        [EnumMember]
        FewerTransfers
    }
}
