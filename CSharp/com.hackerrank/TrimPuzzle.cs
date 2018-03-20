using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp.com.hackerrank
{
    public class TrimPuzzle
    {
        HashSet<string> values = new HashSet<string>();

        public List<string> Solve(string Input)
        {
            int start = 0, end = Input.Length;
            for (int i = start; i < end; i++)
            {
                SolveSub(Input.Substring(start, Input.Length - start));
                start += 1;
            }
            return values.ToList();
        }

        void SolveSub(string TrimmedInput)
        {
            for (int i = TrimmedInput.Length; i > 0; i--)
            {
                values.Add(TrimmedInput.Substring(0, i));
            }
        }
    }
}