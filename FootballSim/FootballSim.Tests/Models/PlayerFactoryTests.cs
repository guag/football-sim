using FootballSim.Models;
using FootballSim.Models.Positions;
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
                Mock<IHometownRepository>().Object,
                Mock<ICollegeRepository>().Object,
                Mock<IPositionRepository>().Object
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
                Mock<IHometownRepository>().Object,
                Mock<ICollegeRepository>().Object,
                Mock<IPositionRepository>().Object
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
                Mock<IHometownRepository>().Object,
                Mock<ICollegeRepository>().Object,
                Mock<IPositionRepository>().Object
            );
            nameGen.Setup(n => n.GetRandomFirstName()).Returns("Gary");
            nameGen.Setup(n => n.GetRandomLastName()).Returns("Guagliardo");
            var player = sut.Create();

            nameGen.Verify(n => n.GetRandomFirstName());
            nameGen.Verify(n => n.GetRandomLastName());
            Assert.That(player.FirstName, Is.EqualTo("Gary"));
            Assert.That(player.LastName, Is.EqualTo("Guagliardo"));
        }

        [Test]
        public void Create_Player_With_A_Random_Hometown()
        {
            var homeGen = Mock<IHometownRepository>();
            var sut = new PlayerFactory(
                Mock<INameGeneratorService>().Object,
                homeGen.Object,
                Mock<ICollegeRepository>().Object,
                Mock<IPositionRepository>().Object
            );
            var hometown = Mock<ILocation>();
            homeGen.Setup(h => h.GetRandomHometown()).Returns(hometown.Object);
            var player = sut.Create();

            homeGen.Verify(n => n.GetRandomHometown());
            Assert.That(player.Hometown, Is.EqualTo(hometown.Object));
        }

        [Test]
        public void Create_Player_With_A_Random_College()
        {
            var college = Mock<ICollegeRepository>();
            var sut = new PlayerFactory(
                Mock<INameGeneratorService>().Object,
                Mock<IHometownRepository>().Object,
                college.Object,
                Mock<IPositionRepository>().Object
            );
            college.Setup(c => c.GetRandomCollege()).Returns("SBU");
            var player = sut.Create();

            college.Verify(c => c.GetRandomCollege());
            Assert.That(player.College, Is.EqualTo("SBU"));
        }

        [Test]
        public void Create_Player_With_A_Generated_Position_Because_None_Was_Provided()
        {
            var positionFactory = Mock<IPositionRepository>();
            var sut = new PlayerFactory(
                Mock<INameGeneratorService>().Object,
                Mock<IHometownRepository>().Object,
                Mock<ICollegeRepository>().Object,
                positionFactory.Object
            );
            var position = Mock<IPosition>();
            positionFactory.Setup(p => p.GetRandomPosition()).Returns(position.Object);
            var player = sut.Create();

            positionFactory.Verify(p => p.GetRandomPosition());
            Assert.That(player.Position, Is.EqualTo(position.Object));
        }
    }
}