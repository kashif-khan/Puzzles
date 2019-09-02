using System;
using System.Diagnostics;

namespace CSharp.com.hackerrank
{
    public class ConsecutiveSum
    {
        public static int Solve(long num)
        {
            long sumOfFirstIntegers = 3;
            long possibleConsecutiveSumCount = 0;
            for (long iteration = 2; sumOfFirstIntegers <= num; ++iteration)
            {
                if ((iteration % 2 == 0) ? (num % iteration == iteration / 2) : (num % iteration == 0))
                {
                    ++possibleConsecutiveSumCount;
                }
                sumOfFirstIntegers += iteration + 1;
            }
            return (int)possibleConsecutiveSumCount;
        }
    }
}