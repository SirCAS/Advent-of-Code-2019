using NUnit.Framework;

namespace Day04.Tests
{
    public class PasswordValidatorTests
    {
        [TestCase("110011", true)]
        [TestCase("022", true)]
        [TestCase("77", true)]
        [TestCase("09", false)]
        [TestCase("0000", true)]
        [TestCase("1234567", false)]
        public void HasDouble_Test(string password, bool expected)
        {
            // Arrange + Act
            var isValid = PasswordValidator.HasDouble(password);
            
            // Assert
            Assert.That(isValid, Is.EqualTo(expected));
        }

        [TestCase("12", true)]
        [TestCase("21", false)]
        [TestCase("246", true)]
        [TestCase("9876", false)]
        [TestCase("1230", false)]
        public void NeverDecreases_Test(string password, bool expected)
        {
            // Arrange + Act
            var isValid = PasswordValidator.NeverDecreases(password);
            
            // Assert
            Assert.That(isValid, Is.EqualTo(expected));
        }
    }
}