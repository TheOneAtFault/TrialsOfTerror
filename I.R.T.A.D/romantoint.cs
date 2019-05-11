using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.R.T.A.D
{
    class RomanToInt
    {
        public static int Run(string input)
        {
            var converted = 0;
            var input_ToUpper = input.ToUpper();
            Dictionary<char, int> vault = new Dictionary<char, int>() {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

            for (int i = 0; i < input_ToUpper.Length; i++)
            {
                if (i + 1 < input_ToUpper.Length && vault[input_ToUpper[i]] < vault[input_ToUpper[i+1]])
                {
                    converted -= vault[input_ToUpper[i]];
                }
                else
                {
                    converted += vault[input_ToUpper[i]];
                }
            }

            return converted;
        }
    }
}
