namespace DistanceMatrix.ConsoleApplication
{
    using System;
    using Domain.Models;
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
            Console.WriteLine("Enter an origin:");
            var origin = Console.ReadLine();

            Console.WriteLine("Enter a destination:");
            var destination = Console.ReadLine();

            //Console.WriteLine("Enter a transport mode:");
            //var mode = (Mode)Enum.Parse(typeof(Mode), Console.ReadLine());

            //Console.WriteLine("Imperial or Metric:");
            //var units = (Units)Enum.Parse(typeof(Units), Console.ReadLine());

            var serviceClient = new DistanceMatrixService.DistanceMatrixServiceClient();
            var response = serviceClient.DistanceMatrix(new DistanceMatrixRequest
            {
                Origins = origin,
                Destinations = destination,
                Mode = Mode.Driving,
                Units = Units.Metric
            });

            if (response.IsSuccessful)
            {
                Console.WriteLine("########## Result ##########");
                if (response.Response.Status == Status.Ok)
                {
                    foreach (var originAddress in response.Response.OriginAddresses)
                    {
                        Console.WriteLine("Origin:" + originAddress);
                    }
                    foreach (var destinationAddress in response.Response.DestinationAddresses)
                    {
                        Console.WriteLine("Destination:" + destinationAddress);
                    }

                    foreach (var row in response.Response.Rows)
                    {
                        foreach (var element in row.Elements)
                        {
                            if (element.Status == ElementStatus.Ok)
                            {
                                Console.WriteLine("Distance: {0} | Duration: {1}", element.Distance.Text, element.Duration.Text);
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.Read();
        }
    }
}