namespace DistanceMatrix.Kernel
{
    using System;
    using Ninject;
    using NUnit.Framework;

    /// <summary>
    /// The startup.
    /// </summary>
    [SetUpFixture]
    public class Startup
    {
        /// <summary>
        /// Gets or sets the kernel.
        /// </summary>
        public static IKernel Kernel { get; set; }

        /// <summary>
        /// The setup.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            Kernel = new StandardKernel();
            Kernel.Load("*.kernel.dll");

            MapperInitialiser.Setup();

            Console.WriteLine("Completed Startup...");
        }
    }
}
