using NUnit.Framework;

namespace Day04.Tests
{
    public class PasswordGeneratorTests
    {
        [TestCase("1-1000", 999)]
        [TestCase("999-1000", 1)]
        [TestCase("0-1139", 1139)]
        public void IsValid_ShouldBeInvalid_Test(string interval, int combinations)
        {
            // Arrange + Act
            var passwords = PasswordGenerator.FromInterval(interval);
            
            // Assert
            Assert.That(passwords, Has.Count.EqualTo(combinations));
        }        
    }
}