using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
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