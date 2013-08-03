using Moq;

namespace FootballSim.Tests
{
    public class BaseTestFixture
    {
        // Allows for slightly easier to read tests (don't need to use "new" everywhere)
        public Mock<T> Mock<T>() where T : class
        {
            return new Mock<T>();
        }
    }
}
