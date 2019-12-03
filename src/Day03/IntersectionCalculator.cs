using System;
using System.Collections.Generic;
using System.Linq;
using Day03.Model;

namespace Day03
{
    public static class IntersectionCalculator
    {
        public static int GetClosetsDistance(List<List<CoordinateModel>> instructions)
        {
            return instructions
                .SelectMany(x => x.Distinct())
                .GroupBy(x => x)
                .Where(g => g.Count() > 1) 
                .Select(x => GetDistance(x.Key))
                .OrderBy(x => x)
                .First();
        }
        
        private static int GetDistance(CoordinateModel coordinate)
        {
            return Math.Abs(coordinate.X) + Math.Abs(coordinate.Y);
        }
    }
}