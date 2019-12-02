using System;
using System.Linq;

namespace Day02
{
    public static class TestInputConverter
    {
        public static int[] Parse(string input)
        {
            return input
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}