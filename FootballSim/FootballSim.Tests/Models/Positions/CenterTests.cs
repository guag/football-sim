using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class CenterTests : BaseTestFixture
    {
        [Test]
        public void Type_Is_Center()
        {
            Assert.That(new Center().Type, Is.EqualTo(PositionType.Center));
        }
    }
}