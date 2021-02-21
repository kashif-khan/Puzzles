using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    /// <summary>
    /// 
    /// </summary>
    public class TwoStrings
    {
        public string Solve(string s1, string s2)
        {
            const string YES = nameof(YES);
            const string NO = nameof(NO);

            var lookup = new HashSet<char>(s2.ToArray());

            foreach (var item in s1)
            {
                if (lookup.Contains(item))
                {
                    return YES;
                }
            }
            return NO;
        }
    }
}
