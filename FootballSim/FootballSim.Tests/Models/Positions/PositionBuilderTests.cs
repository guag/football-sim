using FootballSim.Models;
using FootballSim.Models.Players;
using FootballSim.Models.Positions;
using Moq;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class PositionBuilderTests : BaseTestFixture
    {
        [Test]
        public void Build_Sets_Measurables()
        {
            var builder = Mock<IMeasurablesBuilder>();
            var repo = Mock<IPositionRepository>();
            var sut = new PositionBuilder(repo.Object, builder.Object);
            var position = new Quarterback();
            var measurables = new Measurables {Height = 10, Weight = 20};
            repo.Setup(r => r.GetRandomPosition()).Returns(position);
            builder.Setup(b => b.GenerateMeasurables(position)).Returns(measurables);
            var player = new Player();

            sut.Build(player);
            builder.Verify(b => b.GenerateMeasurables(position));
            Assert.That(player.Measurables, Is.EqualTo(measurables));
        }

        [Test]
        public void Build_Sets_Random_Position()
        {
            var repo = Mock<IPositionRepository>();
            var sut = new PositionBuilder(
                repo.Object,
                Mock<IMeasurablesBuilder>().Object
                );
            var position = new Quarterback();
            repo.Setup(r => r.GetRandomPosition()).Returns(position);
            var player = new Player();

            sut.Build(player);
            repo.Verify(r => r.GetRandomPosition());
            Assert.That(player.Position, Is.EqualTo(position));
        }

        [Test]
        public void Build_With_Given_Position_Does_Not_Get_Random_Position()
        {
            var repo = Mock<IPositionRepository>();
            var sut = new PositionBuilder(
                repo.Object,
                Mock<IMeasurablesBuilder>().Object
                );

            sut.Build(new Player(), new Quarterback());
            repo.Verify(r => r.GetRandomPosition(), Times.Never());
        }
    }
}