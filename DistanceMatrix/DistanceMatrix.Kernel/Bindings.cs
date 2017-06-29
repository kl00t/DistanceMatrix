namespace DistanceMatrix.Kernel
{
    using Connector;
    using Connector.Connectors;
    using Connector.Interfaces;
    using Core;
    using Core.Logging;
    using Data;
    using Ninject.Modules;

    public class Bindings : NinjectModule
    {
        public override void Load()
        {
			Bind<ILogger>().To<Logger>();
			Bind<IDistanceMatrixEngine>().To<DistanceMatrixEngine>();
			Bind<IDistanceMatrixConnector>().To<DistanceMatrixConnector>();
            Bind<IDirectionsConnector>().To<DirectionsConnector>();

            Bind<IApiRequestExecutor>().To<ApiRequestExecutor>();
			//Bind<IQueryExecutor>().To<MockQueryExecutor>();

			Bind<IRequestHistoryRepository>().ToConstant(new MockRequestHistoryRepository());
		}
    }
}