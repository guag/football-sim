using FootballSim.Models;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class RandomNumberServiceTests : BaseTestFixture
    {
        [Test]
        public void Get_Number_Between_100_And_500()
        {
            var sut = new RandomNumberService();
            var result = sut.GetRandomInt(500);
            Assert.That(result, Is.GreaterThanOrEqualTo(100));
            Assert.That(result, Is.LessThanOrEqualTo(500));
        }

        [Test]
        public void Get_Number_Between_5_And_10()
        {
            var sut = new RandomNumberService();
            var result = sut.GetRandomInt(10);
            Assert.That(result, Is.GreaterThanOrEqualTo(5));
            Assert.That(result, Is.LessThanOrEqualTo(10));
        }
    }
}