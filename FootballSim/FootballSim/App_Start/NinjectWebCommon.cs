using FootballSim.Models;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
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
            DynamicModuleUtility.RegisterModule(typeof (OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof (NinjectHttpModule));
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
            kernel.Bind<IRandomService>().To<RandomService>();
            kernel.Bind<ICsvFileLoader>().To<CsvFileLoader>();
            kernel.Bind<INameCache>().To<NameCache>();
            kernel.Bind<INameBuilder>().To<NameBuilder>();
            kernel.Bind<IHometownCache>().To<HometownCache>();
            kernel.Bind<IHometownBuilder>().To<HometownBuilder>();
            kernel.Bind<ICollegeCache>().To<CollegeCache>();
            kernel.Bind<ICollegeBuilder>().To<CollegeBuilder>();
            kernel.Bind<IMeasurablesBuilder>().To<MeasurablesBuilder>();
            kernel.Bind<IRatingFactory>().To<RatingFactory>();
            kernel.Bind<IRatingGenerator>().To<RatingGenerator>();
            kernel.Bind<IPlayerRatingsBuilder>().To<PlayerRatingsBuilder>();
            kernel.Bind<IPlayerFactory>().To<PlayerFactory>();
            kernel.Bind<IPlayerCaliberFactory>().To<PlayerCaliberFactory>();
            kernel.Bind<IPlayerCaliberBuilder>().To<PlayerCaliberBuilder>();
            RegisterPositionRepository(kernel);
            kernel.Bind<IPositionBuilder>().To<PositionBuilder>();
            RegisterPlayerBuilder(kernel);
            kernel.Bind<IDraftBirthDateGenerator>().To<DraftBirthDateGenerator>();
            kernel.Bind<IDraftClassBuilder>().To<DraftClassBuilder>();
            kernel.Bind<IDraftClass>().To<DraftClass>();
            kernel.Bind<IDraftClassFactory>().To<DraftClassFactory>();
        }

        private static void RegisterPlayerBuilder(IKernel kernel)
        {
            var builder = new PlayerBuilder(kernel.Get<IPlayerFactory>());
            builder.AddBuildingBlock(kernel.Get<IPositionBuilder>());
            builder.AddBuildingBlock(kernel.Get<IPlayerCaliberBuilder>());
            builder.AddBuildingBlock(kernel.Get<IPlayerRatingsBuilder>());
            builder.AddBuildingBlock(kernel.Get<INameBuilder>());
            builder.AddBuildingBlock(kernel.Get<IHometownBuilder>());
            builder.AddBuildingBlock(kernel.Get<ICollegeBuilder>());
            kernel.Bind<IPlayerBuilder>().ToConstant(builder);
        }

        private static void RegisterPositionRepository(IKernel kernel)
        {
            var repository = new PositionRepository(kernel.Get<IRandomService>());
            repository.AddPosition(PositionFactory.Create(PositionType.Quarterback));
            repository.AddPosition(PositionFactory.Create(PositionType.Halfback));
            repository.AddPosition(PositionFactory.Create(PositionType.Fullback));
            repository.AddPosition(PositionFactory.Create(PositionType.WideReceiver));
            repository.AddPosition(PositionFactory.Create(PositionType.TightEnd));
            repository.AddPosition(PositionFactory.Create(PositionType.Tackle));
            repository.AddPosition(PositionFactory.Create(PositionType.Guard));
            repository.AddPosition(PositionFactory.Create(PositionType.Center));
            repository.AddPosition(PositionFactory.Create(PositionType.DefensiveEnd));
            repository.AddPosition(PositionFactory.Create(PositionType.DefensiveTackle));
            repository.AddPosition(PositionFactory.Create(PositionType.OutsideLinebacker));
            repository.AddPosition(PositionFactory.Create(PositionType.InsideLinebacker));
            repository.AddPosition(PositionFactory.Create(PositionType.Cornerback));
            repository.AddPosition(PositionFactory.Create(PositionType.FreeSafety));
            repository.AddPosition(PositionFactory.Create(PositionType.StrongSafety));
            repository.AddPosition(PositionFactory.Create(PositionType.Kicker));
            repository.AddPosition(PositionFactory.Create(PositionType.Punter));
            kernel.Bind<IPositionRepository>().ToConstant(repository);
        }
    }
}
