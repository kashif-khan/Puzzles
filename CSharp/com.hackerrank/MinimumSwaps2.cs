using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class MinimumSwaps2
    {
        public static int Solve(int[] inputArray)
        {
            int farthestCursor = inputArray.Length - 1;

            int cursor = 0;
            int minimumSwaps = 0;

            while (cursor < inputArray.Length)
            {
                int trueCurrentValue = cursor + 1;

                if (inputArray[cursor] == trueCurrentValue)
                {
                    cursor++;
                    continue;
                }

                while (inputArray[farthestCursor] != trueCurrentValue)
                {
                    farthestCursor--;
                }

                if (farthestCursor != cursor)
                {
                    Swap(inputArray, cursor, farthestCursor);
                    minimumSwaps++;
                }

                farthestCursor = inputArray.Length - 1;
                cursor++;
            }
            return minimumSwaps;
        }

        private static void Swap(int[] inputArray, int iterator, int nextiterator)
        {
            inputArray[iterator] = inputArray[iterator] + inputArray[nextiterator];
            inputArray[nextiterator] = inputArray[iterator] - inputArray[nextiterator];
            inputArray[iterator] = inputArray[iterator] - inputArray[nextiterator];
        }
    }
}
