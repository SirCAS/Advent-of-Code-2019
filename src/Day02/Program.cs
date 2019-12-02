using System;
using System.IO;

namespace Day02
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
            
            //
            // Part 1
            //
            var part1Input = (int[]) testInput.Clone();
            
            // "replace position 1 with the value 12 and replace position 2 with the value 2"
            part1Input[1] = 12;
            part1Input[2] = 2;
            
            var output = IntCodeComputer.Run(part1Input);
            
            Console.WriteLine("Part 1: " + string.Join(',',output));
            
            //
            // Part 2
            //
            var part2Input = (int[]) testInput.Clone();
            
            var desiredOutput = 19690720;
            var solution = IntCodeBruteforce.Solve(desiredOutput, part2Input);
            
            Console.WriteLine("Part 2: " + solution);
        }
    }
}