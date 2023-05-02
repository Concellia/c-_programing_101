using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.NET5
{
    internal class TicTac
    {
        public static bool Checker(string[,] board)
        {

            int counter1 = 1;
            string prev1 = "";

            int counter2 = 1;
            string prev2 = "";

            int counter3 = 1;
            string prev3 = "";
            for (int i = 0; i <= board.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= board.GetUpperBound(1); j++)
                {
                    if(j < board.GetUpperBound(1))
                    {
                        if (board[i, j] == board[i, j + 1])
                        {
                            counter2++;
                        }
                    }

                    if (i < board.GetUpperBound(1))
                    {
                        if (board[i, j] == board[i+1, j])
                        {
                            counter3++;
                        }
                    }



                    if (i == j)
                    {
                        if (board[i, j] == prev1)
                        {
                            counter1++;
                        }

                        prev1 = board[i, j];
                    }
                }
            }
            if(counter1 == 3 || counter2 == 3 || counter3 == 3)
            {
                Console.WriteLine("There is a winer");
            }

            Console.WriteLine("This is a counter {0} and this is prev {1}",counter1,prev1);
            return true;
        }


    }
}
