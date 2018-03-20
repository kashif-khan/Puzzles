using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    /// <summary>
    /// 
    /// Ref: https://www.hackerrank.com/challenges/time-conversion/problem
    /// </summary>
    public class TimeConversionPuzzle
    {
        public string Solve(string Input)
        {
            if (Input.EndsWith("PM"))
            {
                if (Input.StartsWith("12"))
                {
                    return Input.Substring(0, Input.Length - 2);
                }
                var hour = Convert.ToInt32(Input.Substring(0, 2)) + 12;
                return $"{hour}{Input.Substring(2, Input.Length - 4)}";
            }
            var output = Input.Substring(0, Input.Length - 2);
            if (Input.StartsWith("12"))
            {
                output = $"00{output.Substring(2, output.Length - 2)}";
            }
            return output;
        }
    }
}
