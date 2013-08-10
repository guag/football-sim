using FootballSim.Models;
using FootballSim.Models.Positions;
using Moq;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class MultiplePlayerBuilderTests : BaseTestFixture
    {
        [Test]
        public void Create_1000_Players_Of_A_Certain_Position()
        {
            var playerFactory = Mock<IPlayerBuilder>();
            var sut = new MultiplePlayerBuilder(
                playerFactory.Object
            );
            var position = Mock<IPosition>();
            playerFactory.Setup(p => p.Build(position.Object))
                .Returns(It.IsAny<Player>());

            var result = sut.Build(1000, position.Object);
            playerFactory.Verify(p => p.Build(position.Object), Times.Exactly(1000));
            Assert.That(result, Is.Not.Empty);
        }

        [Test]
        public void Create_500_Players_Of_A_Certain_Position()
        {
            var playerFactory = Mock<IPlayerBuilder>();
            var sut = new MultiplePlayerBuilder(
                playerFactory.Object
            );
            var position = Mock<IPosition>();
            var team = Mock<ITeam>();
            playerFactory.Setup(p => p.Build(position.Object))
                .Returns(It.IsAny<Player>());

            var result = sut.Build(500, position.Object);
            playerFactory.Verify(p => p.Build(position.Object), Times.Exactly(500));
            Assert.That(result, Is.Not.Empty);
        }
    }
}
