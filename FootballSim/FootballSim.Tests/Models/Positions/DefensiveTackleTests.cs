using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class DefensiveTackleTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Defensive_Tackle()
        {
            Assert.That(new DefensiveTackle().Name, Is.EqualTo("Defensive Tackle"));
        }

        [Test]
        public void Type_Is_Defensive_Tackle()
        {
            Assert.That(new DefensiveTackle().Type, Is.EqualTo(PositionType.DefensiveTackle));
        }
    }
}