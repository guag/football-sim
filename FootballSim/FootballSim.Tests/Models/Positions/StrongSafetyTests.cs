using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class StrongSafetyTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Strong_Safety()
        {
            Assert.That(new StrongSafety().Name, Is.EqualTo("Strong Safety"));
        }

        [Test]
        public void Type_Is_Strong_Safety()
        {
            Assert.That(new StrongSafety().Type, Is.EqualTo(PositionType.StrongSafety));
        }
    }
}