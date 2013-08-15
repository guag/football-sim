using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class InsideLinebackerTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Inside_Linebacker()
        {
            Assert.That(new InsideLinebacker().Name, Is.EqualTo("Inside Linebacker"));
        }

        [Test]
        public void Type_Is_Inside_Linebacker()
        {
            Assert.That(new InsideLinebacker().Type, Is.EqualTo(PositionType.InsideLinebacker));
        }
    }
}