using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.com.hackerrank
{
    public class CountingValleys
    {
        public static int Solve(int stepCount, string steps)
        {
            var valleyCount = 0;
            int altimeter = 0;
            var inValley = false;
            for (int eachStepIndex = 0; eachStepIndex < steps.Length; eachStepIndex++)
            {
                switch (steps[eachStepIndex])
                {
                    case 'U':
                        altimeter++;
                        break;
                    case 'D':
                        altimeter--;
                        break;
                }

                if (altimeter < 0)
                {
                    inValley = true;
                }

                if (altimeter == 0)
                {
                    if (inValley)
                    {
                        valleyCount++;
                    }
                    inValley = false;
                }
            }
            return valleyCount;
        }
    }
}
