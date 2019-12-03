using System.Collections.Generic;
using Day03.Model;
using NUnit.Framework;

namespace Day03.Tests
{
    public class RoutingGeneratorTests
    {
        [Test]
        public void GetCoordinates_Test()
        {
            // Arrange
            var instructions = new List<List<InstructionModel>>
            {
                new List<InstructionModel>
                {
                    new InstructionModel {Direction = DirectionEnum.Up, Length = 2},
                    new InstructionModel {Direction = DirectionEnum.Left, Length = 2},
                },
                new List<InstructionModel>
                {
                    new InstructionModel {Direction = DirectionEnum.Down, Length = 2},
                    new InstructionModel {Direction = DirectionEnum.Right, Length = 2},
                }
            };

            // Act
            var coordinates = RoutingGenerator.GetCoordinates(instructions);

            // Assert
            AssertCoordinate(coordinates[0][0], 0, 1);
            AssertCoordinate(coordinates[0][1], 0, 2);
            AssertCoordinate(coordinates[0][2], -1, 2);
            AssertCoordinate(coordinates[0][3], -2, 2);

            AssertCoordinate(coordinates[1][0], 0, -1);
            AssertCoordinate(coordinates[1][1], 0, -2);
            AssertCoordinate(coordinates[1][2], 1, -2);
            AssertCoordinate(coordinates[1][3], 2, -2);
        }

        private void AssertCoordinate(CoordinateModel coordinate, int x, int y)
        {
            Assert.That(coordinate.X, Is.EqualTo(x));
            Assert.That(coordinate.Y, Is.EqualTo(y));
        }
    }
}