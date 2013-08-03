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
            var sut = new PositionRepository();
            sut.AddPosition(new Halfback());

            var position = sut.GetPosition(PositionType.Quarterback);
            Assert.That(position, Is.TypeOf<EmptyPosition>());
        }

        [Test]
        public void Get_Position_That_Exists()
        {
            var sut = new PositionRepository();
            var qb = new Quarterback();
            sut.AddPosition(qb);

            var position = sut.GetPosition(PositionType.Quarterback);
            Assert.That(position, Is.EqualTo(qb));
        }

        [Test]
        public void Get_Random_But_No_Positions_Exist_So_Return_EmptyPosition()
        {
            var sut = new PositionRepository();

            var position = sut.GetRandomPosition();
            Assert.That(position, Is.TypeOf<EmptyPosition>());
        }

        [Test]
        public void Get_Random_Position()
        {
            var sut = new PositionRepository();
            sut.AddPosition(new Halfback());
            sut.AddPosition(new FakePosition());
            sut.AddPosition(new Quarterback());

            var position = sut.GetRandomPosition();
            Assert.That(position, Is.Not.TypeOf<EmptyPosition>());
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
