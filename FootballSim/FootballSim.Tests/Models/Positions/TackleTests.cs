using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class TackleTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Tackle()
        {
            Assert.That(new Tackle().Name, Is.EqualTo("Tackle"));
        }

        [Test]
        public void Type_Is_Tackle()
        {
            Assert.That(new Tackle().Type, Is.EqualTo(PositionType.Tackle));
        }

        [Test]
        public void Side_Is_Offense()
        {
            Assert.That(new Tackle().Side, Is.EqualTo(Side.Offense));
        }

        [Test]
        public void Min_Weight_Is_260()
        {
            Assert.That(new Tackle().MinWeight, Is.EqualTo(260));
        }

        [Test]
        public void Max_Weight_Is_400()
        {
            Assert.That(new Tackle().MaxWeight, Is.EqualTo(400));
        }

        [Test]
        public void Min_Height_Is_70()
        {
            Assert.That(new Tackle().MinHeight, Is.EqualTo(70));
        }

        [Test]
        public void Max_Height_Is_86()
        {
            Assert.That(new Tackle().MaxHeight, Is.EqualTo(86));
        }
    }
}
