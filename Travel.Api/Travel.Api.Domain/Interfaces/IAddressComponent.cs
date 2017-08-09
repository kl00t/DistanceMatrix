namespace Travel.Api.Domain.Interfaces
{
    using System.Collections.Generic;

    public interface IAddressComponent
    {
        string LongName { get; set; }

        string ShortName { get; set; }

        List<string> Types { get; set; }
    }
}