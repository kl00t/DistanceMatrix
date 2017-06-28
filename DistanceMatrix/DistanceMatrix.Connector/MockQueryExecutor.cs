namespace DistanceMatrix.Connector
{
	public class MockQueryExecutor : IQueryExecutor
    {
		public string Execute(string address)
		{
			return Example.Test1;
		}
	}
}
