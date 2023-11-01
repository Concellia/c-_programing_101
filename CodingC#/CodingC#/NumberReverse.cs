using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingC_
{
    internal class NumberReverse
    {

        public static int reverseNum(int num)
        {
            int result = 0;
            while (num != 0)
            {
                result *= 10;
                result = result +num % 10;
                num = num / 10;

            }
            return result;
        }
    }
}
