using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.NET5
{
    internal class SwitchStatement
    {
        public static void check() 
        {
            Console.WriteLine("Please enter something: ");
            string input = Console.ReadLine();
            Console.WriteLine("What is the data type of the value input: ");
            Console.WriteLine("Enter 1: String");
            Console.WriteLine("Enter 2: Integer");
            Console.WriteLine("Enter 3: Boolean");
            string output = Console.ReadLine();

            switch (output) 
            {

                case "1":
                    bool isValid = true;
                    for(int i = 0; i < input.Length; i++)
                    {
                        if (!Char.IsLetter(input[i]))
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine("You have entered a value {0} and it is a valid string.", input);
                    }
                    else
                    {
                        Console.WriteLine("You have entered a value {0} and it is an invalid string.", input);
                    }
                    
                    break;

                case "2":
                   int num;
                   bool isNun = int.TryParse(input, out num);
                   if(isNun)
                    {
                        Console.WriteLine("You have entered a value {0} and it is a valid int.", num);
                    }
                    else
                    {
                        Console.WriteLine("You have entered a value {0} and it is an invalid int.", input);
                    }
                    break;

                    case "3":
                    bool Bool;
                    bool isBool = bool.TryParse(input, out Bool);
                    if (isBool)
                    {
                        Console.WriteLine("You have entered a value {0} and it is a valid bool.", Bool);
                    }
                    else
                    {
                        Console.WriteLine("You have entered a value {0} and it is an invalid bool.", input);
                    }
                    break;

                    default: 
                    Console.WriteLine("The datatype you entered is not supportd currently.");
                    break;
            }

        }
    }
}
