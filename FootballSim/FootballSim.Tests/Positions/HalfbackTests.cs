using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
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