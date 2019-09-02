using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CSharp.com.hackerrank
{
    /// https://www.hackerrank.com/challenges/2d-array/problem
    public class HourGlass
    {
        public static int Solve(int[,] inputArray)
        {
            var hourGlassValues = new HashSet<int>();
            int temp;
            for (int rowIndex = 0; rowIndex < inputArray.GetLength(0) - 1; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < inputArray.GetLength(1) - 1; columnIndex++)
                {
                    temp = 0;
                    if (rowIndex + 2 >= inputArray.GetLength(0) || columnIndex + 2 >= inputArray.GetLength(1))
                        continue;
                    Debug.WriteLine(string.Empty);

                    Debug.WriteLine($"{inputArray[rowIndex, columnIndex]} {inputArray[rowIndex, columnIndex + 1]} {inputArray[rowIndex, columnIndex + 2]}");
                    temp += inputArray[rowIndex, columnIndex];
                    temp += inputArray[rowIndex, columnIndex + 1];
                    temp += inputArray[rowIndex, columnIndex + 2];

                    Debug.WriteLine($" {inputArray[rowIndex + 1, columnIndex + 1]} ");
                    temp += inputArray[rowIndex + 1, columnIndex + 1];

                    Debug.WriteLine($"{inputArray[rowIndex + 2, columnIndex]} {inputArray[rowIndex + 2, columnIndex + 1]} {inputArray[rowIndex + 2, columnIndex + 2]}");
                    temp += inputArray[rowIndex + 2, columnIndex];
                    temp += inputArray[rowIndex + 2, columnIndex + 1];
                    temp += inputArray[rowIndex + 2, columnIndex + 2];
                    hourGlassValues.Add(temp);
                }
            }
            temp = hourGlassValues.Max<int>();
            return temp;
        }
    }
}