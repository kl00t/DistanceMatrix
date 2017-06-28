namespace DistanceMatrix.Connector
{
	public class MockQueryExecutor : IQueryExecutor
    {
		public string Execute(string address, bool useSSL = false)
		{
			return Example.Test1;
		}
	}
}
