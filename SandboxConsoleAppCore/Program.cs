﻿using System.CodeDom.Compiler;
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

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {
        const string Yes = nameof(Yes);
        const string No = nameof(No);

        if ((magazine.Length < note.Length) || magazine.Length < 1 || note.Length < 0)
        {
            Console.WriteLine(No);
            return;
        }

        var magWords = new Dictionary<string, int>();
        var noteWords = new Dictionary<string, int>();

        foreach (var word in magazine)
        {
            if (!magWords.ContainsKey(word))
            {
                magWords.Add(word, 1);
            }
            else
            {
                magWords[word] += 1;
            }
        }

        foreach (var word in note)
        {
            if (!noteWords.ContainsKey(word))
            {
                noteWords.Add(word, 1);
            }
            else
            {
                noteWords[word] += 1;
            }
        }

        foreach (var item in noteWords)
        {
            if (magWords.ContainsKey(item.Key) && magWords[item.Key] >= item.Value)
            {
                continue;
            }
            else
            {
                Console.WriteLine(No);
                return;
            }
        }

        Console.WriteLine(Yes);
    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
