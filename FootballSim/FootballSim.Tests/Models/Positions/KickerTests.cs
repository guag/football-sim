using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class KickerTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_76()
        {
            Assert.That(new Kicker().MaxHeight, Is.EqualTo(76));
        }

        [Test]
        public void Max_Weight_Is_240()
        {
            Assert.That(new Kicker().MaxWeight, Is.EqualTo(240));
        }

        [Test]
        public void Min_Height_Is_68()
        {
            Assert.That(new Kicker().MinHeight, Is.EqualTo(68));
        }

        [Test]
        public void Min_Weight_Is_160()
        {
            Assert.That(new Kicker().MinWeight, Is.EqualTo(160));
        }

        [Test]
        public void Name_Is_Kicker()
        {
            Assert.That(new Kicker().Name, Is.EqualTo("Kicker"));
        }

        [Test]
        public void Side_Is_Special_Teams()
        {
            Assert.That(new Kicker().Side, Is.EqualTo(Side.SpecialTeams));
        }

        [Test]
        public void Type_Is_Kicker()
        {
            Assert.That(new Kicker().Type, Is.EqualTo(PositionType.Kicker));
        }
    }
}