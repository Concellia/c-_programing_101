using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingC_
{
    internal class BubbleSort
    {

        public static List<int> Sort(List<int> list)
        {
           
            int n = list.Count;
            int prev = 0;
            //[2,5,1,4,3]
            //[1,2,3,4,5]
            while (n != 0)
            {
                for(int i = 0; i <= n-1; i++)
                {
                    if(i < n-1)
                    {
                        if (list[i] > list[i + 1])
                        {
                            prev = list[i];

                            list[i] = list[i + 1];
                            list[i + 1] = prev;
                        }
                    }
                    
                }

                n--;
            }

            return list;
        }
    }
}
