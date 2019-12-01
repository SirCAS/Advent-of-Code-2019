using System;
using System.Linq;
using System.Reflection;

namespace Day01
{
    public static class FuelCounterUpper
    {
        public static int Sum(int[] masses)
        {
            return masses.Sum(CalculateModule);
        }

        public static int SumUsingDoubleChecker(int[] masses)
        {
            return masses.Sum(mass =>
            {
                var result = 0;
                var iteration = CalculateModule(mass);
                while (iteration > 0)
                {
                    result += iteration;
                    iteration = CalculateModule(iteration);
                }

                return result;
            });
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