using System;
using System.Collections.Generic;
using FootballSim.Models;
using NUnit.Framework;

namespace FootballSim.Tests.Models
{
    [TestFixture]
    public class DraftClassTests : BaseTestFixture
    {
        [Test]
        public void Ctor_Sets_Players()
        {
            var players = new List<Player> { new Player(), new Player() };
            var sut = new DraftClass(players, default(DateTime));
            Assert.That(sut.Players, Is.EquivalentTo(players));
        }

        [Test]
        public void Ctor_Sets_Year()
        {
            var year = DateTime.Now;
            var sut = new DraftClass(default(IEnumerable<Player>), year);
            Assert.That(sut.Year, Is.EqualTo(year));
        }
    }
}
