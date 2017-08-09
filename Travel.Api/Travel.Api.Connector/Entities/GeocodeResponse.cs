namespace Travel.Api.Connector.Entities
{
    public class GeocodeResponse : BaseResponse
    {
        public Address[] results { get; set; }
    }
}