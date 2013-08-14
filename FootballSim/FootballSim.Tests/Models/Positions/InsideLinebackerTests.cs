using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class InsideLinebackerTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_78()
        {
            Assert.That(new InsideLinebacker().MaxHeight, Is.EqualTo(78));
        }

        [Test]
        public void Max_Weight_Is_280()
        {
            Assert.That(new InsideLinebacker().MaxWeight, Is.EqualTo(280));
        }

        [Test]
        public void Min_Height_Is_69()
        {
            Assert.That(new InsideLinebacker().MinHeight, Is.EqualTo(69));
        }

        [Test]
        public void Min_Weight_Is_240()
        {
            Assert.That(new InsideLinebacker().MinWeight, Is.EqualTo(240));
        }

        [Test]
        public void Name_Is_Inside_Linebacker()
        {
            Assert.That(new InsideLinebacker().Name, Is.EqualTo("Inside Linebacker"));
        }

        [Test]
        public void Side_Is_Defense()
        {
            Assert.That(new InsideLinebacker().Side, Is.EqualTo(Side.Defense));
        }

        [Test]
        public void Type_Is_Inside_Linebacker()
        {
            Assert.That(new InsideLinebacker().Type, Is.EqualTo(PositionType.InsideLinebacker));
        }
    }
}