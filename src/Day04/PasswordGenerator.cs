using System;
using System.Collections.Generic;
using System.Linq;

namespace Day04
{
    public static class PasswordGenerator
    {
        public static List<string> FromInterval(string interval)
        {
            var points = interval.Split('-');
            
            if(points.Length != 2)
                throw new ArgumentException("Invalid format for interval");

            var start = int.Parse(points[0]);
            var end = int.Parse(points[1]);

            return FromInterval(start, end);
        }
        
        private static List<string> FromInterval(int start, int end)
        {
            return Enumerable
                .Range(start, end - start)
                .Select(i => i.ToString())
                .ToList();
        }
    }
}