using System;
using System.Linq;

namespace Day01
{
    public static class TestInputConverter
    {
        public static int[] Parse(string input)
        {
            return input
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}