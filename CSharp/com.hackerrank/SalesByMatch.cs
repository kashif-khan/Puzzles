using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class SalesByMatch
    {
        /// <summary>
        /// Returns the number of pairs exist in the <paramref name="ar"/>
        /// </summary>
        /// <param name="n"></param>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static int SockMerchant(int n, int[] ar)
        {
            var lookup = new Dictionary<int, int>();
            foreach (var item in ar)
            {
                if (lookup.ContainsKey(item))
                {
                    lookup[item] += 1;
                }
                else
                {
                    lookup[item] = 1;
                }
            }

            int pairsCount = 0;

            foreach (var item in lookup)
            {
                pairsCount += (item.Value / 2);
            }
            return pairsCount;
        }
    }
}
