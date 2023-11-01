using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingC_
{
    internal class StringReverse
    {
        public static string reverseRec(string str)
        {
            if (str == null || str == "")
            {
                return "";
            }

            else
            {
                    return reverseRec(str.Remove(0, 1)) + str.Substring(0, 1);
            }
        }

        public static string reverse(string str)
        {
            string result = "";
            for(int i =  str.Length - 1; i>=0 ;i--)
            {
                result += str[i];
            }

            return result;
        }
    }
}
