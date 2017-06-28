using System;

namespace DistanceMatrix.ConsoleApplication
{

    using System.Reflection;
    using Connector;
    using Core;
    using Domain.Models;
    using Ninject;

    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var distanceMatrixConnector = kernel.Get<IDistanceMatrixConnector>();

            var distanceMatrixEngine = new DistanceMatrixEngine(distanceMatrixConnector);

            var response = distanceMatrixEngine.Calculate(new DistanceMatrixRequest
            {
                Origin = "Washington, D.C., DC, USA",
                Destination = "New York City, New York, USA"
            });

            Console.ReadLine();
        }
    }
}
