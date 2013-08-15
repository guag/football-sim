using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class FreeSafetyTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Free_Safety()
        {
            Assert.That(new FreeSafety().Name, Is.EqualTo("Free Safety"));
        }

        [Test]
        public void Type_Is_Free_Safety()
        {
            Assert.That(new FreeSafety().Type, Is.EqualTo(PositionType.FreeSafety));
        }
    }
}