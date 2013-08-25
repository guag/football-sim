using System;
using System.Collections.Generic;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Draft
{
    [TestFixture]
    public class DraftClassPlayerSorterTests : BaseTestFixture
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _sut = new DraftClassPlayerSorter();
            _p1 = new Player
                      {
                          LastName = "Smith",
                          FirstName = "John",
                          Position = new Quarterback()
                      };_p1.Ratings.Add(new Rating {CurrentValue = 60})
            ;
            _p2 = new Player
                      {
                          LastName = "Doe",
                          FirstName = "Jane",
                          Position = new Guard()
                      };
            _p2.Ratings.Add(new Rating {CurrentValue = 90});
            _p3 = new Player
                      {
                          LastName = "Doe",
                          FirstName = "John",
                          Position = new Quarterback()
                      };
            _p3.Ratings.Add(new Rating {CurrentValue = 70});
            _players = new[] {_p1, _p2, _p3};
        }

        #endregion

        private DraftClassPlayerSorter _sut;
        private Player _p1;
        private Player _p2;
        private Player _p3;
        private IList<Player> _players;

        [Test]
        public void Default_Sort_Because_No_Expression_Provided()
        {
            var result = _sut.Sort(_players);
            Assert.That(result[0], Is.SameAs(_p3));
            Assert.That(result[1], Is.SameAs(_p1));
            Assert.That(result[2], Is.SameAs(_p2));
        }

        [Test]
        public void Default_Sort_Part_2()
        {
            _p3.Ratings.Clear();
            _p3.Ratings.Add(new Rating {CurrentValue = 50});
            var result = _sut.Sort(_players);
            Assert.That(result[0], Is.SameAs(_p1));
            Assert.That(result[1], Is.SameAs(_p3));
            Assert.That(result[2], Is.SameAs(_p2));
        }

        [Test]
        public void Order_By_Caliber_Desc()
        {
            _p1.Caliber = new LowCaliber();
            _p2.Caliber = new BlueChipCaliber();
            _p3.Caliber = new AverageCaliber();
            var result = _sut.Sort(_players, "Caliber", "DESC");
            Assert.That(result[0], Is.SameAs(_p2));
            Assert.That(result[1], Is.SameAs(_p3));
            Assert.That(result[2], Is.SameAs(_p1));
        }

        [Test]
        public void Order_By_College()
        {
            _p1.College = "ABC";
            _p2.College = "ZYX";
            _p3.College = "XYZ";
            var result = _sut.Sort(_players, "College");
            Assert.That(result[0], Is.SameAs(_p1));
            Assert.That(result[1], Is.SameAs(_p3));
            Assert.That(result[2], Is.SameAs(_p2));
        }

        [Test]
        public void Order_By_Dob()
        {
            _p1.BirthDate = new DateTime(1939, 9, 1);
            _p2.BirthDate = new DateTime(1934, 9, 2);
            _p3.BirthDate = new DateTime(1940, 1, 1);
            var result = _sut.Sort(_players, "DOB", "DESC");
            Assert.That(result[0], Is.SameAs(_p3));
            Assert.That(result[1], Is.SameAs(_p1));
            Assert.That(result[2], Is.SameAs(_p2));
        }

        [Test]
        public void Order_By_FullName_Asc()
        {
            var result = _sut.Sort(_players, "FullName");
            Assert.That(result[0], Is.SameAs(_p2));
            Assert.That(result[1], Is.SameAs(_p3));
            Assert.That(result[2], Is.SameAs(_p1));
        }

        [Test]
        public void Order_By_FullName_Desc()
        {
            var result = _sut.Sort(_players, "FullName", "DESC");
            Assert.That(result[0], Is.SameAs(_p1));
            Assert.That(result[1], Is.SameAs(_p3));
            Assert.That(result[2], Is.SameAs(_p2));
        }

        [Test]
        public void Order_By_Hometown()
        {
            _p1.Hometown = new Location {City = "Holbrook", State = "NY"};
            _p2.Hometown = new Location {City = "Amityville", State = "NY"};
            _p3.Hometown = new Location {City = "Wilmington", State = "DE"};
            var result = _sut.Sort(_players, "Hometown");
            Assert.That(result[0], Is.SameAs(_p2));
            Assert.That(result[1], Is.SameAs(_p1));
            Assert.That(result[2], Is.SameAs(_p3));
        }

        [Test]
        public void Order_By_Position()
        {
            _p1.Position = new Punter();
            var result = _sut.Sort(_players, "Position");
            Assert.That(result[0], Is.SameAs(_p3));
            Assert.That(result[1], Is.SameAs(_p2));
            Assert.That(result[2], Is.SameAs(_p1));
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void Throw_Because_Sort_Expression_Does_Not_Exist()
        {
            _sut.Sort(_players, "FAIL");
        }
    }
}