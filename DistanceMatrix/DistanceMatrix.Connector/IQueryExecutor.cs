namespace DistanceMatrix.Connector
{
    public interface IQueryExecutor
    {
        string Execute(string address, bool useSSL = false);
    }
}