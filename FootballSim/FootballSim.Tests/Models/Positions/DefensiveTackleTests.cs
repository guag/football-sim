using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class DefensiveTackleTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_84()
        {
            Assert.That(new DefensiveTackle().MaxHeight, Is.EqualTo(84));
        }

        [Test]
        public void Max_Weight_Is_350()
        {
            Assert.That(new DefensiveTackle().MaxWeight, Is.EqualTo(350));
        }

        [Test]
        public void Min_Height_Is_70()
        {
            Assert.That(new DefensiveTackle().MinHeight, Is.EqualTo(70));
        }

        [Test]
        public void Min_Weight_Is_275()
        {
            Assert.That(new DefensiveTackle().MinWeight, Is.EqualTo(275));
        }

        [Test]
        public void Name_Is_Defensive_Tackle()
        {
            Assert.That(new DefensiveTackle().Name, Is.EqualTo("Defensive Tackle"));
        }

        [Test]
        public void Side_Is_Defense()
        {
            Assert.That(new DefensiveTackle().Side, Is.EqualTo(Side.Defense));
        }

        [Test]
        public void Type_Is_Defensive_Tackle()
        {
            Assert.That(new DefensiveTackle().Type, Is.EqualTo(PositionType.DefensiveTackle));
        }
    }
}