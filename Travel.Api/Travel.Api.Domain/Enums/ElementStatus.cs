namespace Travel.Api.Domain.Enums
{

    using System;
    using System.Runtime.Serialization;

    [DataContract]
	[Serializable]
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