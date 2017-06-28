namespace DistanceMatrix.Domain.Enums
{
    using System.Runtime.Serialization;

    public enum Status
    {
        [EnumMember]
        Ok,

        [EnumMember]
        InvalidRequest,

        [EnumMember]
        MaxElementsExceeded,

        [EnumMember]
        OverQueryLimit,

        [EnumMember]
        RequestDenied,

        [EnumMember]
        UnknownError
    }
}