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
            var sut = new PositionRepository(null);
            Assert.That(sut.GetRandomPosition(), Is.TypeOf<EmptyPosition>());
        }

        [Test]
        public void Get_Random_Position()
        {
            var random = Mock<IRandomService>();
            var sut = new PositionRepository(random.Object);
            sut.AddPosition(new Halfback());
            var wr = new WideReceiver();
            sut.AddPosition(wr);
            sut.AddPosition(new Quarterback());
            random.Setup(r => r.GetRandom(3)).Returns(1);

            var result = sut.GetRandomPosition();
            random.Verify(r => r.GetRandom(3));
            Assert.That(result, Is.EqualTo(wr));
        }
    }
}