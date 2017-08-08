namespace Travel.Api.Domain.Enums
{

    using System;
    using System.Runtime.Serialization;

    [DataContract]
	[Serializable]
	public enum Mode
	{
		[EnumMember]
		Driving,

		[EnumMember]
		Walking,

		[EnumMember]
		Bicycling

		//[EnumMember]
		//Transit
	}
}