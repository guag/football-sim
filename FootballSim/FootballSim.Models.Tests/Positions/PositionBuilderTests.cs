using FootballSim.Models.Players;
using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
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
            builder.Setup(b => b.Build(position)).Returns(measurables);
            var player = new Player();

            sut.Build(player);
            builder.Verify(b => b.Build(position));
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
    }
}