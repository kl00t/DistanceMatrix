namespace DistanceMatrix.Kernel
{
    using Connector;
    using Core;
    using Core.Logging;
    using Ninject.Modules;

    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<Logger>();
            Bind<IDistanceMatrixEngine>().To<DistanceMatrixEngine>();
            Bind<IDistanceMatrixConnector>().To<DistanceMatrixConnector>();
            //Bind<IQueryExecutor>().To<QueryExecutor>();
            Bind<IQueryExecutor>().To<MockQueryExecutor>();
        }
    }
}