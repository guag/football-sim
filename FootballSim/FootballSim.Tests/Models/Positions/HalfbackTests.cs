using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class HalfbackTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Halfback()
        {
            Assert.That(new Halfback().Name, Is.EqualTo("Halfback"));
        }

        [Test]
        public void Side_Is_Offense()
        {
            Assert.That(new Halfback().Side, Is.EqualTo(Side.Offense));
        }

        [Test]
        public void Min_Weight_Is_155()
        {
            Assert.That(new Halfback().MinWeight, Is.EqualTo(155));
        }

        [Test]
        public void Max_Weight_Is_265()
        {
            Assert.That(new Halfback().MaxWeight, Is.EqualTo(265));
        }

        [Test]
        public void Min_Height_Is_65()
        {
            Assert.That(new Halfback().MinHeight, Is.EqualTo(65));
        }

        [Test]
        public void Max_Height_Is_78()
        {
            Assert.That(new Halfback().MaxHeight, Is.EqualTo(78));
        }
    }
}
