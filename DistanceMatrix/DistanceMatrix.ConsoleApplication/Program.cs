namespace DistanceMatrix.ConsoleApplication
{
    using System;
    using System.Linq;
    using Core.Helpers;
    using Domain.Models;
    using Domain.Enums;

    public class Program
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an origin:");
            var origins = Console.ReadLine();

            Console.WriteLine("Enter a destination:");
            var destinations = Console.ReadLine();

            //Console.WriteLine("Enter a transport mode:");
            //var mode = (Mode)Enum.Parse(typeof(Mode), Console.ReadLine());

            //Console.WriteLine("Imperial or Metric:");
            //var units = (Units)Enum.Parse(typeof(Units), Console.ReadLine());

            var serviceClient = new GoogleApiService.GoogleApiServiceClient();

			var directionsResponse = serviceClient.Directions(new DirectionsRequest
			{
				Origin = origins,
				Destination = destinations,
				Mode = Mode.Driving
			});

			var distanceMatrixResponse = serviceClient.DistanceMatrix(new DistanceMatrixRequest
            {
                Origins = origins,
                Destinations = destinations,
                Mode = Mode.Driving,
                Units = Units.Metric
            });

            if (distanceMatrixResponse.IsSuccessful)
            {
                Console.WriteLine("########## Result ##########");
                if (distanceMatrixResponse.Response.Status == Status.Ok)
                {
                    Console.WriteLine();
                    var originAddress = StringHelper.ConvertListToString(" | ", distanceMatrixResponse.Response.OriginAddresses);
                    Console.WriteLine("Origin: " + originAddress);
                    var destinationAddress = StringHelper.ConvertListToString(" | ", distanceMatrixResponse.Response.DestinationAddresses);
                    Console.WriteLine("Destination: " + destinationAddress);

                    Console.WriteLine();
                    foreach (var element in distanceMatrixResponse.Response.Rows.SelectMany(row => row.Elements.Where(element => element.Status == ElementStatus.Ok)))
                    {
                        Console.WriteLine("Distance: {0} | Duration: {1}", element.Distance.Text, element.Duration.Text);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to exit.");
            Console.Read();
        }
    }
}