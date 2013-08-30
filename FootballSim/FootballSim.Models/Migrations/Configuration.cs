using System.Data.Entity.Migrations;

namespace FootballSim.Models.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FootballSimContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FootballSimContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Database.ExecuteSqlCommand(
                "CREATE UNIQUE INDEX IX_PlayerCaliber_Discriminator ON PlayerCalibers (Discriminator)");
        }
    }
}