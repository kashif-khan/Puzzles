using System;
using System.Collections.Generic;
#if DEBUG
using System.Diagnostics;
#endif
using System.Linq;

namespace CSharp.com.hackerrank
{
    /// https://www.hackerrank.com/challenges/2d-array/problem
    public class HourGlass
    {
        public static int Solve(int[][] inputArray)
        {
            var hourGlassValues = new HashSet<int>();
            int temp;
            for (int rowIndex = 0; rowIndex + 3 <= inputArray.GetLength(0); rowIndex++)
            {
                for (int columnIndex = 0; columnIndex + 3 <= inputArray.GetLength(0); columnIndex++)
                {
                    temp = 0;
#if DEBUG
                    Debug.WriteLine(string.Empty);

                    Debug.WriteLine($"{inputArray[rowIndex][columnIndex]} {inputArray[rowIndex][columnIndex + 1]} {inputArray[rowIndex][columnIndex + 2]}");
#endif
                    temp += inputArray[rowIndex][columnIndex];
                    temp += inputArray[rowIndex][columnIndex + 1];
                    temp += inputArray[rowIndex][columnIndex + 2];

#if DEBUG
                    Debug.WriteLine($" {inputArray[rowIndex + 1][columnIndex + 1]} ");
#endif
                    temp += inputArray[rowIndex + 1][columnIndex + 1];

#if DEBUG
                    Debug.WriteLine($"{inputArray[rowIndex + 2][columnIndex]} {inputArray[rowIndex + 2][columnIndex + 1]} {inputArray[rowIndex + 2][columnIndex + 2]}");
#endif
                    temp += inputArray[rowIndex + 2][columnIndex];
                    temp += inputArray[rowIndex + 2][columnIndex + 1];
                    temp += inputArray[rowIndex + 2][columnIndex + 2];
                    hourGlassValues.Add(temp);
                }
            }
            temp = hourGlassValues.Max<int>();
            return temp;
        }
    }
}