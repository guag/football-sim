using FootballSim.Models;
using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class PositionRepositoryTests : BaseTestFixture
    {
        [Test]
        public void Position_Nonexistent_So_Return_EmptyPosition()
        {
            var sut = new PositionRepository(null);
            sut.AddPosition(new Halfback());

            var position = sut.GetPosition(PositionType.Quarterback);
            Assert.That(position, Is.TypeOf<EmptyPosition>());
        }

        [Test]
        public void Get_Position_That_Exists()
        {
            var sut = new PositionRepository(null);
            var qb = new Quarterback();
            sut.AddPosition(qb);

            var position = sut.GetPosition(PositionType.Quarterback);
            Assert.That(position, Is.EqualTo(qb));
        }

        [Test]
        public void Get_Random_But_No_Positions_Exist_So_Return_EmptyPosition()
        {
            var sut = new PositionRepository(null);

            var position = sut.GetRandomPosition();
            Assert.That(position, Is.TypeOf<EmptyPosition>());
        }

        [Test]
        public void Get_Random_Position()
        {
            var randomService = Mock<IRandomNumberService>();
            var sut = new PositionRepository(randomService.Object);
            sut.AddPosition(new Halfback());
            var fake = new FakePosition();
            sut.AddPosition(fake);
            sut.AddPosition(new Quarterback());
            randomService.Setup(r => r.GetRandomInt(0, 3)).Returns(1);

            var position = sut.GetRandomPosition();
            randomService.Verify(r => r.GetRandomInt(0, 3));
            Assert.That(position, Is.EqualTo(fake));
        }
    }

    #region FakePosition class
    public class FakePosition : IPosition
    {
        public PositionType Type { get; set; }
        public string Name { get; set; }
        public Side Side { get; set; }
        public double MinWeight { get; set; }
        public double MaxWeight { get; set; }
        public double MinHeight { get; set; }
        public double MaxHeight { get; set; }
    }
    #endregion
}
