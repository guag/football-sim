using FootballSim.Models.Players;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Players
{
    [TestFixture]
    public class PlayerBuilderTests : BaseTestFixture
    {
        [Test]
        public void Build_Player_With_1_Building_Block()
        {
            var factory = StrictMock<IPlayerFactory>();
            var sut = new PlayerBuilder(factory.Object);
            var block = StrictMock<IPlayerBuildingBlock>();
            sut.AddBuildingBlock(block.Object);

            var player = new Player();
            factory.Setup(f => f.Create()).Returns(player);
            block.Setup(b => b.Build(player));

            var result = sut.Build();
            Assert.That(result, Is.EqualTo(player));
        }

        [Test]
        public void Build_Player_With_2_Building_Blocks()
        {
            var factory = StrictMock<IPlayerFactory>();
            var sut = new PlayerBuilder(factory.Object);
            var block1 = StrictMock<IPlayerBuildingBlock>();
            var block2 = StrictMock<IPlayerBuildingBlock>();
            sut.AddBuildingBlock(block1.Object);
            sut.AddBuildingBlock(block2.Object);

            var player = new Player();
            factory.Setup(f => f.Create()).Returns(player);
            block1.Setup(b => b.Build(player));
            block2.Setup(b => b.Build(player));

            var result = sut.Build();
            Assert.That(result, Is.EqualTo(player));
        }
    }
}