using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.Attempts.Exercises
{
    public static class Squares
    {
        // http://exercism.io/exercises/csharp/difference-of-squares/readme

        public static int SquareOfSums(int count)
        {
            int output = 0;

            // (1 + 2 + ... + 10)² = 55² = 3025
            for (int i = 0; i <= count; i++)
            {
                output += i;
            }
            return output * output;
        }

        public static int SumOfSquares(int count)
        {
            int output = 0;

            // 1² + 2² + ... + 10² = 385
            for (int i = 0; i <= count; i++)
            {
                output += (i * i);
            }
            return output;
        }

        public static int DifferenceOfSquares(int count)
        {
            // 3025 - 385 = 2640
            int squareSums = SquareOfSums(count);
            int sumSquares = SumOfSquares(count);

            return squareSums - sumSquares;
        }
    }
}
