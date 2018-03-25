using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    /// <summary>
    /// Given an unsorted array of integers, find a pair with given sum in it
    /// Source: http://www.techiedelight.com/find-pair-with-given-sum-array/ in java
    /// </summary>
    public class FindPairWithGivenSumInTheArray
    {
        public List<string> Solve(int[] inputArray, int sum)
        {
            var output = new List<string>();
            var map = new Dictionary<int, int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (map.ContainsKey((sum - inputArray[i])))
                {
                    output.Add($"{map[(sum - inputArray[i])]}:{i}");
                }
                map.Add(inputArray[i], i);
            }
            return output;
        }
    }
}
