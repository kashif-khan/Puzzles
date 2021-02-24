using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(string s)
    {
        var map = new Dictionary<char, List<int>>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!map.ContainsKey(s[i]))
            {
                map.Add(s[i], new List<int>() { i });
            }
            else
            {
                map[s[i]].Add(i);
            }
        }

        var possibleAnagrams = map.Where(i => i.Value.Count > 1);

        int count = 0;

        foreach (var possibleAnagram in possibleAnagrams)
        {
            for (int i = 0; i < possibleAnagram.Value.Count - 1; i++)
            {
                if (CheckIfAnagram(possibleAnagram.Value[i], possibleAnagram.Value[i + 1], s))
                {
                    count++;
                }
            }

            count++;
        }

        return count;
    }

    private static bool CheckIfAnagram(int start, int end, string s)
    {
        while (start <= end)
        {
            if (s[start++] != s[end--])
            {
                return false;
            }
        }
        if (start == end || start > end)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main(string[] args)
    {

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = sherlockAndAnagrams(s);

        }

    }
}
