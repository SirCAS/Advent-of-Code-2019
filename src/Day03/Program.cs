using System;
using System.IO;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+---------------------+");
            Console.WriteLine("| Advent of code 2019 |");
            Console.WriteLine("+---------------------+");

            var input = File.ReadAllLines("input.txt");
            var paths = TestInputParser.Parse(input);
            var coordinates = RoutingGenerator.GetCoordinates(paths);
            
            var shortestDistance = IntersectionCalculator.GetClosetsDistance(coordinates);
            var fewestSteps = IntersectionCalculator.GetFewestSteps(coordinates);
            
            Console.WriteLine($"Part1: {shortestDistance}");
            Console.WriteLine($"Part2: {fewestSteps}");
        }
    }
}