using System.Linq;
using NUnit.Framework;

namespace Day04.Tests
{
    public class IntegrationTests
    {
        [Test]
        public void Part1_Test()
        {
            // Arrange
            const string puzzleInput = "137683-596253";

            // Act
            var validPasswords = PasswordGenerator
                .FromInterval(puzzleInput)
                .Where(PasswordValidator.NeverDecreases)
                .Where(PasswordValidator.HasDouble);

            // Assert
            Assert.That(validPasswords.Count(), Is.EqualTo(1864));
        }
    }
}