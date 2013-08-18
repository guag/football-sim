using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class DefensiveBackTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_76()
        {
            Assert.That(new FreeSafety().MaxHeight, Is.EqualTo(76));
        }

        [Test]
        public void Max_Weight_Is_230()
        {
            Assert.That(new FreeSafety().MaxWeight, Is.EqualTo(230));
        }

        [Test]
        public void Min_Height_Is_69()
        {
            Assert.That(new FreeSafety().MinHeight, Is.EqualTo(69));
        }

        [Test]
        public void Min_Weight_Is_175()
        {
            Assert.That(new FreeSafety().MinWeight, Is.EqualTo(175));
        }
    }
}