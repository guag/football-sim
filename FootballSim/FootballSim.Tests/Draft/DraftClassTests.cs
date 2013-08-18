using System.Collections.Generic;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using NUnit.Framework;

namespace FootballSim.Models.Tests.Draft
{
    [TestFixture]
    public class DraftClassTests : BaseTestFixture
    {
        [Test]
        public void Players_Test()
        {
            var players = new List<Player> {new Player(), new Player()};
            var sut = new DraftClass();
            foreach (var player in players)
            {
                sut.Players.Add(player);
            }
            Assert.That(sut.Players, Is.EquivalentTo(players));
        }

        [Test]
        public void Year_Test()
        {
            const int year = 2013;
            var sut = new DraftClass {Year = year};
            Assert.That(sut.Year, Is.EqualTo(year));
        }
    }
}