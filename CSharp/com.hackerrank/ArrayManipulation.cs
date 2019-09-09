using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class ArrayManipulation
    {
        public static long Solve(uint specimenArrayLength, int[][] queries)
        {
            long[] numList = new long[specimenArrayLength + 1];

            for (int iterator = 0; iterator < queries.GetLength(0); iterator++)
            {
                uint fromIndex = (UInt32)queries[iterator][0];
                uint toIndex = (UInt32)queries[iterator][1];
                long valueToBeAdded = (long)queries[iterator][2];

                numList[fromIndex] += valueToBeAdded;
                if (toIndex + 1 <= specimenArrayLength) numList[toIndex + 1] -= valueToBeAdded;
            }

            long tempMax = 0;
            long maximumNumber = 0;
            for (int iterator = 1; iterator <= specimenArrayLength; iterator++)
            {
                tempMax += numList[iterator];
                if (tempMax > maximumNumber) maximumNumber = tempMax;
            }

            return maximumNumber;
        }

        private static long MyOldMethod(uint specimenArrayLength, int[][] queries)
        {
            long maximumNumber = 0;

            var specimenArray = new long[specimenArrayLength];
            for (int queryIterator = 0; queryIterator < queries.GetLength(0); queryIterator++)
            {
                int fromIndex = queries[queryIterator][0] - 1;
                int toIndex = queries[queryIterator][1] - 1;
                int valueToBeAdded = queries[queryIterator][2];
                for (int specimenIterator = fromIndex; specimenIterator <= toIndex; specimenIterator++)
                {
                    specimenArray[specimenIterator] += valueToBeAdded;
                    if (maximumNumber < specimenArray[specimenIterator])
                    {
                        maximumNumber = specimenArray[specimenIterator];
                    }
                }
            }

            return maximumNumber;
        }
    }
}
