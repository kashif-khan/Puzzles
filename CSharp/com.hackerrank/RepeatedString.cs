using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class RepeatedString
    {
        private const char characterToCompare = 'a';

        public static long Solve(string inputString, long repeatCount)
        {
            long count = 0;
            long residueIndex = inputString.Length;
            long multiplier = 0;
            long residueCount = 0, multiplierCount = 0;

            residueIndex = repeatCount % inputString.Length;
            multiplier = repeatCount / inputString.Length;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == characterToCompare)
                {
                    if (i < residueIndex)
                    {
                        residueCount++;
                    }
                    multiplierCount++;
                }

            }

            count = (multiplier * multiplierCount) + residueCount;
            return count;
        }
    }
}
