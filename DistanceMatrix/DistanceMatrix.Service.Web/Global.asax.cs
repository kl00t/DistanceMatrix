namespace DistanceMatrix.Service.Web
{

    using Kernel;
    using Ninject;
    using Ninject.Web.Common;

    public class Global : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();
            try
            {
                kernel.Load("*.Kernel.dll");
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// The on application started. Initialise AutoMapper and check the Automapper mappings.
        /// </summary>
        protected override void OnApplicationStarted()
        {
            MapperInitialiser.Setup();
        }
    }
}