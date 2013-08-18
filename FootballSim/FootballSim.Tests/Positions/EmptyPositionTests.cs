using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class EmptyPositionTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_None()
        {
            Assert.That(new EmptyPosition().Name, Is.EqualTo("None"));
        }

        [Test]
        public void Side_Is_None()
        {
            Assert.That(new EmptyPosition().Side, Is.EqualTo(Side.None));
        }
    }
}