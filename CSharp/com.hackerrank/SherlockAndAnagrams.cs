using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace CSharp.com.hackerrank
{
    public class SherlockAndAnagrams
    {
        public static int Solve(string s)
        {
            var substringCountList = new Dictionary<string, int>();
            var pairsCount = 0;
            for (int len = 1; len <= s.Length - 1; len++)
                for (int i = 0; i <= s.Length - len; i++)
                {
                    var substring = new string(s.Substring(i, len).OrderBy(c => c).ToArray());
                    if (substringCountList.ContainsKey(substring))
                    {
                        pairsCount += substringCountList[substring];
                        substringCountList[substring] += 1;
                    }
                    else
                        substringCountList[substring] = 1;
                }

            return pairsCount;
        }
    }
}

