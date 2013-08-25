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
            sut.Ratings.Add(new Rating {CurrentValue = 5});
            sut.Ratings.Add(new Rating {CurrentValue = 10});
            sut.Ratings.Add(new Rating {CurrentValue = 15});
            Assert.That(sut.CurrentOverallRating, Is.EqualTo(10));
        }

        [Test]
        public void Current_Overall_Rating_Is_50()
        {
            var sut = new Player();
            sut.Ratings.Add(new Rating {CurrentValue = 0});
            sut.Ratings.Add(new Rating {CurrentValue = 100});
            Assert.That(sut.CurrentOverallRating, Is.EqualTo(50));
        }

        [Test]
        public void Projected_Overall_Rating_Is_10()
        {
            var sut = new Player();
            sut.Ratings.Add(new Rating {ProjectedValue = 5});
            sut.Ratings.Add(new Rating {ProjectedValue = 10});
            sut.Ratings.Add(new Rating {ProjectedValue = 15});
            Assert.That(sut.ProjectedOverallRating, Is.EqualTo(10));
        }

        [Test]
        public void Projected_Overall_Rating_Is_50()
        {
            var sut = new Player();
            sut.Ratings.Add(new Rating {ProjectedValue = 0});
            sut.Ratings.Add(new Rating {ProjectedValue = 100});
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

        [Test]
        public void FullName_Is_Guagliardo_Gary()
        {
            var sut = new Player {FirstName = "Gary", LastName = "Guagliardo"};
            Assert.That(sut.FullName, Is.EqualTo("Guagliardo, Gary"));
        }

        [Test]
        public void FullName_Is_Flores_Marcos()
        {
            var sut = new Player { FirstName = "Marcos", LastName = "Flores" };
            Assert.That(sut.FullName, Is.EqualTo("Flores, Marcos"));
        }

        [Test]
        public void BirthDateForDisplay_Is_5_20_1984()
        {
            var sut = new Player {BirthDate = new DateTime(1984, 5, 20)};
            Assert.That(sut.BirthDateForDisplay, Is.EqualTo("5/20/1984"));
        }

        [Test]
        public void BirthDateForDisplay_Is_6_23_1986()
        {
            var sut = new Player { BirthDate = new DateTime(1986, 6, 23) };
            Assert.That(sut.BirthDateForDisplay, Is.EqualTo("6/23/1986"));
        }
    }
}