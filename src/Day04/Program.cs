using System;
using System.Linq;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+---------------------+");
            Console.WriteLine("| Advent of code 2019 |");
            Console.WriteLine("+---------------------+");

            const string puzzleInput = "137683-596253";

            var validPasswords = PasswordGenerator
                .FromInterval(puzzleInput)
                .Where(PasswordValidator.NeverDecreases)
                .Where(PasswordValidator.HasDouble);
            
            Console.WriteLine($"Part1: {validPasswords.Count()}");
        }
    }
}