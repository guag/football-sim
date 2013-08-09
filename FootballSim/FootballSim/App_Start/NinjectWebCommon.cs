using FootballSim.Models;
using FootballSim.Models.Positions;

[assembly: WebActivator.PreApplicationStartMethod(typeof(FootballSim.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(FootballSim.App_Start.NinjectWebCommon), "Stop")]

namespace FootballSim.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IPasserRatingService>().To<PasserRatingService>();
            kernel.Bind<IRandomNumberService>().To<RandomNumberService>();
            kernel.Bind<INameGeneratorService>().To<NameGeneratorService>();
            kernel.Bind<IHometownRepository>().To<HometownRepository>();
            kernel.Bind<ICollegeRepository>().To<CollegeRepository>();
            RegisterPositionFactory(kernel);
            kernel.Bind<IMeasurablesGenerator>().To<MeasurablesGenerator>();
            kernel.Bind<IPlayerFactory>().To<PlayerFactory>();
            kernel.Bind<IMultiplePlayerFactory>().To<MultiplePlayerFactory>();
            kernel.Bind<IDraftClass>().To<DraftClass>();
            kernel.Bind<IDraftClassFactory>().To<DraftClassFactory>();
        }

        private static void RegisterPositionFactory(IKernel kernel)
        {
            var factory = new PositionRepository(kernel.Get<IRandomNumberService>());
            factory.AddPosition(new Quarterback());
            factory.AddPosition(new Halfback());
            factory.AddPosition(new WideReceiver());
            factory.AddPosition(new TightEnd());
            factory.AddPosition(new Tackle());
            factory.AddPosition(new Guard());
            factory.AddPosition(new Center());
            kernel.Bind<IPositionRepository>().ToConstant(factory);
        }
    }
}
