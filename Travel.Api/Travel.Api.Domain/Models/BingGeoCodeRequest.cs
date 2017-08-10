namespace Travel.Api.Domain.Models
{
    public class BingGeoCodeRequest
    {
        public string Query { get; set; }

        public bool IncludeIso2 { get; set; }

        public bool IncludeNeighborhood { get; set; }

        public int MaxResults { get; set; }
    }
}