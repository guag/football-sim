﻿using FootballSim.Models.Positions;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Positions
{
    [TestFixture]
    public class FullbackTests : BaseTestFixture
    {
        [Test]
        public void Type_Is_Fullback()
        {
            Assert.That(new Fullback().Type, Is.EqualTo(PositionType.Fullback));
        }
    }
}