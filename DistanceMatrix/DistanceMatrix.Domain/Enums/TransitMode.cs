namespace DistanceMatrix.Domain.Enums
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    [Serializable]
    public enum TransitMode
    {
        [EnumMember]
        Bus,

        [EnumMember]
        Subway,

        [EnumMember]
        Train,

        [EnumMember]
        Tram,

        [EnumMember]
        Rail
    }
}