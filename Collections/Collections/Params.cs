using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Params
    {
        public static void ParamMethodString(params string[] args) 
        { 
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]+" ");
            }
        }



        public static void ParamMethodObj(params object[] args)
        {foreach(object o in args)
            {
                Console.WriteLine(o+" ");
            }
        }


        public static int[] Sort(int[] arr)
        {
            int[] sortedArr = new int[arr.Length];
            int index = 0;

            sortedArr[0] = arr[0];

            for(int i = 0; i<arr.Length; i++)
            {
                for (int x = 0; x < sortedArr.Length; x++)
                {
                    if (arr[i] > sortedArr[x])
                    {
                        index = x + 1;
                    }
                    else
                    {
                        continue;
                    }
                }
               // sortedArr[index] = arr[i-1];
                index = 0;
            }

            return sortedArr;
        }
    
}
}
