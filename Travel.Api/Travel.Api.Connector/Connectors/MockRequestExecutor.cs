namespace Travel.Api.Connector.Connectors
{
    using Interfaces;

    public class MockRequestExecutor : IApiRequestExecutor
    {
		public string ExecuteRequest(string address)
		{
			return Example.Test1;
		}
	}
}