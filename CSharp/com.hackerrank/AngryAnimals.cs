using System;
using System.Collections.Generic;
#if DEBUG
using System.Diagnostics;
#endif
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class AngryAnimals
    {
        public static long Solve(int animalsCount, List<int> herbivorusAnimals, List<int> carnivorousAnimals)
        {
            int possibleCompatibleAnimalsCabinCount = 0;
            var incompatibleAnimals = new Dictionary<int, int>();
            var min = 0;

            for (int incompatibleAnimalsIndex = 0; incompatibleAnimalsIndex < herbivorusAnimals.Count; incompatibleAnimalsIndex++)
            {
                if (herbivorusAnimals[incompatibleAnimalsIndex] == carnivorousAnimals[incompatibleAnimalsIndex])
                    continue;

                min = Math.Min(herbivorusAnimals[incompatibleAnimalsIndex], carnivorousAnimals[incompatibleAnimalsIndex]);
                var max = Math.Max(herbivorusAnimals[incompatibleAnimalsIndex], carnivorousAnimals[incompatibleAnimalsIndex]);

                if (!incompatibleAnimals.TryGetValue(min, out var current))
                    incompatibleAnimals.Add(min, max);

                if (current > max)
                    incompatibleAnimals[min] = max;
            }

            var earlyEdge = animalsCount + 1;
            for (int edgeIndex = animalsCount; edgeIndex >= 1; edgeIndex--)
            {
                var add = earlyEdge;
                if (incompatibleAnimals.TryGetValue(edgeIndex, out var enemy))
                {
                    if (earlyEdge > enemy)
                    {
                        earlyEdge = enemy;
                        add = enemy;
                    }
                }

                possibleCompatibleAnimalsCabinCount += (add - edgeIndex);
            }

            return possibleCompatibleAnimalsCabinCount;
        }
    }
}
