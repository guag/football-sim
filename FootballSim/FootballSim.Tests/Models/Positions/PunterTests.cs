using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class PunterTests : BaseTestFixture
    {
        [Test]
        public void Type_Is_Punter()
        {
            Assert.That(new Punter().Type, Is.EqualTo(PositionType.Punter));
        }
    }
}