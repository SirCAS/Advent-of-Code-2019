using System;
using System.Collections.Generic;
using System.Linq;
using Day03.Model;

namespace Day03
{
    public static class TestInputParser
    {
        public static List<List<InstructionModel>> Parse(string[] input)
        {
            return input
                .Select(line => line.Split(',', StringSplitOptions.RemoveEmptyEntries))
                .Select(path => path.Select(command => new InstructionModel
                    {
                        Direction = Parse(command[0]),
                        Length = int.Parse(command.Substring(1))
                    }).ToList()
                ).ToList();
        }

        private static DirectionEnum Parse(char direction)
        {
            switch (direction)
            {
                case 'U': return DirectionEnum.Up;
                case 'D': return DirectionEnum.Down;
                case 'L': return DirectionEnum.Left;
                case 'R': return DirectionEnum.Right;
                default: throw new NotImplementedException("Unknown direction supplied");
            }
        }
    }
}