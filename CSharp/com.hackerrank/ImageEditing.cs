using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class ImageEditing
    {
        public static int Solve(List<List<int>> arr)
        {
            int[,] inputArray = ConvertToMultidimensionalArray(arr);

            int rowIndex, columnIndex;

            int rows = inputArray.GetLength(0);

            int columns = inputArray.GetLength(1);

            int[,] submatrix = new int[rows, columns];

            int submatrixMax, rowMax, columnMax;

            InitializeSubmatrix(inputArray, out rowIndex, out columnIndex, rows, columns, submatrix);

            rowIndex = CalculateSubmatrix(inputArray, ref columnIndex, rows, columns, submatrix);

            submatrixMax = submatrix[0, 0];
            rowMax = 0;
            columnMax = 0;

            rowIndex = FindMaxEntry(ref columnIndex, rows, columns, submatrix, ref submatrixMax, ref rowMax, ref columnMax);

            return submatrixMax;
        }

        private static int FindMaxEntry(ref int columnIndex, int rows, int columns, int[,] submatrix, ref int submatrixMax, ref int rowMax, ref int columnMax)
        {
            int rowIndex;
            /* Find the maximum entry, and indexes of  maximum entry in submatrixMax[, ] */
            for (rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                for (columnIndex = 0; columnIndex < columns; columnIndex++)
                {
                    if (submatrixMax < submatrix[rowIndex, columnIndex])
                    {
                        submatrixMax = submatrix[rowIndex, columnIndex];
                        rowMax = rowIndex;
                        columnMax = columnIndex;
                    }
                }
            }

            return rowIndex;
        }

        private static int CalculateSubmatrix(int[,] inputArray, ref int columnIndex, int rows, int columns, int[,] submatrix)
        {
            int rowIndex;

            /* Construct other entries of submatrix[, ]*/
            for (rowIndex = 1; rowIndex < rows; rowIndex++)
            {
                for (columnIndex = 1; columnIndex < columns; columnIndex++)
                {
                    if (inputArray[rowIndex, columnIndex] == 1)
                        submatrix[rowIndex, columnIndex] = Math.Min(submatrix[rowIndex, columnIndex - 1], Math.Min(submatrix[rowIndex - 1, columnIndex], submatrix[rowIndex - 1, columnIndex - 1])) + 1;
                    else
                        submatrix[rowIndex, columnIndex] = 0;
                }
            }

            return rowIndex;
        }

        private static void InitializeSubmatrix(int[,] inputArray, out int rowIndex, out int columnIndex, int rows, int columns, int[,] submatrix)
        {
            /* Set first column of submatrix[, ]*/
            for (rowIndex = 0; rowIndex < rows; rowIndex++)
                submatrix[rowIndex, 0] = inputArray[rowIndex, 0];

            /* Set first row of submatrix[, ]*/
            for (columnIndex = 0; columnIndex < columns; columnIndex++)
                submatrix[0, columnIndex] = inputArray[0, columnIndex];
        }

        private static int[,] ConvertToMultidimensionalArray(List<List<int>> arr)
        {
            var M = new int[arr.Count, arr.Count];

            int rowIndex = 0, columnIndex = 0;
            foreach (var row in arr)
            {
                columnIndex = 0;
                foreach (var rowColumnValue in row)
                {
                    M[rowIndex, columnIndex++] = rowColumnValue;
                }
                rowIndex++;
            }

            return M;
        }
    }
}
