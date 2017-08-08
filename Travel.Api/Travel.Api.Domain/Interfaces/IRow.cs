namespace Travel.Api.Domain.Interfaces
{

    using System.Collections.Generic;
    using Models;

    public interface IRow
    {
        List<Element> Elements { get; set; }
    }
}
