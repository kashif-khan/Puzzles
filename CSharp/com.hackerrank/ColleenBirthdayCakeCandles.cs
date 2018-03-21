using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    /// <summary>
    /// Colleen is having a birthday! She will have a cake with one candle for each year of her age. When she blows out the candles, she’ll only be able to blow out the tallest ones.
    ///Find and print the number of candles she can successfully blow out.
    /// https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    /// </summary>
    public class ColleenBirthdayCakeCandles
    {
        public int Solve(int age, int[] candleHeights)
        {
            if (age > 0 && candleHeights.Length > 0)
            {
                int tallestCandleHeight = candleHeights[0];
                int noOfCandlesColleenCanBlow = 0;
                for (int i = 0; i < candleHeights.Length; i++)
                {
                    if (candleHeights[i] > tallestCandleHeight)
                    {
                        noOfCandlesColleenCanBlow = 1;
                        tallestCandleHeight = candleHeights[i];
                    }
                    else if (candleHeights[i] == tallestCandleHeight)
                    {
                        noOfCandlesColleenCanBlow++;
                    }
                }
                return noOfCandlesColleenCanBlow;
            }
            return -1;
        }
    }
}
