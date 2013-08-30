﻿using Moq;

namespace FootballSim.Models.Tests
{
    /// <summary>
    ///   TODO: move this to a new common test project (FootballSim.Tests.Common?)
    /// </summary>
    public class BaseTestFixture
    {
        // Just some syntactical sugar.
        // Allows for slightly easier to read tests (don't need to use "new" everywhere)
        protected Mock<T> Mock<T>() where T : class
        {
            return new Mock<T>();
        }

        protected Mock<T> StrictMock<T>() where T : class
        {
            return new Mock<T>(MockBehavior.Strict);
        }
    }
}