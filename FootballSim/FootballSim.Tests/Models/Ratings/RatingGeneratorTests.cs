using FootballSim.Models;
using FootballSim.Models.Draft;
using FootballSim.Models.Ratings;
using NUnit.Framework;

namespace FootballSim.Tests.Models.Ratings
{
    [TestFixture]
    public class RatingGeneratorTests : BaseTestFixture
    {
        [Test]
        public void Generate_For_BlueChip()
        {
            var random = StrictMock<IRandomService>();
            var factory = StrictMock<IRatingFactory>();
            var sut = new RatingGenerator(random.Object, factory.Object);
            random.Setup(r => r.GetRandom(80, 100)).Returns(90);
            var rating = new Rating();
            factory.Setup(f => f.Create(90)).Returns(rating);

            var result = sut.Generate(Caliber.BlueChip);
            random.Verify(r => r.GetRandom(80, 100));
            factory.Verify(f=>f.Create(90));
            Assert.That(result, Is.EqualTo(rating));
        }

        [Test]
        public void Generate_For_High()
        {
            var random = StrictMock<IRandomService>();
            var factory = StrictMock<IRatingFactory>();
            var sut = new RatingGenerator(random.Object, factory.Object);
            random.Setup(r => r.GetRandom(70, 90)).Returns(80);
            var rating = new Rating();
            factory.Setup(f => f.Create(80)).Returns(rating);

            var result = sut.Generate(Caliber.High);
            random.Verify(r => r.GetRandom(70, 90));
            factory.Setup(f => f.Create(80));
            Assert.That(result, Is.EqualTo(rating));
        }

        [Test]
        public void Generate_For_Average()
        {
            var random = StrictMock<IRandomService>();
            var factory = StrictMock<IRatingFactory>();
            var sut = new RatingGenerator(random.Object, factory.Object);
            random.Setup(r => r.GetRandom(50, 90)).Returns(70);
            var rating = new Rating();
            factory.Setup(f => f.Create(70)).Returns(rating);

            var result = sut.Generate(Caliber.Average);
            random.Verify(r => r.GetRandom(50, 90));
            factory.Setup(f => f.Create(70));
            Assert.That(result, Is.EqualTo(rating));
        }

        [Test]
        public void Generate_For_Scrub()
        {
            var random = StrictMock<IRandomService>();
            var factory = StrictMock<IRatingFactory>();
            var sut = new RatingGenerator(random.Object, factory.Object);
            random.Setup(r => r.GetRandom(50, 70)).Returns(60);
            var rating = new Rating();
            factory.Setup(f => f.Create(60)).Returns(rating);

            var result = sut.Generate(Caliber.Scrub);
            random.Verify(r => r.GetRandom(50, 70));
            factory.Setup(f => f.Create(60));
            Assert.That(result, Is.EqualTo(rating));
        }
    }
}