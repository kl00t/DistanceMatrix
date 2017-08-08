namespace Travel.Api.Domain.Models
{
    using System.Collections.Generic;
    using Interfaces;

    public class ElevationResponse : BaseResponse, IElevationResponse
    {
        public List<Elevation> Results { get; set; } 
    }
}