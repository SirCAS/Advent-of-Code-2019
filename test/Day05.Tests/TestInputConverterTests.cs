using NUnit.Framework;

namespace Day05.Tests
{
    public class TestInputConverterTests
    {
        [Test]
        public void Parse_Test()
        {
            // Arrange
            var str = "12,14,1969,100756";
            var expectedResults = new[] {12, 14, 1969, 100756};

            // Act
            var results = TestInputConverter.Parse(str);

            // Assert
            for (var i = 0; i < results.Length; ++i)
            {
                Assert.That(results[i], Is.EqualTo(expectedResults[i]));
            }
        }
    }
}