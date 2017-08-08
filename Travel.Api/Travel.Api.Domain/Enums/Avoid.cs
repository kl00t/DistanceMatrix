namespace Travel.Api.Domain.Enums
{

    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Avoid any of the following routes that contain.
    /// </summary>
    [DataContract]
    [Serializable]
    public enum Avoid
    {
        [EnumMember]
        Tolls,

        [EnumMember]
        Highways,

        [EnumMember]
        Ferries,

        [EnumMember]
        Indoor
    }
}