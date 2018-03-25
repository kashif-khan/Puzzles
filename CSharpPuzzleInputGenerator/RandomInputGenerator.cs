using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPuzzleInputGenerator
{
    public class RandomInputGenerator
    {
        public int[] GetRandomUnsortedArray(int n, int min = 0, int max = 100)
        {
            var output = new int[n];
            var rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                rnd.Next(min, max);
            }
            return output;
        }
    }
}
