namespace Travel.Api.Domain.Models
{

    using System;
    using System.Runtime.Serialization;

    [DataContract]
	[Serializable]
	public class BaseResponse
	{
		[DataMember]
		public Enums.Status Status { get; set; }

		[DataMember]
		public string ErrorMessage { get; set; }
	}
}