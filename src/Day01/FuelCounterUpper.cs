using System;
using System.Linq;

namespace Day01
{
    public static class FuelCounterUpper
    {
        public static int Sum(int[] masses)
        {
            return masses.Sum(CalculateModule);
        }

        private static int CalculateModule(int mass)
        {
            var step1 = (double) mass / 3;
            var step2 = Math.Floor(step1);
            var step3 = step2 - 2;
            return Convert.ToInt32(step3);
        }
    }
}