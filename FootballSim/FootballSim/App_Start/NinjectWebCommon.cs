using FootballSim.Models;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;

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
            kernel.Bind<ICsvFileLoader>().To<CsvFileLoader>();
            kernel.Bind<IRandomNameRetriever>().To<RandomNameRetriever>();
            kernel.Bind<INameBuilder>().To<NameBuilder>();
            kernel.Bind<IHometownBuilder>().To<HometownBuilder>();
            kernel.Bind<IRandomCollegeRetriever>().To<RandomCollegeRetriever>();
            kernel.Bind<ICollegeBuilder>().To<CollegeBuilder>();
            kernel.Bind<IMeasurablesGenerator>().To<MeasurablesGenerator>();
            kernel.Bind<IPlayerFactory>().To<PlayerFactory>();
            kernel.Bind<IGeneralRatingsGenerator>().To<GeneralRatingsGenerator>();
            RegisterRatingsGenerator(kernel);
            RegisterPositionFactory(kernel);
            RegisterPlayerBuilder(kernel);
            kernel.Bind<IMultiplePlayerBuilder>().To<MultiplePlayerBuilder>();
            kernel.Bind<IDraftClass>().To<DraftClass>();
            kernel.Bind<IDraftClassFactory>().To<DraftClassFactory>();
        }

        private static void RegisterRatingsGenerator(IKernel kernel)
        {
            var generator = new RatingsGenerator(kernel.Get<IGeneralRatingsGenerator>());
            // TODO: add position-specific ratings generator classes here.
            //generator.AddRatingsGenerator(PositionType.Quarterback, new QuarterbackRatingsGenerator());
            kernel.Bind<IRatingsGenerator>().ToConstant(generator);
        }

        private static void RegisterPlayerBuilder(IKernel kernel)
        {
            var builder = new PlayerBuilder(kernel.Get<IPlayerFactory>());
            builder.AddBuildingBlock(kernel.Get<INameBuilder>());
            builder.AddBuildingBlock(kernel.Get<IPositionRepository>());
            builder.AddBuildingBlock(kernel.Get<IRatingsGenerator>());
            builder.AddBuildingBlock(kernel.Get<IHometownBuilder>());
            builder.AddBuildingBlock(kernel.Get<ICollegeBuilder>());
            kernel.Bind<IPlayerBuilder>().ToConstant(builder);
        }

        private static void RegisterPositionFactory(IKernel kernel)
        {
            var factory = new PositionRepository(
                kernel.Get<IRandomNumberService>(),
                kernel.Get<IMeasurablesGenerator>()
            );
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
