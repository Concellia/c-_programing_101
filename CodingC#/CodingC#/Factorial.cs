using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingC_
{
    internal class Factorial
    {

        public static int fact(int n)
        {
            if(n<0) return 0;

            if(n == 0 || n == 1) return 1;
            //fact(5) = 120
            //fac(4)*5 24 * 5 = 120
            //fact(3)*4 = 6 * 4 = 24
            //fact(2)*3 = 2*3 = 6
            //fact(1)*2 = 1*2 = 2

            // myPos(8) return myPos;
            //Person 8  
            //Person 7
            //Person 6
            //Person 5
            //Person 4
            //Person 3
            //Person 2
            //Person 1

            return fact(n-1)*n;
        }

        public static int factLoop(int n)
        {
            int result = 1;
            if (n == 0 || n == 1) return 1;
            for(int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
