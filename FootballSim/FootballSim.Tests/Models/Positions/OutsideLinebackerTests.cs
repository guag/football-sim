using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class OutsideLinebackerTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Outside_Linebacker()
        {
            Assert.That(new OutsideLinebacker().Name, Is.EqualTo("Outside Linebacker"));
        }

        [Test]
        public void Type_Is_Outside_Linebacker()
        {
            Assert.That(new OutsideLinebacker().Type, Is.EqualTo(PositionType.OutsideLinebacker));
        }
    }
}