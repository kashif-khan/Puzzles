using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp.com.hackerrank
{
    public class NewYearChaos
    {
        private const string ImpossibleMessage = "Too chaotic";
        public static string Solve(int[] inputArray)
        {
            {
                int minimumBribeCount = 0;
                for (int iterator = inputArray.Length - 1; iterator >= 0; iterator--)
                {
                    if (inputArray[iterator] - (iterator + 1) > 2)
                    {
                        Console.WriteLine(ImpossibleMessage);
                        return ImpossibleMessage;
                    }
                    for (int minimumPossiblePosition = Math.Max(0, inputArray[iterator] - 2); minimumPossiblePosition < iterator; minimumPossiblePosition++)
                        if (inputArray[minimumPossiblePosition] > inputArray[iterator]) minimumBribeCount++;
                }
                Console.WriteLine(minimumBribeCount);
                return minimumBribeCount.ToString();
            }
        }
    }
}
