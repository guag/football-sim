using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class CornerbackTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_76()
        {
            Assert.That(new Cornerback().MaxHeight, Is.EqualTo(76));
        }

        [Test]
        public void Max_Weight_Is_220()
        {
            Assert.That(new Cornerback().MaxWeight, Is.EqualTo(220));
        }

        [Test]
        public void Min_Height_Is_69()
        {
            Assert.That(new Cornerback().MinHeight, Is.EqualTo(69));
        }

        [Test]
        public void Min_Weight_Is_175()
        {
            Assert.That(new Cornerback().MinWeight, Is.EqualTo(175));
        }

        [Test]
        public void Name_Is_Cornerback()
        {
            Assert.That(new Cornerback().Name, Is.EqualTo("Cornerback"));
        }

        [Test]
        public void Side_Is_Defense()
        {
            Assert.That(new Cornerback().Side, Is.EqualTo(Side.Defense));
        }

        [Test]
        public void Type_Is_Cornerback()
        {
            Assert.That(new Cornerback().Type, Is.EqualTo(PositionType.Cornerback));
        }
    }
}