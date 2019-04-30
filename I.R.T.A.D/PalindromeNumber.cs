using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.R.T.A.D
{
    class PalindromeNumber
    {
        public static bool Run(int num)
        {
            if (num < 0)
            {
                return false;
            }
            else
            {
                var result =  ReverseInt.Run(num);

                return result == num;
            }
        }

    }
}
