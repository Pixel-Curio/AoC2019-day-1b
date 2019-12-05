using System;
using System.IO;
using System.Linq;

namespace Day_1b
{
    class Program
    {
        private const string InputPath = @"day1a-input.txt";

        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines(InputPath);
            Console.WriteLine(inputs.Select(int.Parse).Select(x => AccumulateFuel(0, x).Item1).Sum());
            Console.ReadKey();
        }

        private static (int, int) AccumulateFuel(int total, int remaining)
        {
            int additionalFuel = remaining / 3 - 2;
            return additionalFuel > 0 ? AccumulateFuel(total + additionalFuel, additionalFuel) : (total, 0);
        }
    }
}
