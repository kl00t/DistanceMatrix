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

			Console.WriteLine("Enter a mode of travel:");
			Console.WriteLine("(D) Driving | (W) Walking | (B) Bicycling");
			var modeInput = Console.ReadLine();
			Mode mode;
			switch (modeInput.ToString().ToUpper())
			{
				case "D":
					mode = Mode.Driving;
					break;
				case "W":
					mode = Mode.Walking;
					break;
				case "B":
					mode = Mode.Bicycling;
					break;
				default:
					mode = Mode.Walking;
					break;
			}

			Console.WriteLine("How would you like results displayed?");
			Console.WriteLine("(I) Imperial or (M) Metric:");
			var unitInput = Console.ReadLine();
			Units units;
			switch (unitInput.ToString().ToUpper())
			{
				case "I":
					units = Units.Imperial;
					break;
				case "M":
					units = Units.Metric;
					break;
				default:
					units = Units.Metric;
					break;
			}

			var serviceClient = new GoogleApiService.GoogleApiServiceClient();

			////var directionsResponse = serviceClient.Directions(new DirectionsRequest
			////{
			////	Origin = origins,
			////	Destination = destinations,
			////	Mode = Mode.Driving
			////});

			var distanceMatrixResponse = serviceClient.DistanceMatrix(new DistanceMatrixRequest
            {
                Origins = origins,
                Destinations = destinations,
                Mode = mode,
                Units = units
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