using Moq;

namespace FootballSim.Tests
{
    public class BaseTestFixture
    {
        public Mock<T> Mock<T>() where T : class
        {
            return new Mock<T>(MockBehavior.Strict);
        }
    }
}
