using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class CenterTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_86()
        {
            Assert.That(new Center().MaxHeight, Is.EqualTo(84));
        }

        [Test]
        public void Max_Weight_Is_360()
        {
            Assert.That(new Center().MaxWeight, Is.EqualTo(360));
        }

        [Test]
        public void Min_Height_Is_70()
        {
            Assert.That(new Center().MinHeight, Is.EqualTo(70));
        }

        [Test]
        public void Min_Weight_Is_250()
        {
            Assert.That(new Center().MinWeight, Is.EqualTo(250));
        }

        [Test]
        public void Name_Is_Center()
        {
            Assert.That(new Center().Name, Is.EqualTo("Center"));
        }

        [Test]
        public void Side_Is_Offense()
        {
            Assert.That(new Center().Side, Is.EqualTo(Side.Offense));
        }

        [Test]
        public void Type_Is_Center()
        {
            Assert.That(new Center().Type, Is.EqualTo(PositionType.Center));
        }
    }
}