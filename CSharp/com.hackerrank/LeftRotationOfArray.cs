using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    /// <summary>
    /// Arrays - Left Rotation.pdf
    /// </summary>
    public class LeftRotationOfArray
    {
        public static int[] Solve(int[] inputArray, int numbersToShift)
        {
            var cursor = numbersToShift;
            var rotatedArray = new int[inputArray.Length];
            for (int iterator = 0; iterator < inputArray.Length; iterator++, cursor = ++cursor % inputArray.Length)
            {
                rotatedArray[iterator] = inputArray[cursor];
            }
            return rotatedArray;
        }
    }
}
