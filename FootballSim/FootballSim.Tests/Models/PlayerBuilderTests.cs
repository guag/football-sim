using FootballSim.Models;
using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class PlayerBuilderTests : BaseTestFixture
    {
        [Test]
        public void Build_Player_With_2_Building_Blocks()
        {
            var factory = StrictMock<IPlayerFactory>();
            var sut = new PlayerBuilder(factory.Object);
            var block1 = StrictMock<IPlayerBuildingBlock>();
            var block2 = StrictMock<IPlayerBuildingBlock>();
            sut.AddBuildingBlock(block1.Object);
            sut.AddBuildingBlock(block2.Object);

            var player = new Player();
            var position = new Quarterback();
            factory.Setup(f => f.Create()).Returns(player);
            block1.Setup(b => b.Build(player, position));
            block2.Setup(b => b.Build(player, position));

            var result = sut.Build(position);
            Assert.That(result, Is.EqualTo(player));
        }

        [Test]
        public void Build_Player_With_1_Building_Block()
        {
            var factory = StrictMock<IPlayerFactory>();
            var sut = new PlayerBuilder(factory.Object);
            var block = StrictMock<IPlayerBuildingBlock>();
            sut.AddBuildingBlock(block.Object);

            var player = new Player();
            var position = new Quarterback();
            factory.Setup(f => f.Create()).Returns(player);
            block.Setup(b => b.Build(player, position));

            var result = sut.Build(position);
            Assert.That(result, Is.EqualTo(player));
        }

        //[Test]
        //public void Create_Player_With_A_Given_Position()
        //{
        //    var sut = new PlayerBuilder(
        //        Mock<INameGeneratorService>().Object,
        //        Mock<IHometownRepository>().Object,
        //        Mock<ICollegeRepository>().Object,
        //        null,
        //        Mock<IMeasurablesGenerator>().Object
        //    );
        //    var position = Mock<IPosition>();
        //    var player = sut.Build(position.Object);

        //    Assert.That(player, Is.Not.Null);
        //    Assert.That(player.Position, Is.EqualTo(position.Object));
        //}

        //[Test]
        //public void Create_Player_With_A_Random_Name()
        //{
        //    var nameGen = Mock<INameGeneratorService>();
        //    var sut = new PlayerBuilder(
        //        nameGen.Object,
        //        Mock<IHometownRepository>().Object,
        //        Mock<ICollegeRepository>().Object,
        //        Mock<IPositionRepository>().Object,
        //        Mock<IMeasurablesGenerator>().Object
        //    );
        //    nameGen.Setup(n => n.GetRandomFirstName()).Returns("Gary");
        //    nameGen.Setup(n => n.GetRandomLastName()).Returns("Guagliardo");
        //    var player = sut.Build();

        //    nameGen.Verify(n => n.GetRandomFirstName());
        //    nameGen.Verify(n => n.GetRandomLastName());
        //    Assert.That(player.FirstName, Is.EqualTo("Gary"));
        //    Assert.That(player.LastName, Is.EqualTo("Guagliardo"));
        //}

        //[Test]
        //public void Create_Player_With_A_Random_Hometown()
        //{
        //    var homeGen = Mock<IHometownRepository>();
        //    var sut = new PlayerBuilder(
        //        Mock<INameGeneratorService>().Object,
        //        homeGen.Object,
        //        Mock<ICollegeRepository>().Object,
        //        Mock<IPositionRepository>().Object,
        //        Mock<IMeasurablesGenerator>().Object
        //    );
        //    var hometown = new Location { City = "Greenbow", State = "AL" };
        //    homeGen.Setup(h => h.GetRandomHometown()).Returns(hometown);
        //    var player = sut.Build();

        //    homeGen.Verify(n => n.GetRandomHometown());
        //    Assert.That(player.Hometown, Is.EqualTo(hometown));
        //}

        //[Test]
        //public void Create_Player_With_A_Random_College()
        //{
        //    var college = Mock<ICollegeRepository>();
        //    var sut = new PlayerBuilder(
        //        Mock<INameGeneratorService>().Object,
        //        Mock<IHometownRepository>().Object,
        //        college.Object,
        //        Mock<IPositionRepository>().Object,
        //        Mock<IMeasurablesGenerator>().Object
        //    );
        //    college.Setup(c => c.GetRandomCollege()).Returns("SBU");
        //    var player = sut.Build();

        //    college.Verify(c => c.GetRandomCollege());
        //    Assert.That(player.College, Is.EqualTo("SBU"));
        //}

        //[Test]
        //public void Create_Player_With_A_Generated_Position_Because_None_Was_Provided()
        //{
        //    var positionFactory = Mock<IPositionRepository>();
        //    var sut = new PlayerBuilder(
        //        Mock<INameGeneratorService>().Object,
        //        Mock<IHometownRepository>().Object,
        //        Mock<ICollegeRepository>().Object,
        //        positionFactory.Object,
        //        Mock<IMeasurablesGenerator>().Object
        //    );
        //    var position = Mock<IPosition>();
        //    positionFactory.Setup(p => p.GetRandomPosition()).Returns(position.Object);
        //    var player = sut.Build();

        //    positionFactory.Verify(p => p.GetRandomPosition());
        //    Assert.That(player.Position, Is.EqualTo(position.Object));
        //}

        //[Test]
        //public void Create_Player_With_Measurables_For_A_Specified_Position()
        //{
        //    var measurablesGen = Mock<IMeasurablesGenerator>();
        //    var sut = new PlayerBuilder(
        //        Mock<INameGeneratorService>().Object,
        //        Mock<IHometownRepository>().Object,
        //        Mock<ICollegeRepository>().Object,
        //        null,
        //        measurablesGen.Object
        //    );
        //    var qb = new Quarterback();
        //    measurablesGen.Setup(m => m.GetRandomMeasurables(qb))
        //        .Returns(new Measurables { Height = 72, Weight = 200 });
        //    var player = sut.Build(qb);

        //    measurablesGen.Verify(m => m.GetRandomMeasurables(qb));
        //    Assert.That(player.Measurables.Height, Is.EqualTo(72));
        //    Assert.That(player.Measurables.Weight, Is.EqualTo(200));
        //}

        //[Test]
        //public void Create_Player_With_Measurables_For_A_Random_Position()
        //{
        //    var measurablesGen = Mock<IMeasurablesGenerator>();
        //    var positionFactory = Mock<IPositionRepository>();
        //    var sut = new PlayerBuilder(
        //        Mock<INameGeneratorService>().Object,
        //        Mock<IHometownRepository>().Object,
        //        Mock<ICollegeRepository>().Object,
        //        positionFactory.Object,
        //        measurablesGen.Object
        //    );
        //    var qb = new Quarterback();
        //    positionFactory.Setup(p => p.GetRandomPosition()).Returns(qb);
        //    measurablesGen.Setup(m => m.GetRandomMeasurables(qb))
        //        .Returns(new Measurables { Height = 72, Weight = 200 });
        //    var player = sut.Build();

        //    measurablesGen.Verify(m => m.GetRandomMeasurables(qb));
        //    positionFactory.Verify(p => p.GetRandomPosition());
        //    Assert.That(player.Measurables.Height, Is.EqualTo(72));
        //    Assert.That(player.Measurables.Weight, Is.EqualTo(200));
        //}
    }
}