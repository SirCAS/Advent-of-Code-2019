using NUnit.Framework;

namespace Day03.Tests
{
    public class IntegrationTests
    {
        [Test]
        public void Example1_Test()
        {
            // Arrange
            var input = new[]
            {
                "R75,D30,R83,U83,L12,D49,R71,U7,L72",
                "U62,R66,U55,R34,D71,R55,D58,R83"
            };
            
            // Act
            var paths = TestInputParser.Parse(input);
            var coordinates = RoutingGenerator.GetCoordinates(paths);
            var shortestDistance = IntersectionCalculator.GetClosetsDistance(coordinates);
            
            // Assert
            Assert.That(shortestDistance, Is.EqualTo(159));
        }
        
        [Test]
        public void Example2_Test()
        {
            // Arrange
            var input = new[]
            {
                "R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51",
                "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7"
            };
            
            // Act
            var paths = TestInputParser.Parse(input);
            var coordinates = RoutingGenerator.GetCoordinates(paths);
            var shortestDistance = IntersectionCalculator.GetClosetsDistance(coordinates);
            
            // Assert
            Assert.That(shortestDistance, Is.EqualTo(135));
        }
        
        [Test]
        public void Example3_Test()
        {
            // Arrange
            var input = new[]
            {
                "R8,U5,L5,D3",
                "U7,R6,D4,L4"
            };
            
            // Act
            var paths = TestInputParser.Parse(input);
            var coordinates = RoutingGenerator.GetCoordinates(paths);
            var shortestDistance = IntersectionCalculator.GetClosetsDistance(coordinates);
            
            // Assert
            Assert.That(shortestDistance, Is.EqualTo(6));
        }
    }
}