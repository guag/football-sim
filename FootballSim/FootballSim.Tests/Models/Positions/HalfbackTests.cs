using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class HalfbackTests : BaseTestFixture
    {
        [Test]
        public void Type_Is_Halfback()
        {
            Assert.That(new Halfback().Type, Is.EqualTo(PositionType.Halfback));
        }
    }
}