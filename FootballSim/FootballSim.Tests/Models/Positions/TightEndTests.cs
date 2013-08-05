﻿using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class TightEndTests : BaseTestFixture
    {
        [Test]
        public void Name_Is_Tight_End()
        {
            Assert.That(new TightEnd().Name, Is.EqualTo("Tight End"));
        }

        [Test]
        public void Type_Is_Tight_End()
        {
            Assert.That(new TightEnd().Type, Is.EqualTo(PositionType.TightEnd));
        }

        [Test]
        public void Side_Is_Offense()
        {
            Assert.That(new TightEnd().Side, Is.EqualTo(Side.Offense));
        }

        [Test]
        public void Min_Weight_Is_220()
        {
            Assert.That(new TightEnd().MinWeight, Is.EqualTo(220));
        }

        [Test]
        public void Max_Weight_Is_280()
        {
            Assert.That(new TightEnd().MaxWeight, Is.EqualTo(280));
        }

        [Test]
        public void Min_Height_Is_68()
        {
            Assert.That(new TightEnd().MinHeight, Is.EqualTo(68));
        }

        [Test]
        public void Max_Height_Is_84()
        {
            Assert.That(new TightEnd().MaxHeight, Is.EqualTo(84));
        }
    }
}
