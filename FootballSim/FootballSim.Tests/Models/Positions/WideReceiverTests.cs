using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class WideReceiverTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Wide_Receiver()
        {
            Assert.That(new WideReceiver().Name, Is.EqualTo("Wide Receiver"));
        }

        [Test]
        public void Type_Is_Wide_Receiver()
        {
            Assert.That(new WideReceiver().Type, Is.EqualTo(PositionType.WideReceiver));
        }

        [Test]
        public void Side_Is_Offense()
        {
            Assert.That(new WideReceiver().Side, Is.EqualTo(Side.Offense));
        }

        [Test]
        public void Min_Weight_Is_155()
        {
            Assert.That(new WideReceiver().MinWeight, Is.EqualTo(155));
        }

        [Test]
        public void Max_Weight_Is_265()
        {
            Assert.That(new WideReceiver().MaxWeight, Is.EqualTo(265));
        }

        [Test]
        public void Min_Height_Is_65()
        {
            Assert.That(new WideReceiver().MinHeight, Is.EqualTo(65));
        }

        [Test]
        public void Max_Height_Is_84()
        {
            Assert.That(new WideReceiver().MaxHeight, Is.EqualTo(84));
        }
    }
}
