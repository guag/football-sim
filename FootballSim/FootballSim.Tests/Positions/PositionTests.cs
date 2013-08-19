using System;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class PositionTests : BaseTestFixture
    {
        private class StubPosition : Position
        {
            public override PositionType Type
            {
                get { return PositionType.None; }
            }

            public override Side Side
            {
                get { throw new NotImplementedException(); }
            }

            public override int MinWeight
            {
                get { throw new NotImplementedException(); }
            }

            public override int MaxWeight
            {
                get { throw new NotImplementedException(); }
            }

            public override int MinHeight
            {
                get { throw new NotImplementedException(); }
            }

            public override int MaxHeight
            {
                get { throw new NotImplementedException(); }
            }
        }

        [Test]
        public void Name_Returns_Type_As_String()
        {
            var sut = new StubPosition();
            Assert.That(sut.Name, Is.EqualTo(sut.Type.ToString()));
        }

        [Test]
        public void RatingTypes_Test()
        {
            var sut = new StubPosition();
            Assert.That(sut.RatingTypes, Has.Count.EqualTo(5));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.Acceleration));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.Agility));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.Intelligence));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.Speed));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.Strength));
        }

        [Test]
        public void ShortName_Returns_Name()
        {
            var sut = new StubPosition();
            Assert.That(sut.ShortName, Is.EqualTo(sut.Name));
        }
    }
}