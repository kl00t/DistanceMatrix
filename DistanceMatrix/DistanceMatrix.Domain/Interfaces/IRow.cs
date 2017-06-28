namespace DistanceMatrix.Domain.Interfaces
{
    using System.Collections.Generic;
    using Models;

    public interface IRow
    {
        List<Element> Rows { get; set; }
    }
}
