using FootballSim.Models.Players;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Players
{
    [TestFixture]
    public class PlayerCaliberBuilderTests : BaseTestFixture
    {
        [Test]
        public void Build_Sets_Caliber()
        {
            var caliberFactory = StrictMock<IPlayerCaliberRepository>();
            var sut = new PlayerCaliberBuilder(caliberFactory.Object);
            var player = new Player();
            var caliber = new AverageCaliber();
            caliberFactory.Setup(c => c.GetRandom()).Returns(caliber);

            sut.Build(player);
            caliberFactory.Verify(c => c.GetRandom());
            Assert.That(player.Caliber, Is.EqualTo(caliber));
        }
    }
}