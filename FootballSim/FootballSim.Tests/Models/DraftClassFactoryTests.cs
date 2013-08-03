﻿using System;
using System.Collections.Generic;
using FootballSim.Models;
using FootballSim.Models.Positions;
using Moq;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class DraftClassFactoryTests : BaseTestFixture
    {
        [Test]
        public void Date_Is_Set()
        {
            var sut = new DraftClassFactory(Mock<IMultiplePlayerFactory>().Object);
            var year = DateTime.Now;
            var draft = sut.Create(year);

            Assert.That(draft.Year, Is.EqualTo(year));
        }

        [Test]
        public void Players_Are_Set()
        {
            var playerFactory = Mock<IMultiplePlayerFactory>();
            var sut = new DraftClassFactory(playerFactory.Object);
            var players = new List<Player> { new Player(), new Player() };
            playerFactory.Setup(p => p.Create(500, It.IsAny<IPosition>(), It.IsAny<ITeam>())).Returns(players);
            var draft = sut.Create(default(DateTime));

            playerFactory.Verify(p => p.Create(500, It.IsAny<IPosition>(), It.IsAny<ITeam>()));
            Assert.That(draft.Players, Is.EquivalentTo(players));
        }
    }
}