using NUnit.Framework;

namespace Day02.Tests
{
    public class IntCodeBruteforceTests
    {
        [Test]
        public void Solve_Test()
        {
            // Arrange
            var memory = new [] { 1, 5, 5, 0, 99, 4 };
            const int desiredOutput = 8;
            const int expectedResults = 505;
            
            // Act
            var result = IntCodeBruteforce.Solve(desiredOutput, memory);
            
            // Assert
            Assert.That(result, Is.EqualTo(expectedResults));
        }
    }
}