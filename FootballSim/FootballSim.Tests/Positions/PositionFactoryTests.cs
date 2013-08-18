using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class PositionFactoryTests : BaseTestFixture
    {
        [Test]
        public void Create_Center()
        {
            Assert.That(PositionFactory.Create(PositionType.Center), Is.TypeOf<Center>());
        }

        [Test]
        public void Create_Empty()
        {
            Assert.That(PositionFactory.Create(PositionType.None), Is.TypeOf<EmptyPosition>());
        }

        [Test]
        public void Create_Guard()
        {
            Assert.That(PositionFactory.Create(PositionType.Guard), Is.TypeOf<Guard>());
        }

        [Test]
        public void Create_Halfback()
        {
            Assert.That(PositionFactory.Create(PositionType.Halfback), Is.TypeOf<Halfback>());
        }

        [Test]
        public void Create_Quarterback()
        {
            Assert.That(PositionFactory.Create(PositionType.Quarterback), Is.TypeOf<Quarterback>());
        }

        [Test]
        public void Create_Tackle()
        {
            Assert.That(PositionFactory.Create(PositionType.Tackle), Is.TypeOf<Tackle>());
        }

        [Test]
        public void Create_Wide_Reciever()
        {
            Assert.That(PositionFactory.Create(PositionType.WideReceiver), Is.TypeOf<WideReceiver>());
        }
    }
}