using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class RansomNote
    {
        // Complete the checkMagazine function below.
        static void CheckMagazine(string[] magazine, string[] note)
        {
            const string Yes = nameof(Yes);
            const string No = nameof(No);
            if ((magazine.Length < note.Length) || magazine.Length < 1 || note.Length < 0)
            {
                Console.WriteLine(No);
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
    }
}
