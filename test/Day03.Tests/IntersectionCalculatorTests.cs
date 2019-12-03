using System.Collections.Generic;
using Day03.Model;
using NUnit.Framework;

namespace Day03.Tests
{
    public class IntersectionCalculatorTests
    {
        [Test]
        public void GetFewestSteps_CalculateSteps_Test()
        {
            // Arrange
            var coordinates = new List<List<CoordinateModel>>
            {
                new List<CoordinateModel>
                {
                    new CoordinateModel {X = 1, Y = 1},
                    new CoordinateModel {X = 2, Y = 1},
                    new CoordinateModel {X = 3, Y = 1},
                    new CoordinateModel {X = 4, Y = 1},
                    new CoordinateModel {X = 5, Y = 1},
                    new CoordinateModel {X = 6, Y = 1},
                },
                new List<CoordinateModel>
                {
                    new CoordinateModel {X = 1, Y = -1},
                    new CoordinateModel {X = 1, Y = 0},
                    new CoordinateModel {X = 1, Y = 1},
                    new CoordinateModel {X = 1, Y = 2},
                    new CoordinateModel {X = 1, Y = 3},
                    new CoordinateModel {X = 1, Y = 2},
                    new CoordinateModel {X = 1, Y = 1},
                    new CoordinateModel {X = 2, Y = 1},
                    new CoordinateModel {X = 3, Y = 1},
                    new CoordinateModel {X = 4, Y = 1},
                    new CoordinateModel {X = 5, Y = 1},
                    new CoordinateModel {X = 6, Y = 1},
                    new CoordinateModel {X = 7, Y = 1},
                }
            };

            // Act
            var steps = IntersectionCalculator.GetFewestSteps(coordinates);

            // Assert
            Assert.That(steps, Is.EqualTo(4));
        }

        [Test]
        public void GetClosetsDistance_CalculateDistance_Test()
        {
            // Arrange
            var coordinates = new List<List<CoordinateModel>>
            {
                new List<CoordinateModel>
                {
                    new CoordinateModel {X = 1, Y = 1},
                    new CoordinateModel {X = 2, Y = 1},
                    new CoordinateModel {X = 3, Y = 1},
                    new CoordinateModel {X = 4, Y = 1},
                    new CoordinateModel {X = 5, Y = 1},
                    new CoordinateModel {X = 6, Y = 1},
                },
                new List<CoordinateModel>
                {
                    new CoordinateModel {X = 1, Y = -1},
                    new CoordinateModel {X = 1, Y = 0},
                    new CoordinateModel {X = 1, Y = 1},
                    new CoordinateModel {X = 1, Y = 2},
                    new CoordinateModel {X = 1, Y = 3},
                    new CoordinateModel {X = 1, Y = 2},
                    new CoordinateModel {X = 1, Y = 1},
                    new CoordinateModel {X = 2, Y = 1},
                    new CoordinateModel {X = 3, Y = 1},
                    new CoordinateModel {X = 4, Y = 1},
                    new CoordinateModel {X = 5, Y = 1},
                    new CoordinateModel {X = 6, Y = 1},
                    new CoordinateModel {X = 7, Y = 1},
                }
            };

            // Act
            var distance = IntersectionCalculator.GetClosetsDistance(coordinates);

            // Assert
            Assert.That(distance, Is.EqualTo(2));
        }
    }
}