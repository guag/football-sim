using System.Collections.Generic;
using FootballSim.Models;
using FootballSim.Models.Positions;
using Moq;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class MultiplePlayerFactoryTests : BaseTestFixture
    {
        [Test]
        public void Create_1000_Players_Of_A_Certain_Position_And_Team()
        {
            var playerFactory = Mock<IPlayerFactory>();
            var sut = new MultiplePlayerFactory(
                playerFactory.Object
            );
            var position = Mock<IPosition>();
            var team = Mock<ITeam>();
            playerFactory.Setup(p => p.Create(position.Object, team.Object))
                .Returns(It.IsAny<Player>());

            var result = sut.Create(1000, position.Object, team.Object);
            playerFactory.Verify(p => p.Create(position.Object, team.Object), Times.Exactly(1000));
            Assert.That(result, Is.Not.Empty);
        }
    }
}
