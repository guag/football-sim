using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class PunterTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_76()
        {
            Assert.That(new Punter().MaxHeight, Is.EqualTo(76));
        }

        [Test]
        public void Max_Weight_Is_240()
        {
            Assert.That(new Punter().MaxWeight, Is.EqualTo(240));
        }

        [Test]
        public void Min_Height_Is_68()
        {
            Assert.That(new Punter().MinHeight, Is.EqualTo(68));
        }

        [Test]
        public void Min_Weight_Is_160()
        {
            Assert.That(new Punter().MinWeight, Is.EqualTo(160));
        }

        [Test]
        public void Name_Is_Punter()
        {
            Assert.That(new Punter().Name, Is.EqualTo("Punter"));
        }

        [Test]
        public void Side_Is_Special_Teams()
        {
            Assert.That(new Punter().Side, Is.EqualTo(Side.SpecialTeams));
        }

        [Test]
        public void Type_Is_Punter()
        {
            Assert.That(new Punter().Type, Is.EqualTo(PositionType.Punter));
        }
    }
}