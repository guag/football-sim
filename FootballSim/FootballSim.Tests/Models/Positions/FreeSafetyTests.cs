using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class FreeSafetyTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_76()
        {
            Assert.That(new FreeSafety().MaxHeight, Is.EqualTo(76));
        }

        [Test]
        public void Max_Weight_Is_225()
        {
            Assert.That(new FreeSafety().MaxWeight, Is.EqualTo(225));
        }

        [Test]
        public void Min_Height_Is_69()
        {
            Assert.That(new FreeSafety().MinHeight, Is.EqualTo(69));
        }

        [Test]
        public void Min_Weight_Is_180()
        {
            Assert.That(new FreeSafety().MinWeight, Is.EqualTo(180));
        }

        [Test]
        public void Name_Is_Free_Safety()
        {
            Assert.That(new FreeSafety().Name, Is.EqualTo("Free Safety"));
        }

        [Test]
        public void Side_Is_Defense()
        {
            Assert.That(new FreeSafety().Side, Is.EqualTo(Side.Defense));
        }

        [Test]
        public void Type_Is_Free_Safety()
        {
            Assert.That(new FreeSafety().Type, Is.EqualTo(PositionType.FreeSafety));
        }
    }
}