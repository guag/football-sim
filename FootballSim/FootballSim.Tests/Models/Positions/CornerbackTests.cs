using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class CornerbackTests : BaseTestFixture
    {
        [Test]
        public void Type_Is_Cornerback()
        {
            Assert.That(new Cornerback().Type, Is.EqualTo(PositionType.Cornerback));
        }
    }
}