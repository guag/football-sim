using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
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