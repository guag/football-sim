#region

using FootballSim.Models.Players;
using NUnit.Framework;

#endregion

namespace FootballSim.Models.Tests.Players
{
    [TestFixture]
    public class HometownBuilderTests : BaseTestFixture
    {
        [Test]
        public void Build_Sets_Random_Hometown_On_Player()
        {
            var cache = StrictMock<IHometownCache>();
            var sut = new HometownBuilder(cache.Object);
            var player = new Player();
            var hometown = new Location();
            cache.Setup(c => c.GetRandomHometown()).Returns(hometown);

            sut.Build(player);
            cache.Verify(c => c.GetRandomHometown());
            Assert.That(player.Hometown, Is.EqualTo(hometown));
        }
    }
}