using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Players
{
    [TestFixture]
    public class PlayerOutlookBuilderTests : BaseTestFixture
    {
        [Test]
        public void Build_Sets_Caliber()
        {
            var caliber = StrictMock<IOutlookGenerator>();
            var sut = new PlayerOutlookBuilder(caliber.Object);
            var player = new Player();
            caliber.Setup(c => c.GenerateCaliber()).Returns(Caliber.Average);

            sut.Build(player);
            caliber.Verify(c => c.GenerateCaliber());
            Assert.That(player.Caliber, Is.EqualTo(Caliber.Average));
        }
        
    }
}