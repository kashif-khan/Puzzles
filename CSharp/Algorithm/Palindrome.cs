using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Algorithm
{
    public class Palindrome
    {
        public bool IsPalindrome(string input, bool IsCaseSensitive = true)
        {
            if (IsCaseSensitive)
            {
                input = input.ToLowerInvariant();
            }
            int head = 0, tail = input.Length - 1;
            while (head <= tail && !input[head--].Equals(input[tail--]))
            {
                return false;
            }
            return true;
        }
    }
}
