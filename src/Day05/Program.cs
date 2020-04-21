using System;
using System.IO;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+---------------------+");
            Console.WriteLine("| Advent of code 2019 |");
            Console.WriteLine("+---------------------+");
            
            var rawProgram = File.ReadAllText("input.txt");
            var program = TestInputConverter.Parse(rawProgram);
            var input = new Input(1);

            var diagnosticCode = IntCodeComputer.Run(program, input);
            
            Console.WriteLine();
            
        }
    }
    
    public interface IInput
    {
        int Get();
    }

    public class Input : IInput
    {
        private readonly int _value;
        public Input(int value)
        {
            this._value = value;
        }

        public int Get()
        {
            return this._value;
        }
    }

}