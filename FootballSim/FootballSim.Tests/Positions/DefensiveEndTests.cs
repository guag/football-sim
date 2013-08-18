using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class DefensiveEndTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Defensive_End()
        {
            Assert.That(new DefensiveEnd().Name, Is.EqualTo("Defensive End"));
        }

        [Test]
        public void Type_Is_Defensive_End()
        {
            Assert.That(new DefensiveEnd().Type, Is.EqualTo(PositionType.DefensiveEnd));
        }
    }
}