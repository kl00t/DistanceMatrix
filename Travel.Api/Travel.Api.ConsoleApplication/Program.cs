namespace Travel.Api.ConsoleApplication
{
    using System;
    using System.Linq;
    using Core.Helpers;
    using Domain.Enums;
    using Domain.Models;

    public class Program
    {
        static void Main()
        {
            Start();
        }

        private static void Start()
        {
            while (true)
            {
                Console.WriteLine("Enter API Request:");
                Console.WriteLine("(D) Directions | (DM) Distance Matrix | (E) Elevation | (T) Timezone | (G) Geocode | (RG) Reverse Geocode");
                var apiInput = Console.ReadLine();

                if (string.IsNullOrEmpty(apiInput))
                {
                    throw new ArgumentNullException();
                }

                switch (apiInput.ToUpper())
                {
                    case "D":
                        Directions();
                        break;
                    case "DM":
                        DistanceMatrix();
                        break;
                    case "E":
                        Elevation();
                        break;
                    case "T":
                        Timezone();
                        break;
                    case "G":
                        Geocode();
                        break;
                    case "RG":
                        ReverseGeocode();
                        break;
                    default:
                        Console.WriteLine("This is a invalid menu selection.");
                        continue;
                }
                break;
            }
        }

        private static void Directions()
        {
            Console.WriteLine("Enter an origin:");
            var origin = Console.ReadLine();

            Console.WriteLine("Enter a destination:");
            var destination = Console.ReadLine();

            var serviceClient = new TravelApiService.TravelApiServiceClient();

            var directionsResponse = serviceClient.Directions(new DirectionsRequest
            {
                Origin = origin,
                Destination = destination,
                Mode = Mode.Driving
            });

            if (directionsResponse.IsSuccessful)
            {
                Console.WriteLine("########## Result ##########");
                if (directionsResponse.Response.Status == Status.Ok)
                {
                    Console.WriteLine();
                    // TODO: Display results.
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to exit.");
            Console.Read();
        }

        private static void DistanceMatrix()
        {
            Console.WriteLine("Enter origin(s):");
            var origins = Console.ReadLine();

            Console.WriteLine("Enter destination(s):");
            var destinations = Console.ReadLine();

            Console.WriteLine("Enter a mode of travel:");
            Console.WriteLine("(D) Driving | (W) Walking | (B) Bicycling");
            var modeInput = Console.ReadLine();
            Mode mode;

            if (string.IsNullOrEmpty(modeInput))
            {
                throw new ArgumentNullException();
            }

            switch (modeInput.ToUpper())
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

            if (string.IsNullOrEmpty(unitInput))
            {
                throw new ArgumentNullException();
            }

            Units units;
            switch (unitInput.ToUpper())
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

            var serviceClient = new TravelApiService.TravelApiServiceClient();

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

        private static void Elevation()
        {
            Console.WriteLine("Enter a Latitude:");
            var latitude = Console.ReadLine();

            Console.WriteLine("Enter a Longitude:");
            var longitude = Console.ReadLine();

            var serviceClient = new TravelApiService.TravelApiServiceClient();

            var elevationResponse = serviceClient.Elevation(new ElevationRequest
            {
                Location = new Location
                {
                    Latitude = latitude,
                    Longitude = longitude,
                }
            });

            if (elevationResponse.IsSuccessful)
            {
                Console.WriteLine("########## Result ##########");
                if (elevationResponse.Response.Status == Status.Ok)
                {
                    Console.WriteLine();
                    foreach (var result in elevationResponse.Response.Results)
                    {
                        Console.WriteLine("Latitude: {0} | Longitude: {1} | Resolution: {2}", result.Location.Latitude, result.Location.Longitude, result.Resolution);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to exit.");
            Console.Read();
        }

        private static void Timezone()
        {
            Console.WriteLine("Enter a Latitude:");
            var latitude = Console.ReadLine();

            Console.WriteLine("Enter a Longitude:");
            var longitude = Console.ReadLine();

            Console.WriteLine("Enter a Language code:");
            var languageCode = Console.ReadLine();

            var serviceClient = new TravelApiService.TravelApiServiceClient();

            var timeZoneRequest = new TimezoneRequest
            {
                Location = new Location
                {
                    Latitude = latitude,
                    Longitude = longitude,
                },
                Timestamp = "1331161200"
            };

            if (!string.IsNullOrEmpty(languageCode))
            {
                timeZoneRequest.Language = new Language
                {
                    Code = languageCode
                };
            }

            var timezoneResponse = serviceClient.Timezone(timeZoneRequest);

            if (timezoneResponse.IsSuccessful)
            {
                Console.WriteLine("########## Result ##########");
                if (timezoneResponse.Response.Status == Status.Ok)
                {
                    Console.WriteLine("DstOffset: {0} | RawOffset: {1} | TimeZoneId: {2}| TimeZoneName: {3} |", 
                        timezoneResponse.Response.DstOffset, 
                        timezoneResponse.Response.RawOffset,
                        timezoneResponse.Response.TimeZoneId,
                        timezoneResponse.Response.TimeZoneName);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to exit.");
            Console.Read();
        }

        private static void ReverseGeocode()
        {
            Console.WriteLine("Enter a Latitude:");
            var latitude = Console.ReadLine();

            Console.WriteLine("Enter a Longitude:");
            var longitude = Console.ReadLine();

            var serviceClient = new TravelApiService.TravelApiServiceClient();

            var reverseGeocodeRequest = new ReverseGeocodeRequest
            {
                Location = new Location
                {
                    Latitude = latitude,
                    Longitude = longitude
                }
            };

            var reverseGeocodeResponse = serviceClient.ReverseGeocode(reverseGeocodeRequest);

            if (reverseGeocodeResponse.IsSuccessful)
            {
                Console.WriteLine("########## Result ##########");
                if (reverseGeocodeResponse.Response.Status == Status.Ok)
                {
                    Console.WriteLine();
                    foreach (var result in reverseGeocodeResponse.Response.Results)
                    {
                        Console.WriteLine("PlaceId: {0} | Formatted Address: {1}",
                            result.PlaceId,
                            result.FormattedAddress);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to exit.");
            Console.Read();
        }

        private static void Geocode()
        {
            Console.WriteLine("Enter an address:");
            var address = Console.ReadLine();

            Console.WriteLine("Enter a Language code:");
            var languageCode = Console.ReadLine();

            var serviceClient = new TravelApiService.TravelApiServiceClient();

            var geocodeRequest = new GeocodeRequest
            {
                Address = address
            };

            if (!string.IsNullOrEmpty(languageCode))
            {
                geocodeRequest.Language = new Language
                {
                    Code = languageCode
                };
            }

            var geocodeResponse = serviceClient.Geocode(geocodeRequest);

            if (geocodeResponse.IsSuccessful)
            {
                Console.WriteLine("########## Result ##########");
                if (geocodeResponse.Response.Status == Status.Ok)
                {
                    Console.WriteLine();
                    foreach (var result in geocodeResponse.Response.Results)
                    {
                        Console.WriteLine("PlaceId: {0} | Formatted Address: {1}",
                            result.PlaceId,
                            result.FormattedAddress);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press enter key to exit.");
            Console.Read();
        }
    }
}