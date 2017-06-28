namespace DistanceMatrix.Domain.Enums
{
    using System.Runtime.Serialization;

    public enum ElementStatus
    {
        [EnumMember]
        Ok,

        [EnumMember]
        NotFound,

        [EnumMember]
        ZeroResults,

        [EnumMember]
        MaxRouteLengthExceeded
    }
}