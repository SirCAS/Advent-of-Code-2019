using NUnit.Framework;

namespace Day05.Tests
{
    public class IntCodeComputerTests
    {
        [Test]
        public void Case1_Run_Test()
        {
            // Arrange
            var instructions = new[] { 1002,4,3,4,33 };
            var input = new Input(1);

            // Act
            var output = IntCodeComputer.Run(instructions, input);

            // Assert
            Assert.That(output, Is.EqualTo(99));
        }

        [Test]
        public void Case2_Run_Test()
        {
            // Arrange
            var input = new[] {2, 3, 0, 3, 99};
            var expectedOutput = new[] {2, 3, 0, 6, 99};

            // Act
            var output = IntCodeComputer.Run(input);

            // Assert
            for (var i = 0; i < expectedOutput.Length; ++i)
            {
                Assert.That(output[i], Is.EqualTo(expectedOutput[i]));
            }
        }

        [Test]
        public void Case3_Run_Test()
        {
            // Arrange
            var input = new[] {2, 4, 4, 5, 99, 0};
            var expectedOutput = new[] {2, 4, 4, 5, 99, 9801};

            // Act
            var output = IntCodeComputer.Run(input);

            // Assert
            for (var i = 0; i < expectedOutput.Length; ++i)
            {
                Assert.That(output[i], Is.EqualTo(expectedOutput[i]));
            }
        }

        [Test]
        public void Case4_Run_Test()
        {
            // Arrange
            var input = new[] {1, 1, 1, 4, 99, 5, 6, 0, 99};
            var expectedOutput = new[] {30, 1, 1, 4, 2, 5, 6, 0, 99};

            // Act
            var output = IntCodeComputer.Run(input);

            // Assert
            for (var i = 0; i < expectedOutput.Length; ++i)
            {
                Assert.That(output[i], Is.EqualTo(expectedOutput[i]));
            }
        }
    }
}