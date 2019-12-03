using System;
using System.Collections.Generic;
using System.Linq;
using Day03.Model;

namespace Day03
{
    public static class IntersectionCalculator
    {
        public static int? GetFewestSteps(List<List<CoordinateModel>> instructions)
        {
            var pathOne = instructions[0];
            var pathTwo = instructions[1];

            var commons = pathOne.Intersect(pathTwo);

            int? minSteps = null;
            
            foreach (var common in commons)
            {
                var steps = 
                    pathOne.FindIndex(x => x.Equals(common)) + 
                    pathTwo.FindIndex(x => x.Equals(common)) +
                    2;
                
                if (minSteps.HasValue)
                {
                    if (minSteps.Value > steps)
                    {
                        minSteps = steps;
                    }
                }
                else
                {
                    minSteps = steps;
                }
            }
            
            
//            var intersections = instructions
//                .SelectMany(x => x.Distinct())
//                .GroupBy(x => x)
//                .Where(x => x.Count() > 1)
//                .Select(x => x.Key);

            return minSteps;

        }


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