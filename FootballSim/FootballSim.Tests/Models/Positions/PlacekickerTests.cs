using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class PlacekickerTests : BaseTestFixture
    {
        [Test]
        public void Type_Is_Kicker()
        {
            Assert.That(new Placekicker().Type, Is.EqualTo(PositionType.Kicker));
        }
    }
}