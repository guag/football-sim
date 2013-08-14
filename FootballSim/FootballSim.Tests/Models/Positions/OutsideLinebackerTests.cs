using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class OutsideLinebackerTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_76()
        {
            Assert.That(new OutsideLinebacker().MaxHeight, Is.EqualTo(76));
        }

        [Test]
        public void Max_Weight_Is_260()
        {
            Assert.That(new OutsideLinebacker().MaxWeight, Is.EqualTo(260));
        }

        [Test]
        public void Min_Height_Is_69()
        {
            Assert.That(new OutsideLinebacker().MinHeight, Is.EqualTo(69));
        }

        [Test]
        public void Min_Weight_Is_225()
        {
            Assert.That(new OutsideLinebacker().MinWeight, Is.EqualTo(225));
        }

        [Test]
        public void Name_Is_Outside_Linebacker()
        {
            Assert.That(new OutsideLinebacker().Name, Is.EqualTo("Outside Linebacker"));
        }

        [Test]
        public void Side_Is_Defense()
        {
            Assert.That(new OutsideLinebacker().Side, Is.EqualTo(Side.Defense));
        }

        [Test]
        public void Type_Is_Outside_Linebacker()
        {
            Assert.That(new OutsideLinebacker().Type, Is.EqualTo(PositionType.OutsideLinebacker));
        }
    }
}