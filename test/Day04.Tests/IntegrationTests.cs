using System.Linq;
using NUnit.Framework;

namespace Day04.Tests
{
    public class IntegrationTests
    {
        const string PuzzleInput = "137683-596253";
        
        [Test]
        public void Part1_Test()
        {
            // Arrange + Act
            var validPasswords = PasswordGenerator
                .FromInterval(PuzzleInput)
                .Where(PasswordValidator.NeverDecreases)
                .Where(PasswordValidator.HasDouble)
                .Count();

            // Assert
            Assert.That(validPasswords, Is.EqualTo(1864));
        }
        
        [Test]
        public void Part2_Test()
        {
            // Arrange + Act
            var validPasswords = PasswordGenerator
                .FromInterval(PuzzleInput)
                .Where(PasswordValidator.NeverDecreases)
                .Where(PasswordValidator.HasDoubleWhichIsNotTriple)
                .Count();

            // Assert
            Assert.That(validPasswords, Is.EqualTo(1258));
        }
    }
}