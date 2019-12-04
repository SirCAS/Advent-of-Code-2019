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
        
        [TestCase("0011", true)]
        [TestCase("00011", true)]
        [TestCase("001", true)]
        [TestCase("123", false)]
        [TestCase("000111", false)]
        [TestCase("112233", true)]
        [TestCase("123444", false)]
        [TestCase("111122", true)]
        [TestCase("1111", false)]
        [TestCase("11111", false)]
        [TestCase("111111", false)]
        [TestCase("1111111", false)]
        [TestCase("11111111", false)]
        public void HasDoubleWhichIsNotTriple_Test(string password, bool expected)
        {
            // Arrange + Act
            var isValid = PasswordValidator.HasDoubleWhichIsNotTriple(password);
            
            // Assert
            Assert.That(isValid, Is.EqualTo(expected));
        }
    }
}