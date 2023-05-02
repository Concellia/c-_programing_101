using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.NET5
{
    internal class Students
    {

        public static void averages(string s, string y = "", int n = 5)
        {
         


          /*  while (num  >=-1 && num <= 20)
            {
                Console.WriteLine("Enter a number between 0 and 20 or -1 to quit");
                string strNum = Console.ReadLine();
                int num = 0;
                float result = 0f;
                int counter = 0;
                int total = 0;


                try
                {
                    num = int.Parse(strNum);
                }
                catch (Exception)
                {

                    Console.WriteLine("You did not enter a valid number.");
                }
                if (num == -1)
                {
                    result = total / counter;
                    break;
                }
                total += num;
                counter++;

            }*/

            Console.WriteLine($"hI {s}, {y}, {n} ");

            


        }
    }
}
