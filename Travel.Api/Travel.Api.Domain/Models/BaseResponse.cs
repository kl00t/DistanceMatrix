namespace Travel.Api.Domain.Models
{
    using System;
    using System.Runtime.Serialization;
    using Enums;

    [DataContract]
	[Serializable]
	public class BaseResponse
	{
		[DataMember]
		public Status Status { get; set; }

		[DataMember]
		public string ErrorMessage { get; set; }
	}
}