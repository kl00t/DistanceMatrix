﻿namespace DistanceMatrix.ConsoleApplication
{
    using System;
    using System.Reflection;
    using Connector;
    using Core;
    using Core.Logging;
    using Data;
    using Domain.Models;
    using Kernel;
    using Ninject;
    using Domain.Enums;

	public class Program
    {
        /// <summary>
        /// Gets or sets the kernel.
        /// </summary>
        public static IKernel Kernel { get; set; }

        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var logger = kernel.Get<ILogger>();
            var engine = kernel.Get<IDistanceMatrixEngine>();
            var connector = kernel.Get<IDistanceMatrixConnector>();
            var executor = kernel.Get<IQueryExecutor>();
            var requestHistory = kernel.Get<IRequestHistoryRepository>();

            MapperInitialiser.Setup();
                
            //Console.WriteLine("Enter an origin:");
            //var origin = Console.ReadLine();

            //Console.WriteLine("Enter a destination:");
            //var destination = Console.ReadLine();

			//Console.WriteLine("Enter a transport mode:");
			//var mode = (Mode)Enum.Parse(typeof(Mode), Console.ReadLine());

			//Console.WriteLine("Imperial or Metric:");
			//var units = (Units)Enum.Parse(typeof(Units), Console.ReadLine());

            var response = engine.DistanceMatrix(new DistanceMatrixRequest
            {
                Origin = "manchester",
                Destination = "london",
				Mode =  Mode.Driving,
				Units = Units.Metric
            });

			Console.WriteLine("########## Result ##########");

			if (response.Status == Status.Ok)
			{
				Console.WriteLine("Origin:");
				foreach (var originAddress in response.OriginAddresses)
				{
					Console.WriteLine(originAddress);
				}
				Console.WriteLine("Destination:");
				foreach (var destinationAddress in response.DestinationAddresses)
				{
					Console.WriteLine(destinationAddress);
				}
				foreach (var row in response.Rows)
				{
					foreach(var element in row.Elements)
					{
						if (element.Status == ElementStatus.Ok)
						{
							Console.WriteLine(string.Format("Distance: {0} - Duration: {1}", element.Distance.Text, element.Duration.Text));
						}
					}
				}
			}

            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }
    }
}