using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.NET5
{
    internal class Practice
    {

        public static int[,] Reverse2DimArray(int[,] theArray)
        {

            //int[,] x = new int[5, 3];
            for (int rowIndex = 0;rowIndex < 5; rowIndex++)
            {
                for (int colIndex = 0;
                     colIndex < 3/2; colIndex++)
                {
                    int tempHolder = theArray[rowIndex, colIndex];
                    theArray[rowIndex, colIndex] = theArray[rowIndex, (3-1) - colIndex];
                    theArray[rowIndex, (3-1) - colIndex] = tempHolder;

                    //Console.WriteLine(theArray.GetUpperBound(0));
                }
            }

            return theArray;
        }
    }
}
