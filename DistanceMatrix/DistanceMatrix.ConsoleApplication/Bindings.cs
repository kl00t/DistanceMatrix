namespace DistanceMatrix.ConsoleApplication
{
    using Connector;
    using Core;
    using Ninject.Modules;

    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IDistanceMatrixEngine>().To<DistanceMatrixEngine>();
            Bind<IDistanceMatrixConnector>().To<DistanceMatrixConnector>();
            Bind<IQueryExecutor>().To<QueryExecutor>();
        }
    }
}
