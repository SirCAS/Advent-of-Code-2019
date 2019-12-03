using Day03.Model;
using NUnit.Framework;

namespace Day03.Tests
{
    public class TestInputParserTests
    {
        [Test]
        public void Parse_Test()
        {
            // Arrange
            var input = new[] { "R1003,U476,L876,U147,R127,D10,R857" };
            
            // Act
            var paths = TestInputParser.Parse(input);

            // Assert
            Assert.That(paths.Count, Is.EqualTo(1));
            var instructions = paths[0];
            
            AssertCommand(instructions[0], DirectionEnum.Right, 1003);
            AssertCommand(instructions[1], DirectionEnum.Up, 476);
            AssertCommand(instructions[2], DirectionEnum.Left, 876);
            AssertCommand(instructions[3], DirectionEnum.Up, 147);
            AssertCommand(instructions[4], DirectionEnum.Right, 127);
            AssertCommand(instructions[5], DirectionEnum.Down, 10);
            AssertCommand(instructions[6], DirectionEnum.Right, 857);
        }

        private void AssertCommand(InstructionModel instruction, DirectionEnum direction, int length)
        {
            Assert.That(instruction.Direction, Is.EqualTo(direction));
            Assert.That(instruction.Length, Is.EqualTo(length));
        }
    }
}