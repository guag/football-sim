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

        [Test]
        public void Get_Number_Between_490_And_500()
        {
            var sut = new RandomService();
            var result = sut.GetRandom(490, 500);
            Assert.That(result, Is.GreaterThanOrEqualTo(490));
            Assert.That(result, Is.LessThanOrEqualTo(500));
        }

        [Test]
        public void Get_Number_Between_3_And_5()
        {
            var sut = new RandomService();
            var result = sut.GetRandom(3, 5);
            Assert.That(result, Is.GreaterThanOrEqualTo(3));
            Assert.That(result, Is.LessThanOrEqualTo(5));
        }
    }
}