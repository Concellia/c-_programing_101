using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class JaggedArray
    {
        public static void anArray()
        {
            //An array with two(2) arrays within it
            int[][] jagged = new int[2][];
            jagged[0] = new int[2];
            jagged[1] = new int[3];

            jagged[0] = new int[]{ 1, 2 };
            jagged[1] = new int[]{ 3,4,5};
            

            for(int i = 0; i < jagged.Length; i++)
            {
                for(int j = 0; j < jagged[i].Length; j++)
                {
                    Console.WriteLine(jagged[i][j]);
                }
            }
        }
    }
}
