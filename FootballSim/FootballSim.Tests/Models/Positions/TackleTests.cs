using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class TackleTests : BaseTestFixture
    {
        [Test]
        public void Type_Is_Tackle()
        {
            Assert.That(new Tackle().Type, Is.EqualTo(PositionType.Tackle));
        }
    }
}