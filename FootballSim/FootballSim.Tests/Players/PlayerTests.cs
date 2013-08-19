using System;
using FootballSim.Models.Players;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Players
{
    [TestFixture]
    public class PlayerTests : BaseTestFixture
    {
        [Test]
        public void Current_Overall_Rating_Is_10()
        {
            var sut = new Player();
            sut.Ratings.Add(RatingType.ThrowingPower, new Rating {CurrentValue = 5});
            sut.Ratings.Add(RatingType.RunDefense, new Rating {CurrentValue = 10});
            sut.Ratings.Add(RatingType.PassCoverage, new Rating {CurrentValue = 15});
            Assert.That(sut.CurrentOverallRating, Is.EqualTo(10));
        }

        [Test]
        public void Current_Overall_Rating_Is_50()
        {
            var sut = new Player();
            sut.Ratings.Add(RatingType.ThrowingPower, new Rating {CurrentValue = 0});
            sut.Ratings.Add(RatingType.RunDefense, new Rating {CurrentValue = 100});
            Assert.That(sut.CurrentOverallRating, Is.EqualTo(50));
        }

        [Test]
        public void Projected_Overall_Rating_Is_10()
        {
            var sut = new Player();
            sut.Ratings.Add(RatingType.ThrowingPower, new Rating {ProjectedValue = 5});
            sut.Ratings.Add(RatingType.RunDefense, new Rating {ProjectedValue = 10});
            sut.Ratings.Add(RatingType.PassCoverage, new Rating {ProjectedValue = 15});
            Assert.That(sut.ProjectedOverallRating, Is.EqualTo(10));
        }

        [Test]
        public void Projected_Overall_Rating_Is_50()
        {
            var sut = new Player();
            sut.Ratings.Add(RatingType.ThrowingPower, new Rating {ProjectedValue = 0});
            sut.Ratings.Add(RatingType.RunDefense, new Rating {ProjectedValue = 100});
            Assert.That(sut.ProjectedOverallRating, Is.EqualTo(50));
        }

        [Test]
        public void BirthDate_Test()
        {
            var sut = new Player();
            var bd = new DateTime(1984, 5, 20);
            sut.BirthDate = bd;
            Assert.That(sut.BirthDate, Is.EqualTo(bd));
        }
    }
}