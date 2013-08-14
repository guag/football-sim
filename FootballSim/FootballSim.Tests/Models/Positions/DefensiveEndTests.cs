using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class DefensiveEndTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_84()
        {
            Assert.That(new DefensiveEnd().MaxHeight, Is.EqualTo(84));
        }

        [Test]
        public void Max_Weight_Is_330()
        {
            Assert.That(new DefensiveEnd().MaxWeight, Is.EqualTo(330));
        }

        [Test]
        public void Min_Height_Is_70()
        {
            Assert.That(new DefensiveEnd().MinHeight, Is.EqualTo(70));
        }

        [Test]
        public void Min_Weight_Is_260()
        {
            Assert.That(new DefensiveEnd().MinWeight, Is.EqualTo(260));
        }

        [Test]
        public void Name_Is_Defensive_End()
        {
            Assert.That(new DefensiveEnd().Name, Is.EqualTo("Defensive End"));
        }

        [Test]
        public void Side_Is_Defense()
        {
            Assert.That(new DefensiveEnd().Side, Is.EqualTo(Side.Defense));
        }

        [Test]
        public void Type_Is_Defensive_End()
        {
            Assert.That(new DefensiveEnd().Type, Is.EqualTo(PositionType.DefensiveEnd));
        }
    }
}