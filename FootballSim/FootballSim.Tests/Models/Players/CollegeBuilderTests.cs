using FootballSim.Models.Players;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Players
{
    [TestFixture]
    public class CollegeBuilderTests : BaseTestFixture
    {
        [Test]
        public void Build_Sets_College_On_Player()
        {
            var colleges = Mock<ICollegeCache>();
            var sut = new CollegeBuilder(colleges.Object);
            colleges.Setup(c => c.GetRandomCollege()).Returns("SBU");
            var player = new Player();

            sut.Build(player);
            colleges.Verify(c => c.GetRandomCollege());
            Assert.That(player.College, Is.EqualTo("SBU"));
        }
    }
}