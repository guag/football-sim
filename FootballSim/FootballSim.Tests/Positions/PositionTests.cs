using System;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class PositionTests : BaseTestFixture
    {
        private StubPosition _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new StubPosition();
        }

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
            Assert.That(_sut.Name, Is.EqualTo(_sut.Type.ToString()));
        }

        [Test]
        public void RatingTypes_Test()
        {
            Assert.That(_sut.RatingTypes, Has.Count.EqualTo(5));
            Assert.That(_sut.RatingTypes, Contains.Item(RatingType.Acceleration));
            Assert.That(_sut.RatingTypes, Contains.Item(RatingType.Agility));
            Assert.That(_sut.RatingTypes, Contains.Item(RatingType.Intelligence));
            Assert.That(_sut.RatingTypes, Contains.Item(RatingType.Speed));
            Assert.That(_sut.RatingTypes, Contains.Item(RatingType.Strength));
        }

        [Test]
        public void ShortName_Returns_Name()
        {
            Assert.That(_sut.ShortName, Is.EqualTo(_sut.Name));
        }

        [Test]
        public void ToString_Returns_ShortName()
        {
            Assert.That(_sut.ToString(), Is.EqualTo(_sut.ShortName));
        }
    }
}