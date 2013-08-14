using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class StrongSafetyTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_76()
        {
            Assert.That(new StrongSafety().MaxHeight, Is.EqualTo(76));
        }

        [Test]
        public void Max_Weight_Is_225()
        {
            Assert.That(new StrongSafety().MaxWeight, Is.EqualTo(230));
        }

        [Test]
        public void Min_Height_Is_69()
        {
            Assert.That(new StrongSafety().MinHeight, Is.EqualTo(69));
        }

        [Test]
        public void Min_Weight_Is_180()
        {
            Assert.That(new StrongSafety().MinWeight, Is.EqualTo(185));
        }

        [Test]
        public void Name_Is_Strong_Safety()
        {
            Assert.That(new StrongSafety().Name, Is.EqualTo("Strong Safety"));
        }

        [Test]
        public void Side_Is_Defense()
        {
            Assert.That(new StrongSafety().Side, Is.EqualTo(Side.Defense));
        }

        [Test]
        public void Type_Is_Strong_Safety()
        {
            Assert.That(new StrongSafety().Type, Is.EqualTo(PositionType.StrongSafety));
        }
    }
}