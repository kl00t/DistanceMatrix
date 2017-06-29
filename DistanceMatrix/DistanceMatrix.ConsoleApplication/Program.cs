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
                    Console.WriteLine();
                    var originAddress = StringHelper.ConvertListToString(" | ", response.Response.OriginAddresses);
                    Console.WriteLine("Origin: " + originAddress);
                    var destinationAddress = StringHelper.ConvertListToString(" | ", response.Response.DestinationAddresses);
                    Console.WriteLine("Destination: " + destinationAddress);

                    Console.WriteLine();
                    foreach (var element in response.Response.Rows.SelectMany(row => row.Elements.Where(element => element.Status == ElementStatus.Ok)))
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