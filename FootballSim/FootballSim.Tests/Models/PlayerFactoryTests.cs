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
                null,
                Mock<IMeasurablesGenerator>().Object
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
                Mock<IPositionRepository>().Object,
                Mock<IMeasurablesGenerator>().Object
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
                Mock<IPositionRepository>().Object,
                Mock<IMeasurablesGenerator>().Object
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
                Mock<IPositionRepository>().Object,
                Mock<IMeasurablesGenerator>().Object
            );
            var hometown = new Location { City = "Greenbow", State = "AL" };
            homeGen.Setup(h => h.GetRandomHometown()).Returns(hometown);
            var player = sut.Create();

            homeGen.Verify(n => n.GetRandomHometown());
            Assert.That(player.Hometown, Is.EqualTo(hometown));
        }

        [Test]
        public void Create_Player_With_A_Random_College()
        {
            var college = Mock<ICollegeRepository>();
            var sut = new PlayerFactory(
                Mock<INameGeneratorService>().Object,
                Mock<IHometownRepository>().Object,
                college.Object,
                Mock<IPositionRepository>().Object,
                Mock<IMeasurablesGenerator>().Object
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
                positionFactory.Object,
                Mock<IMeasurablesGenerator>().Object
            );
            var position = Mock<IPosition>();
            positionFactory.Setup(p => p.GetRandomPosition()).Returns(position.Object);
            var player = sut.Create();

            positionFactory.Verify(p => p.GetRandomPosition());
            Assert.That(player.Position, Is.EqualTo(position.Object));
        }

        [Test]
        public void Create_Player_With_Measurables_For_A_Specified_Position()
        {
            var measurablesGen = Mock<IMeasurablesGenerator>();
            var sut = new PlayerFactory(
                Mock<INameGeneratorService>().Object,
                Mock<IHometownRepository>().Object,
                Mock<ICollegeRepository>().Object,
                null,
                measurablesGen.Object
            );
            var qb = new Quarterback();
            measurablesGen.Setup(m => m.GetRandomMeasurables(qb))
                .Returns(new Measurables { Height = 72, Weight = 200 });
            var player = sut.Create(qb);

            measurablesGen.Verify(m => m.GetRandomMeasurables(qb));
            Assert.That(player.Measurables.Height, Is.EqualTo(72));
            Assert.That(player.Measurables.Weight, Is.EqualTo(200));
        }

        [Test]
        public void Create_Player_With_Measurables_For_A_Random_Position()
        {
            var measurablesGen = Mock<IMeasurablesGenerator>();
            var positionFactory = Mock<IPositionRepository>();
            var sut = new PlayerFactory(
                Mock<INameGeneratorService>().Object,
                Mock<IHometownRepository>().Object,
                Mock<ICollegeRepository>().Object,
                positionFactory.Object,
                measurablesGen.Object
            );
            var qb = new Quarterback();
            positionFactory.Setup(p => p.GetRandomPosition()).Returns(qb);
            measurablesGen.Setup(m => m.GetRandomMeasurables(qb))
                .Returns(new Measurables { Height = 72, Weight = 200 });
            var player = sut.Create();

            measurablesGen.Verify(m => m.GetRandomMeasurables(qb));
            positionFactory.Verify(p => p.GetRandomPosition());
            Assert.That(player.Measurables.Height, Is.EqualTo(72));
            Assert.That(player.Measurables.Weight, Is.EqualTo(200));
        }
    }
}