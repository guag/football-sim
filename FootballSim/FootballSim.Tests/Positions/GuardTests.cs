using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
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