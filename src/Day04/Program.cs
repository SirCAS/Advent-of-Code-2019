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

            var unvalidatedPasswords = PasswordGenerator.FromInterval(puzzleInput); 
            
            var validPasswordsForPart1 = 
                unvalidatedPasswords
                    .Where(PasswordValidator.NeverDecreases)
                    .Where(PasswordValidator.HasDouble)
                    .Count();
            
            Console.WriteLine($"Part1: {validPasswordsForPart1}");
            
            var validPasswordsForPart2 = 
                unvalidatedPasswords
                    .Where(PasswordValidator.NeverDecreases)
                    .Where(PasswordValidator.HasDoubleWhichIsNotTriple)
                    .Count();
            
            Console.WriteLine($"Part2: {validPasswordsForPart2}");
        }
    }
}