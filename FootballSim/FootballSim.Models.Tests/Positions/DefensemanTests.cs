using System;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Positions
{
    [TestFixture]
    public class DefensemanTests : BaseTestFixture
    {
        private class StubDefenseman : Defenseman
        {
            public override PositionType Type
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
        public void RatingTypes_Test()
        {
            var sut = new StubDefenseman();
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.PassCoverage));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.RunDefense));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.Catching));
            Assert.That(sut.RatingTypes, Contains.Item(RatingType.Tackling));
        }

        [Test]
        public void Side_Is_Defense()
        {
            Assert.That(new StubDefenseman().Side, Is.EqualTo(Side.Defense));
        }
    }
}