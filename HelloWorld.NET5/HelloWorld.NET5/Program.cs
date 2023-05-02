using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld.NET5
{
    internal class Program
    {
        /*  static void Main(string[] args)
          {
              Console.WriteLine("Hello World!");
              Console.WriteLine("Hello Tiyiselani!");
              int x;
              x = 20;

              string str1 = "0.85";
              float f1 = float.Parse(str1);
              Console.WriteLine(f1);
              Console.WriteLine(x);

              Console.Read();
          }*/

        public static void Main(string[] args)
        {
            string[,] data = { { "1", "2", "0" }, { "4", "5", "0" } , { "7", "8", "0" } };

            TicTac.Checker(data);



            Console.Read();
        }

        public static void greet(string text)
        {
            Console.WriteLine($"Hi {text}, my friend!");
        }
    }
}
