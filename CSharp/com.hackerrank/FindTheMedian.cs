using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class FindTheMedian
    {
        public int Solve(int[] input)
        {
            List<int> list = input.ToList();
            list.Sort();
            return list[(int)(list.Count / 2)];
        }
    }
}
