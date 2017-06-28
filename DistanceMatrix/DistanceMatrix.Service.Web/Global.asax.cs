namespace DistanceMatrix.Service.Web
{
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
    }
}