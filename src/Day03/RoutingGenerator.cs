using System;
using System.Collections.Generic;
using System.Linq;
using Day03.Model;

namespace Day03
{
    public static class RoutingGenerator
    {
        public static List<List<CoordinateModel>> GetCoordinates(List<List<InstructionModel>> instructions)
        {
            return instructions.Select(GetCoordinates).ToList();
        }
        
        public static List<CoordinateModel> GetCoordinates(List<InstructionModel> instructions)
        {
            var pos = new List<CoordinateModel> { new CoordinateModel() };
            
            foreach (var instruction in instructions)
            {
                CoordinateModel vector;
                switch (instruction.Direction)
                {
                    case DirectionEnum.Up:    vector = new CoordinateModel { Y =  1 }; break;
                    case DirectionEnum.Down:  vector = new CoordinateModel { Y = -1 }; break;
                    case DirectionEnum.Right: vector = new CoordinateModel { X =  1 }; break;
                    case DirectionEnum.Left:  vector = new CoordinateModel { X = -1 }; break;
                    default:
                        throw new NotSupportedException("Unsupported direction provided");
                }

                for (int i = 0; i < instruction.Length; i++)
                {
                    var prev = pos.Last();
                    pos.Add(new CoordinateModel
                    {
                        X = prev.X + vector.X,
                        Y = prev.Y + vector.Y
                    });
                }
            }

            return pos.Skip(1).ToList();
        }
    }
}