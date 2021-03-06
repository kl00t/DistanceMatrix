﻿namespace Travel.Api.Kernel
{

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
			Bind<ITravelApiEngine>().To<TravelApiEngine>();
			Bind<IDistanceMatrixConnector>().To<DistanceMatrixConnector>();
            Bind<IDirectionsConnector>().To<DirectionsConnector>();
            Bind<IElevationConnector>().To<ElevationConnector>();
            Bind<ITimezoneConnector>().To<TimezoneConnector>();
            Bind<IGeocodeConnector>().To<GeocodeConnector>();
            Bind<IGeolocationConnector>().To<GeolocationConnector>();

            Bind<IApiRequestExecutor>().To<ApiRequestExecutor>();
			//Bind<IQueryExecutor>().To<MockQueryExecutor>();

			Bind<IRequestHistoryRepository>().ToConstant(new MockRequestHistoryRepository());
		}
    }
}