﻿using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class QuarterbackTests : BaseTestFixture
    {
        [Test]
        public void Max_Height_Is_79()
        {
            Assert.That(new Quarterback().MaxHeight, Is.EqualTo(79));
        }

        [Test]
        public void Max_Weight_Is_265()
        {
            Assert.That(new Quarterback().MaxWeight, Is.EqualTo(265));
        }

        [Test]
        public void Min_Height_Is_70()
        {
            Assert.That(new Quarterback().MinHeight, Is.EqualTo(70));
        }

        [Test]
        public void Min_Weight_Is_175()
        {
            Assert.That(new Quarterback().MinWeight, Is.EqualTo(175));
        }

        [Test]
        public void Ratings_Test()
        {
            var sut = new Quarterback();
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.ThrowingAccuracy));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.ThrowingPower));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.Rushing));
        }

        [Test]
        public void Side_Is_Offense()
        {
            Assert.That(new Quarterback().Side, Is.EqualTo(Side.Offense));
        }

        [Test]
        public void Type_Is_Quarterback()
        {
            Assert.That(new Quarterback().Type, Is.EqualTo(PositionType.Quarterback));
        }
    }
}