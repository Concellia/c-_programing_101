using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ArrayParam
    {
       public static int[] Happines(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]+=2;
            }

            return arr;
        }
    }
}
