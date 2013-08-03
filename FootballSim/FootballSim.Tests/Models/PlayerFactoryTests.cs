using FootballSim.Models;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class PlayerFactoryTests : BaseTestFixture
    {
        [Test]
        public void Create_Player_With_A_Given_Position()
        {
            var sut = new PlayerFactory(
                Mock<INameGeneratorService>().Object,
                Mock<IHometownGeneratorService>().Object
            );
            var position = Mock<IPosition>();
            var player = sut.Create(position.Object);

            Assert.That(player, Is.Not.Null);
            Assert.That(player.Position, Is.EqualTo(position.Object));
        }

        [Test]
        public void Create_Player_With_A_Given_Team()
        {
            var sut = new PlayerFactory(
                Mock<INameGeneratorService>().Object,
                Mock<IHometownGeneratorService>().Object
            );
            var team = Mock<ITeam>();
            var player = sut.Create(null, team.Object);

            Assert.That(player.Team, Is.EqualTo(team.Object));
        }

        [Test]
        public void Create_Player_With_A_Random_Name()
        {
            var nameGen = Mock<INameGeneratorService>();
            var sut = new PlayerFactory(
                nameGen.Object,
                Mock<IHometownGeneratorService>().Object
            );
            nameGen.Setup(n => n.GetRandomFirstName()).Returns("Gary");
            nameGen.Setup(n => n.GetRandomLastName()).Returns("Guagliardo");
            var player = sut.Create(null);

            nameGen.Verify(n => n.GetRandomFirstName());
            nameGen.Verify(n => n.GetRandomLastName());
            Assert.That(player.FirstName, Is.EqualTo("Gary"));
            Assert.That(player.LastName, Is.EqualTo("Guagliardo"));
        }

        [Test]
        public void Create_Player_With_A_Random_Hometown()
        {
            var homeGen = Mock<IHometownGeneratorService>();
            var sut = new PlayerFactory(
                Mock<INameGeneratorService>().Object,
                homeGen.Object
            );
            var hometown = Mock<ILocation>();
            homeGen.Setup(h => h.GetRandomHometown()).Returns(hometown.Object);
            var player = sut.Create(null);

            homeGen.Verify(n => n.GetRandomHometown());
            Assert.That(player.Hometown, Is.EqualTo(hometown.Object));
        }
    }
}