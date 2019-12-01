using NUnit.Framework;

namespace Day01.Tests
{
    public class FuelCounterUpperTests
    {
        [TestCase(12, 2)]
        [TestCase(14, 2)]
        [TestCase(1969, 654)]
        [TestCase(100756, 33583)]
        public void Sum_Test(int mass, int correctSum)
        {
            // Arrange + act
            var result = FuelCounterUpper.Sum(new[] { mass });
            
            // Assert
            Assert.That(result, Is.EqualTo(correctSum));
        }
        
        [TestCase(14, 2)]
        [TestCase(1969, 966)]
        [TestCase(100756, 50346)]
        public void SumUsingDoubleChecker_Test(int mass, int correctSum)
        {
            // Arrange + act
            var result = FuelCounterUpper.SumUsingDoubleChecker(new[] { mass });
            
            // Assert
            Assert.That(result, Is.EqualTo(correctSum));
        }
    }
}