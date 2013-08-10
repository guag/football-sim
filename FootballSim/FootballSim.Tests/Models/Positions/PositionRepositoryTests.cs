using FootballSim.Models;
using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class PositionRepositoryTests : BaseTestFixture
    {
        [Test]
        public void Get_Random_But_No_Positions_Exist_So_Return_EmptyPosition()
        {
            var sut = new PositionRepository(null, Mock<IMeasurablesGenerator>().Object);
            var player = new Player();

            sut.Build(player);
            Assert.That(player.Position, Is.TypeOf<EmptyPosition>());
        }

        [Test]
        public void Get_Random_Position()
        {
            var randomService = Mock<IRandomNumberService>();
            var measurablesService = Mock<IMeasurablesGenerator>();
            var sut = new PositionRepository(randomService.Object, measurablesService.Object);
            sut.AddPosition(new Halfback());
            var wr = new WideReceiver();
            sut.AddPosition(wr);
            sut.AddPosition(new Quarterback());
            var player = new Player();
            randomService.Setup(r => r.GetRandomInt(0, 3)).Returns(1);
            var measurables = new Measurables { Height = 70, Weight = 300 };
            measurablesService.Setup(m => m.GetRandomMeasurables(wr)).Returns(measurables);

            sut.Build(player);
            randomService.Verify(r => r.GetRandomInt(0, 3));
            measurablesService.Verify(m => m.GetRandomMeasurables(wr));
            Assert.That(player.Position, Is.EqualTo(wr));
        }

        [Test]
        public void Set_Position()
        {
            var measurablesService = Mock<IMeasurablesGenerator>();
            var sut = new PositionRepository(null, measurablesService.Object);
            var position = new WideReceiver();
            var player = new Player();
            var measurables = new Measurables { Height = 70, Weight = 300 };
            measurablesService.Setup(m => m.GetRandomMeasurables(position)).Returns(measurables);

            sut.Build(player, position);
            measurablesService.Verify(m => m.GetRandomMeasurables(position));
            Assert.That(player.Position, Is.EqualTo(position));
        }
    }
}
