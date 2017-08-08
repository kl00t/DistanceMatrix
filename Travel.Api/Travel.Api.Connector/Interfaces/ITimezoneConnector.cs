namespace Travel.Api.Connector.Interfaces
{

    using Entities;

    public interface ITimezoneConnector
    {
        TimezoneResponse Timezone(TimezoneRequest request);
    }
}