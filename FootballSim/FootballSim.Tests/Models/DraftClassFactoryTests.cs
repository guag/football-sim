﻿using System.Collections.Generic;
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
            var sut = new DraftClassFactory(Mock<IMultiplePlayerBuilder>().Object);
            const int year = 2013;
            var draft = sut.Create(year, 10);

            Assert.That(draft.Year, Is.EqualTo(year));
        }

        [Test]
        public void Create_500_Players()
        {
            var playerFactory = Mock<IMultiplePlayerBuilder>();
            var sut = new DraftClassFactory(playerFactory.Object);
            var players = new List<Player> { new Player(), new Player() };
            playerFactory.Setup(p => p.Build(500, It.IsAny<IPosition>())).Returns(players);
            var draft = sut.Create(0, 500);

            playerFactory.Verify(p => p.Build(500, It.IsAny<IPosition>()));
            Assert.That(draft.Players, Is.EquivalentTo(players));
        }

        [Test]
        public void Create_1000_Players()
        {
            var playerFactory = Mock<IMultiplePlayerBuilder>();
            var sut = new DraftClassFactory(playerFactory.Object);
            var players = new List<Player> { new Player(), new Player() };
            playerFactory.Setup(p => p.Build(1000, It.IsAny<IPosition>())).Returns(players);
            var draft = sut.Create(0, 1000);

            playerFactory.Verify(p => p.Build(1000, It.IsAny<IPosition>()));
            Assert.That(draft.Players, Is.EquivalentTo(players));
        }
    }
}
