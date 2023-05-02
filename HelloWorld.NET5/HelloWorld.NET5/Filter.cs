using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.NET5
{
    internal class Filter
    {
        public static int[,] applyFilter(int height,int width,int filter,int[,]colors)
        {

            int[,] result = new int[height,width];
            for(int i = 0; i < height;i++)
            {
                if (filter == 1) { 
                    for (int j = 0; j < width/2; j++)
                    {
                        int temp = colors[i, j];
                        colors[i, j] = colors[i, (width - 1) - j];
                        colors[i, (width - 1) - j] = temp;

                    }
        

                }
                if (filter == 2) { 
                    for (int j = 0; j < width; j++)
                        {
                        int temp = avg(colors, i, j, height, width);
                        result[i, j] = temp;
                       
                    }
                }
            }



            if(filter == 1)
            {
                return colors;
            }
            else
            {
                return result;
            }
       
               
           


           
           
        }

        public static int avg(int[,] colors, int xPosition, int yPosition, int height, int width)
        {
            int res = 0;
            int countering = 0;
            int x = xPosition;
            int y = yPosition;
            for (int dx = (x > 0 ? -1 : 0); dx <= (x < height ? 1 : 0);
                 ++dx)
            {
                for (int dy = (y > 0 ? -1 : 0);
                     dy <= (y < width ? 1 : 0); ++dy)
                {
                    if (dx != 0 || dy != 0)
                    {
                        if((y+dy != width) && (x+dx != height))
                        {
                            res += colors[x + dx, y + dy];
                            countering++;
                        }
                        else
                        {
                            continue;
                        }

                    }
                }
            }

            return res / countering;
        }
    }
}
/*--SQL request(s)​​​​​​‌​‌​​​​‌​‌‌​‌‌​​‌​​‌​​​​​ below
SELECT country, beer_consumption
FROM alcohol_consumption
WHERE beer_consumption > spirit_consumption AND beer_consumption > wine_consumption
ORDER BY country DESC;*/