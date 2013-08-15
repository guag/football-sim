using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class GuardTests : BaseTestFixture
    {
        [Test]
        public void Type_Is_Guard()
        {
            Assert.That(new Guard().Type, Is.EqualTo(PositionType.Guard));
        }
    }
}