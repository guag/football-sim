using System;
using System.Web;
using FootballSim.App_Start;
using FootballSim.Draft;
using FootballSim.Models;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using FootballSim.Players;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Syntax;
using Ninject.Web.Common;
using WebActivator;

[assembly: WebActivator.PreApplicationStartMethod(typeof (NinjectWebCommon), "Start")]
[assembly: ApplicationShutdownMethod(typeof (NinjectWebCommon), "Stop")]

namespace FootballSim.App_Start
{
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        /// <summary>
        ///   Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof (OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof (NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        ///   Stops the application.
        /// </summary>
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        /// <summary>
        ///   Creates the kernel that will manage your application.
        /// </summary>
        /// <returns> The created kernel. </returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        ///   Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel"> The kernel. </param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IFootballSimContext>().To<FootballSimContext>();
            kernel.Bind<IPlayerRepository>().To<PlayerRepository>();
            kernel.Bind<IDraftClassRepository>().To<DraftClassRepository>();
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
            RegisterPlayerCalibers(kernel);
            kernel.Bind<IPlayerCaliberBuilder>().To<PlayerCaliberBuilder>();
            RegisterPositionRepository(kernel);
            kernel.Bind<IPositionBuilder>().To<PositionBuilder>();
            RegisterPlayerBuilder(kernel);
            kernel.Bind<IDraftBirthDateGenerator>().To<DraftBirthDateGenerator>();
            kernel.Bind<IDraftClassBuilder>().To<DraftClassBuilder>();
            kernel.Bind<IDraftClassFactory>().To<DraftClassFactory>();
            kernel.Bind<IDraftClassPlayerSorter>().To<DraftClassPlayerSorter>();
            RegisterControllers(kernel);
        }

        private static void RegisterPlayerCalibers(IKernel kernel)
        {
            //var repo = new PlayerCaliberRepository(kernel.Get<IRandomService>());
            //// TODO: add a PlayerCaliberFactory
            //repo.Add<BlueChipCaliber>(new BlueChipCaliber());
            //repo.Add<HighCaliber>(new HighCaliber());
            //repo.Add<AverageCaliber>(new AverageCaliber());
            //repo.Add<LowCaliber>(new LowCaliber());
            //kernel.Bind<IPlayerCaliberRepository>().ToConstant(repo);
            kernel.Bind<IPlayerCaliberRepository>().To<PlayerCaliberRepository>();
        }

        private static void RegisterControllers(IBindingRoot kernel)
        {
            kernel.Bind<IDraftController>().To<DraftController>();
            kernel.Bind<IPlayersController>().To<PlayersController>();
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