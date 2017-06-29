namespace DistanceMatrix.Connector
{
	public class MockRequestExecutor : IApiRequestExecutor
    {
		public string ExecuteRequest(string address)
		{
			return Example.Test1;
		}
	}
}
