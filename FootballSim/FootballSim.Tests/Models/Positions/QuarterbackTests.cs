using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class QuarterbackTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Quarterback()
        {
            Assert.That(new Quarterback().Name, Is.EqualTo("Quarterback"));
        }

        [Test]
        public void Side_Is_Offense()
        {
            Assert.That(new Quarterback().Side, Is.EqualTo(Side.Offense));
        }

        [Test]
        public void Min_Weight_Is_155()
        {
            Assert.That(new Quarterback().MinWeight, Is.EqualTo(155));
        }

        [Test]
        public void Max_Weight_Is_265()
        {
            Assert.That(new Quarterback().MaxWeight, Is.EqualTo(265));
        }

        [Test]
        public void Min_Height_Is_65()
        {
            Assert.That(new Quarterback().MinHeight, Is.EqualTo(65));
        }

        [Test]
        public void Max_Height_Is_82()
        {
            Assert.That(new Quarterback().MaxHeight, Is.EqualTo(82));
        }
    }
}
