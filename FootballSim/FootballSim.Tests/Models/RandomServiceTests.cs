using FootballSim.Models;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class RandomServiceTests : BaseTestFixture
    {
        [Test]
        public void Get_Number_Between_0_And_500()
        {
            var sut = new RandomService();
            var result = sut.GetRandom(500);
            Assert.That(result, Is.GreaterThanOrEqualTo(0));
            Assert.That(result, Is.LessThanOrEqualTo(500));
        }

        [Test]
        public void Get_Number_Between_0_And_5()
        {
            var sut = new RandomService();
            var result = sut.GetRandom(5);
            Assert.That(result, Is.GreaterThanOrEqualTo(0));
            Assert.That(result, Is.LessThanOrEqualTo(5));
        }
    }
}