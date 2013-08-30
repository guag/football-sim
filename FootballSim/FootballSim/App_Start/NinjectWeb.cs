using FootballSim.App_Start;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject.Web;
using WebActivator;

[assembly: PreApplicationStartMethod(typeof (NinjectWeb), "Start")]

namespace FootballSim.App_Start
{
    public static class NinjectWeb
    {
        /// <summary>
        ///   Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof (NinjectHttpModule));
        }
    }
}