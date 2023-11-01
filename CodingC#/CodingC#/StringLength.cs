using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingC_
{
    internal class StringLength
    {
        public static int Length(string s)
        {
            int result = 0;
            foreach (char c in s)
            {
                result++;

            }
            return result;
        }
    }
}
