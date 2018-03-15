using System;

namespace CSharp.com.hackerrank
{
    public class HolePuzzle
    {
        static HoleMap _map = new HoleMap();
        int count = 0;

        public int Solve(int v)
        {
            string number = v.ToString();
            for (int i = 0; i < number.Length; i++)
            {
                count += _map.GetHoles(number[i]);
            }
            return count;
        }

        class HoleMap
        {
            internal int GetHoles(char v)
            {
                int temp = 0;
                switch (v)
                {
                    case '8':
                        temp = 2;
                        break;
                    case '0':
                    case '4':
                    case '6':
                    case '9':
                        temp = 1;
                        break;
                }
                return temp;
            }
        }
    }
}