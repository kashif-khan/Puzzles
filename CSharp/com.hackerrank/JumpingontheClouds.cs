using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class JumpingOnTheClouds
    {
        public static int Solve(int[] inputArray)
        {
            var minimumJumps = 0;
            var jump = 0;
            while (jump < inputArray.Length - 1)
            {
                if (jump + 2 < inputArray.Length && inputArray[jump + 2] != 1)
                {
                    jump += 2;
                }
                else
                {
                    jump++;
                }
                minimumJumps++;
            }
            return minimumJumps;
        }
    }
}
