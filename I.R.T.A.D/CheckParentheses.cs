using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.R.T.A.D
{
    class CheckParentheses
    {
        public static bool Run(string input)
        {
            if (string.IsNullOrEmpty(input)) return true;
            
            var dict = new Dictionary<char, char>() { { '(', ')' }, { '[', ']' }, { '{', '}' } };
            Stack<char> stack = new Stack<char>();

            char[] inputArr = input.ToCharArray();

            foreach (var bracket in inputArr)
            {
                if (dict.Keys.Contains(bracket))
                {
                    stack.Push(bracket);
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    if (dict.Values.Contains(bracket))
                    {
                        var lastOn = stack.Pop();
                        if (bracket != dict[lastOn])
                        {
                            return false;
                        }
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
