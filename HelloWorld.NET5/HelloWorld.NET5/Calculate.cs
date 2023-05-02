using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.NET5
{
    internal class Calculate
    {
       public static int Add() {
            Console.WriteLine("Enter num 1: ");
            string strNum = Console.ReadLine();

            Console.WriteLine("Enter num 2: ");
            string strNum2 = Console.ReadLine();

            try
            {

                return int.Parse(strNum.Trim()) + int.Parse(strNum2.Trim());
            }
            catch (FormatException)
            {
                Console.WriteLine("You entered an invalid number");
              
                return -1;
            }
            catch (Exception)
            {
                Console.WriteLine("Opps something went wrong");
                return 0;
            }finally { Console.WriteLine("We have come to an end!"); }

            
        
        }
    }
}
