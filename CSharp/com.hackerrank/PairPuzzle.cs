using System;

namespace CSharp.com.hackerrank
{
    public class PairPuzzle
    {
        public static int Solve(int[] v2)
        {
            bool PairNotSatisfied = false;
            int previous = v2[0];
            int i = 1;
            for (; i < v2.Length; i++)
            {
                if (previous != v2[i])
                {
                    PairNotSatisfied = true;
                    break;
                }
                previous = v2[i];
            }
            if (PairNotSatisfied)
            {
                if (--i % 2 == 0)
                {
                    return previous;
                }
                else
                {
                    return v2[++i];
                }
            }
            else
                return -1;
        }
    }
}