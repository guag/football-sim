using FootballSim.Models;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class RandomServiceTests : BaseTestFixture
    {
        [Test]
        public void Get_Number_Between_0_And_5()
        {
            var sut = new RandomService();
            var result = sut.GetRandom(5);
            Assert.That(result, Is.GreaterThanOrEqualTo(0));
            Assert.That(result, Is.LessThanOrEqualTo(5));
        }

        [Test]
        public void Get_Number_Between_0_And_500()
        {
            var sut = new RandomService();
            var result = sut.GetRandom(500);
            Assert.That(result, Is.GreaterThanOrEqualTo(0));
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

        [Test]
        public void Get_Number_Between_490_And_500()
        {
            var sut = new RandomService();
            var result = sut.GetRandom(490, 500);
            Assert.That(result, Is.GreaterThanOrEqualTo(490));
            Assert.That(result, Is.LessThanOrEqualTo(500));
        }

        [Test]
        public void Get_Number_Weighted_To_The_Middle()
        {
            var sut = new RandomService();
            var numWeighted = 0;
            var numUnweighted = 0;
            for (int i = 0; i < 200; i++)
            {
                var result = sut.GetRandomWeighted(0, 100);
                if (result < 25 || result > 75)
                {
                    numUnweighted++;
                }
                else
                {
                    numWeighted++;
                }
            }
            Assert.That(numWeighted, Is.GreaterThan(numUnweighted));
        }

        [Test]
        public void Get_Number_Weighted_Min_Is_70_Max_Is_84()
        {
            var sut = new RandomService();
            var numWeighted = 0;
            var numUnweighted = 0;
            for (int i = 0; i < 200; i++)
            {
                var result = sut.GetRandomWeighted(70, 84);
                if (result < 73 || result > 81)
                {
                    numUnweighted++;
                }
                else
                {
                    numWeighted++;
                }
            }
            Assert.That(numWeighted, Is.GreaterThan(numUnweighted));
        }
    }
}