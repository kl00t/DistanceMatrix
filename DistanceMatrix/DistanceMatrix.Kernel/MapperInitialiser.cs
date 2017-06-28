namespace DistanceMatrix.Kernel
{
    using System;
    using System.Linq;

    using AutoMapper;
    using Mappings;

    /// <summary>
    /// Mapper Initialiser.
    /// </summary>
    public class MapperInitialiser
    {
        /// <summary>
        /// The setup.
        /// </summary>
        public static void Setup()
        {
            Mapper.Initialize(x => GetConfiguration(Mapper.Configuration));
            Mapper.AssertConfigurationIsValid();
        }

        /// <summary>
        /// The get configuration.
        /// </summary>
        /// <param name="configuration">
        /// The configuration.
        /// </param>
        private static void GetConfiguration(IConfiguration configuration)
        {
            var profiles = typeof(DistanceMatrixMappings).Assembly.GetTypes().Where(x => typeof(Profile).IsAssignableFrom(x));
            foreach (var profile in profiles)
            {
                configuration.AddProfile(Activator.CreateInstance(profile) as Profile);
            }
        }
    }
}
