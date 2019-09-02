using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class SlantedCipher
    {
        public static string Solve(int numberOfRows, string encodedString)
        {
            var output = new StringBuilder();
            var eachRowLength = encodedString.Length / numberOfRows;
            for (int columnIndex = 0; columnIndex < eachRowLength; columnIndex++)
            {
                ParseCharacter(encodedString, output, columnIndex);
                for (int rowIndex = 1, charIndex = columnIndex + eachRowLength + 1; rowIndex < numberOfRows && charIndex <= encodedString.Length - 1; charIndex = columnIndex + (eachRowLength * rowIndex) + rowIndex)
                {
                    ParseCharacter(encodedString, output, charIndex);
                    rowIndex++;
                }
            }
            return output.ToString().TrimEnd();
        }

        private static void ParseCharacter(string encodedString, StringBuilder output, int columnIndex)
        {
            if (encodedString[columnIndex] == '_')
            {
                output.Append(" ");
            }
            else
            {
                output.Append(encodedString[columnIndex]);
            }
        }
    }
}
