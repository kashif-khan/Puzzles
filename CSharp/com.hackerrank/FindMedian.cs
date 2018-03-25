using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class FindMedian
    {
        public int Solve(int[] input)
        {
            if (input.Length > 0)
            {
                int sum = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    sum += input[i];
                }
                return sum / input.Length;
            }
            return -1;
        }
    }
}
