using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacConsoleGame
{
    internal class TicTac
    {

        static char[,] field = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        public static void startGame()
        {
            string input = " ";
            int player = 2;
            bool inputCorrect = true;
            int count = 0;

            setTheField();

            do
            {
               
                if (player == 2)
                {
                    player = 1;
                  
                    play(player, input);

                }
                else if (player == 1)
                {
                    player = 2;
                   
                    play(player, input);
                }

                setTheField();

                bool winner = Checker(field);

                if (winner)
                {
                    if(player == 1)
                    {
                        Console.WriteLine("Player 2 has won the game!");
                    }
                    else
                    {
                        
                            Console.WriteLine("Player 1 has won the game!");
                        
                    }
                  

                    field = new char[,]{ { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
                    //setTheField();
                    //Console.ReadKey();
                   

                    inputCorrect = true;
                }
               
                do
                {
              
                    Console.Write("\nPlayer {0} please enter a field: ", player);
                    input = Console.ReadLine();

                    if (input == "1" && field[0, 0] == '1')
                        inputCorrect = true;
                    else if (input == "2" && field[0, 1] == '2')
                        inputCorrect = true;
                    else if (input == "3" && field[0, 2] == '3')
                        inputCorrect = true;
                    else if (input == "4" && field[1, 0] == '4')
                        inputCorrect = true;
                    else if (input == "5" && field[1, 1] == '5')
                        inputCorrect = true;
                    else if (input == "6" && field[1, 2] == '6')
                        inputCorrect = true;
                    else if (input == "7" && field[2, 0] == '7')
                        inputCorrect = true;
                    else if (input == "8" && field[2, 1] == '8')
                        inputCorrect = true;
                    else if (input == "9" && field[2, 2] == '9')
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("You entered an incorrect value");
                        inputCorrect = false;
                    }
                       

                } while (!inputCorrect);
                  


             

            }while (input != "q");

              

          

           

        }

        public static void setTheField()
        {
            Console.Clear();
            Console.WriteLine("Play Tic Tac game press q to quit the game: \n");
            Console.WriteLine("| {0} | {1} | {2} |", field[0, 0], field[0, 1], field[0, 2]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", field[1, 0], field[1, 1], field[1, 2]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", field[2, 0], field[2, 1], field[2, 2]);
        }

        public static bool gameOver()
        {
            bool canPlay = true;
            foreach(char c in field)
            {
                if(c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                {
                    canPlay = true;
                }
                else
                {
                    canPlay = false;
                }
            }

            return canPlay;
        }

        public static void play(int player, string input)
        {
            char c = ' ';
            if(player == 1)
            {
                c = 'X';
            }else if(player == 2)
            {
                c = 'O';
            }

            switch (input)
            {
                case "1":
                    if (input == "1" && field[0, 0] == '1')
                        field[0, 0] = c;
                    break;
                case "2":
                    if (input == "2" && field[0, 1] == '2')
                        field[0, 1] = c;
                    break;
                case "3":
                    if (input == "3" && field[0, 2] == '3')
                        field[0, 2] = c;
                    break;
                case "4":
                    if (input == "4" && field[1, 0] == '4')
                        field[1, 0] = c;
                    break;
                case "5":
                    if (input == "5" && field[1, 1] == '5')
                        field[1, 1] = c;
                    break;
                case "6":
                    if (input == "6" && field[1, 2] == '6')
                        field[1, 2] = c;
                    break;
                case "7":
                    if (input == "7" && field[2, 0] == '7')
                        field[2, 0] = c;
                    break;
                case "8":
                    if (input == "8" && field[2, 1] == '8')
                        field[2, 1] = c;
                    break;
                case "9":
                    if (input == "9" && field[2, 2] == '9')
                        field[2, 2] = c;
                    break;

            }

        }

        public static bool Checker(char[,] board)
        {

            int counter1 = 1;
            char prev1 = ' ';

            int counter2 = 1;
         

            int counter3 = 1;
          
            for (int i = 0; i <= board.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= board.GetUpperBound(1); j++)
                {
                    if (j < board.GetUpperBound(1))
                    {
                        if (board[i, j] == board[i, j + 1])
                        {
                            counter2++;
                        }
                    }

                    if (i < board.GetUpperBound(1))
                    {
                        if (board[i, j] == board[i + 1, j])
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
            if (counter1 == 3 || counter2 == 3 || counter3 == 3)
            {
                return true;
            }

            
            return false;
        }

    }
}
