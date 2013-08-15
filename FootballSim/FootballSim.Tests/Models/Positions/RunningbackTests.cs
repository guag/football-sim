using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class RunningbackTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_76()
        {
            Assert.That(new Halfback().MaxHeight, Is.EqualTo(76));
        }

        [Test]
        public void Max_Weight_Is_265()
        {
            Assert.That(new Halfback().MaxWeight, Is.EqualTo(260));
        }

        [Test]
        public void Min_Height_Is_65()
        {
            Assert.That(new Halfback().MinHeight, Is.EqualTo(68));
        }

        [Test]
        public void Min_Weight_Is_175()
        {
            Assert.That(new Halfback().MinWeight, Is.EqualTo(190));
        }

        [Test]
        public void Ratings_Type()
        {
            var sut = new Halfback();
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.Rushing));
        }
    }
}