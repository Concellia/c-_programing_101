using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.NET5
{
    internal class Login
    {

        public static void login() {
            Console.WriteLine("Please register: ");
            Console.WriteLine("Please enter your username: ");
            string username  = Console.ReadLine();
            Console.WriteLine("Please enter password: ");
            string password = Console.ReadLine();

            Console.WriteLine("Please login to your account: ");
            Console.WriteLine("Please enter username: ");
            string loginUser = Console.ReadLine();
            Console.WriteLine("Please enter password: ");
            string loginPass = Console.ReadLine();

            if(loginUser != null && loginPass != null)
            {
                if(loginUser.Equals(username) && loginPass.Equals(password))
                {
                    Console.WriteLine("You have successfully logged in \"__0__\"");
                }else if(!loginUser.Equals(username) ||  !loginPass.Equals(password))
                {
                    Console.WriteLine("Something went wrong");
                }
            }
        
        }
    }
}
