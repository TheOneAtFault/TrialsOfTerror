using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.R.T.A.D
{
    class ReverseInt
    {
        public static int Run(int num)
        {
            int iNumberRev = 0;
            int x = num;
            try
            {
                while (x != 0)
                {
                    checked
                    {
                        iNumberRev = iNumberRev * 10 + x % 10;
                    }
                    x = x / 10;
                }
            }
            catch (OverflowException e)
            {
                //overflow occured return 0
                return 0;
            }

            return iNumberRev;
        }
    }
}
