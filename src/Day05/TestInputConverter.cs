using System;
using System.Linq;

namespace Day05
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