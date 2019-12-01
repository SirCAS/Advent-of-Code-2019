using System;
using System.Collections.Generic;
using System.IO;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+---------------------+");
            Console.WriteLine("| Advent of code 2019 |");
            Console.WriteLine("+---------------------+");

            var input = File.ReadAllText("input.txt");
            var testInput = TestInputConverter.Parse(input);
            var requiredFuel = FuelCounterUpper.Sum(testInput);
            var requiredFuelUsingCheck = FuelCounterUpper.SumUsingDoubleChecker(testInput);
            
            Console.WriteLine($"What is the sum of the fuel requirements for all of the modules on your spacecraft? It is {requiredFuel} and {requiredFuelUsingCheck} using Rocket Equation Double-Checker");
        }
    }
}